using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Clicker_Game.Abstract
{
    public class ClickerBooster : UsableBooster
    {
        public ClickerBooster(string name, int price, int usagesCount, int clickMultiplier)
            : base(name, price, usagesCount, clickMultiplier, player => player.ClickerBoosters)
        {
        }
    }
}
