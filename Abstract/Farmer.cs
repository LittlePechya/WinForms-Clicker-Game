using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Clicker_Game
{
    public abstract class Farmer
    {
        public string Name { get; set; }
        public int CurrentLevel { get; set; }
        public int IncomePerLevel { get; set; }
        public Dictionary<int, int> LevelUpCosts { get; set; }

        public event Action OnFarmerChanged;

        public Farmer(string name, int incomePerLevel, Dictionary<int, int> levelUpCosts)
        {
            Name = name;
            CurrentLevel = 0;
            IncomePerLevel = incomePerLevel;
            LevelUpCosts = levelUpCosts;
        }

        public virtual int CalculateIncome()
        {
            return CurrentLevel * IncomePerLevel;
        }

        public virtual bool BuyLevelUp(Player player)
        {
            int nextLevel = CurrentLevel + 1;

            if (!LevelUpCosts.ContainsKey(nextLevel))
            {
                return false;
            }

            int cost = LevelUpCosts[nextLevel];

            if (player.CurrentMoney < cost)
            {
                return false;
            }

            player.CurrentMoney -= cost;
            CurrentLevel++;
            OnFarmerChanged?.Invoke();
            return true;
        }
    }
}
