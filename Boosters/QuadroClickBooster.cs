using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Clicker_Game.Abstract;

namespace WinForms_Clicker_Game.Boosters
{
    public class QuadroClickBooster : ClickerBooster
    {
        public QuadroClickBooster()
            : base(
                name: "Quadro Click Booster",
                price: 60,
                usagesCount: 30,
                clickMultiplier: 4)
        {
        }
    }
}
