using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Clicker_Game
{
    public class ClickerButton
    {
        private Player player;

        public ClickerButton(Player player)
        {
            this.player = player;
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            player.AddMoneyByClick(1);
        }
    }
}
