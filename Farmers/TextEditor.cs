using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Clicker_Game.Farmers
{
    internal class TextEditor : Farmer
    {
        public TextEditor()
            : base(
                name: "Text Editor",
                incomePerLevel: 2,
                levelUpCosts: new Dictionary<int, int>
                {
                    { 1, 60 },
                    { 2, 90 },
                    { 3, 120 },
                    { 4, 150 },
                    { 5, 180 }
                })
        {
        }
    }
}
