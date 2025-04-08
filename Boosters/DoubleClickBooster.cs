using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Clicker_Game.Abstract;

namespace WinForms_Clicker_Game.Boosters
{
    public class DoubleClickBooster : ClickerBooster
    {
        public DoubleClickBooster()
            : base(
                name: "Double Click Booster",
                price: 20,
                usagesCount: 20,
                clickMultiplier: 2)
        {
        }
    }
}
