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
        public List<Booster> ClickerBoosters { get; set; }
        public List<Booster> FarmerBoosters { get; set; }

        public event Action PlayerMadeAction;

        public Player(string name)
        {
            Name = name;
            ClickerBoosters = new List<Booster>();
            FarmerBoosters = new List<Booster>();
        }

        private void AddMoney<TBooster>(List <TBooster> boosters, int moneyAmount) where TBooster : Booster
        {
            var multiplier = 1;
            var boostersCopy = new List<TBooster>(boosters);

            foreach (var booster in boostersCopy)
            {
                multiplier *= booster.UseBooster(this);
            }

            int totalMoney = moneyAmount * multiplier;
            CurrentMoney += totalMoney;
            TotalMoney += totalMoney;
            PlayerMadeAction?.Invoke();
        }

        public void AddMoneyByClick(int amount)
        {
            AddMoney(ClickerBoosters, amount);
        }

        public void AddMoneyByFarmers(int amount)
        {
            AddMoney(FarmerBoosters, amount);
        }
    }
}
