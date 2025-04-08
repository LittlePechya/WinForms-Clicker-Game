using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Clicker_Game.Farmers
{
    public class AutoClicker : Farmer
    {
        public AutoClicker()
            : base(
                name: "AutoClicker",
                incomePerLevel: 1,
                levelUpCosts: new Dictionary<int, int>
                {
                    { 1, 30 },
                    { 2, 45 },
                    { 3, 60 },
                    { 4, 75 },
                    { 5, 90 }
                })
        {
        }
    }
}
