using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Clicker_Game.Abstract
{
    public class FarmerBooster : UsableBooster
    {
        public FarmerBooster(string name, int price, int usagesCount, int farmerIncomeMultiplier)
            : base(name, price, usagesCount, farmerIncomeMultiplier, player => player.FarmerBoosters)
        {
        }
    }
}
