using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Clicker_Game.Abstract
{
    public abstract class FarmerBooster : Booster
    {
        public int FarmerIncomeMultiplier { get; set; }
        public FarmerBooster(string name, int price, int usagesCount, int farmerIncomeMultiplier)
            : base(name, price)
        {
            UsagesCount = usagesCount;
            UsagesLeft = usagesCount;
            FarmerIncomeMultiplier = farmerIncomeMultiplier;
        }

        public override int UseBooster(Player player)
        {
            if (UsagesLeft > 0)
            {
                UsagesLeft--;
                BoosterChanged();
                return FarmerIncomeMultiplier;
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
            player.FarmerBoosters.Add(this);
            BoosterChanged();
            return true;

        }

        public override void DeactivateBooster(Player player)
        {
            IsActive = false;
            player.FarmerBoosters.Remove(this);
            BoosterChanged();
        }
    }
}
