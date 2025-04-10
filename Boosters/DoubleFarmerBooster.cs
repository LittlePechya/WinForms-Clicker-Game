using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Clicker_Game.Abstract;

namespace WinForms_Clicker_Game.Boosters
{
    public class DoubleFarmerBooster : FarmerBooster
    {
        public DoubleFarmerBooster()
            : base(
                  name: "Double Farmer Booster",
                  price: 40,
                  usagesCount: 10,
                  farmerIncomeMultiplier: 2)
        {
        }
    }
}
