using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Clicker_Game.Abstract;

namespace WinForms_Clicker_Game.Boosters
{
    internal class QuickFarmBooster : FarmerBooster
    {
        public QuickFarmBooster()
            : base(
                name: "Quick Farm Booster",
                price: 100,
                usagesCount: 10,
                boostedIncomeInterval: 1000)
        {
        }
    }
}
