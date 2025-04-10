using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Clicker_Game.Abstract;
using WinForms_Clicker_Game.Boosters;
using WinForms_Clicker_Game.Farmers;
using WinForms_Clicker_Game.UI;

namespace WinForms_Clicker_Game
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer incomeTimer;

        private Player player;
        private ClickerButton clickerButton;

        // Farmers
        private List<Farmer> farmers = new List<Farmer>();
        private List<FarmerUI> farmerUIs = new List<FarmerUI>();
        private AutoClicker autoClicker;
        private TextEditor textEditor;

        // Boosters
        private List<Booster> boosters = new List<Booster>();
        private List<BoosterUI> boosterUIs = new List<BoosterUI>();


        public MainForm(Player player)
        {
            InitializeComponent();
            this.player = player;
            clickerButton = new ClickerButton(player);
            clicker.Click += clickerButton.OnButtonClick;

            InitializeFarmers();
            InitializeBoosters();

            // Subscribe to events
            player.PlayerMadeAction += UpdateUI;

            SetupIncomeTimer();

            UpdateUI();
        }

        private void InitializeFarmers()
        {
            autoClicker = new AutoClicker();
            farmers.Add(autoClicker);
            farmerUIs.Add(new FarmerUI(autoClicker, AutoClickerLevel, AutoClickerCurrentPrice, AutoClickerBuyButton));

            textEditor = new TextEditor();
            farmers.Add(textEditor);
            farmerUIs.Add(new FarmerUI(textEditor, TextEditorLevel, TextEditorCurrentPrice, TextEditorBuyButton));

            foreach (var farmerUI in farmerUIs)
            {
                farmerUI.BuyButton.Click += (s, e) => farmerUI.Farmer.BuyLevelUp(player);
                farmerUI.Farmer.OnFarmerChanged += UpdateUI;
            }
        }

        private void InitializeBoosters()
        {
            var doubleClickBooster = new DoubleClickBooster();
            boosters.Add(doubleClickBooster);
            boosterUIs.Add(new BoosterUI(doubleClickBooster, DoubleClickActiveStatus, DoubleClickPrice, DoubleClickBuyButton));

            var quadroClickBooster = new QuadroClickBooster();
            boosters.Add(quadroClickBooster);
            boosterUIs.Add(new BoosterUI(quadroClickBooster, QuadroClickActiveStatus, QuadroClickPrice, QuadroClickBuyButton));

            var doubleFarmerBooster = new DoubleFarmerBooster();
            boosters.Add(doubleFarmerBooster);
            boosterUIs.Add(new BoosterUI(doubleFarmerBooster, DoubleFarmerBoosterActiveStatus, DoubleFarmerBoosterPrice, DoubleFarmerBoosterBuyButton));

            foreach (var boosterUI in boosterUIs)
            {
                boosterUI.BuyButton.Click += (s, e) => boosterUI.Booster.BuyBooster(player);
                boosterUI.Booster.OnBoosterChanged += UpdateUI;
            }
        }

        private void UpdateUI()
        {
            CurrentMoneyTextBox.Text = player.CurrentMoney.ToString();
            TotalMoneyTextBox.Text = "Total $ earned: " + player.TotalMoney.ToString();

            foreach (var farmerUI in farmerUIs)
            {
                farmerUI.LevelLabel.Text = $"LVL {farmerUI.Farmer.CurrentLevel}";

                int nextLevel = farmerUI.Farmer.CurrentLevel + 1;
                if (farmerUI.Farmer.LevelUpCosts.ContainsKey(nextLevel))
                {
                    farmerUI.PriceLabel.Text = $"Price {farmerUI.Farmer.LevelUpCosts[nextLevel]}$";
                    farmerUI.BuyButton.Enabled = player.CurrentMoney >= farmerUI.Farmer.LevelUpCosts[nextLevel];
                }
                else
                {
                    farmerUI.PriceLabel.Text = "Max Level";
                    farmerUI.BuyButton.Enabled = false;
                }
            }

            foreach (var boosterUI in boosterUIs)
            {
                boosterUI.PriceLabel.Text = $"Price {boosterUI.Booster.Price}$";

                if (boosterUI.Booster.IsActive)
                {
                    boosterUI.UsagesLeftLabel.Text = "Active";
                    boosterUI.BuyButton.Enabled = false;
                }
                else
                {
                    boosterUI.UsagesLeftLabel.Text = "Inactive";
                    boosterUI.BuyButton.Enabled = player.CurrentMoney >= boosterUI.Booster.Price;
                }
            }
        }

        private void IncomeTimerTick(object sender, EventArgs e)
        {
            int totalIncome = 0;
            foreach (var farmer in farmers)
            {
                if (farmer.CurrentLevel > 0)
                {
                    totalIncome += farmer.CalculateIncome();
                }
            }
            player.AddMoneyByFarmers(totalIncome);
        }

        private void SetupIncomeTimer()
        {
            incomeTimer = new System.Windows.Forms.Timer();
            incomeTimer.Interval = 5000; // ms
            incomeTimer.Tick += IncomeTimerTick;
            incomeTimer.Start();
        }
    }
}
