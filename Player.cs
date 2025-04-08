using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Clicker_Game.Abstract;

namespace WinForms_Clicker_Game
{
    public class Player
    {
        public string Name { get; set; }
        public int CurrentMoney { get; set; }
        public int TotalMoney { get; set; }
        public List<ClickerBooster> ClickerBoosters { get; set; }
        public int ClickerMultiplier { get; set; }


        public event Action PlayerMadeAction;

        public Player(string name)
        {
            Name = name;
            ClickerBoosters = new List<ClickerBooster>();
        }

        public void AddMoneyByClick(int amount)
        {
            ClickerMultiplier = 1;

            var boostersCopy = new List<ClickerBooster>(ClickerBoosters);

            foreach (var clikerBooster in boostersCopy)
            {
                ClickerMultiplier *= clikerBooster.UseBooster(this);
            }

            int totalMoney = amount * ClickerMultiplier;
            CurrentMoney += totalMoney;
            TotalMoney += totalMoney;
            PlayerMadeAction?.Invoke();
        }
        public void AddMoneyByFarmers(int amount)
        {
            CurrentMoney += amount;
            TotalMoney += amount;
            PlayerMadeAction?.Invoke();
        }
    }
}
