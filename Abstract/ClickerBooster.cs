using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Clicker_Game.Abstract
{
    public abstract class ClickerBooster : Booster
    {
        
        public int ClickMultiplier { get; set; }

        public ClickerBooster(string name, int price, int usagesCount, int clickMultiplier)
        : base(name, price)
        {
            UsagesCount = usagesCount;
            UsagesLeft = usagesCount;
            ClickMultiplier = clickMultiplier;
        }

        public int UseBooster(Player player)
        {
            if (UsagesLeft > 0)
            {
                UsagesLeft--;
                BoosterChanged();
                return ClickMultiplier;
            }
            else
            {
                DeactivateBooster(player);
                return 1;
            }
        }

        public override bool BuyBooster(Player player)
        {
            if (IsActive) return false;

            if (player.CurrentMoney < Price) return false;

            player.CurrentMoney -= Price;
            UsagesLeft = UsagesCount;
            IsActive = true;
            player.ClickerBoosters.Add(this);
            BoosterChanged();
            return true;
        }

        public override void DeactivateBooster(Player player)
        {
            IsActive = false;
            player.ClickerBoosters.Remove(this);
            BoosterChanged();
        }
    }
}
