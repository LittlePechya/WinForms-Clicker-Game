using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Clicker_Game.Abstract;
using Label = System.Windows.Forms.Label;


namespace WinForms_Clicker_Game.UI
{
    public class BoosterUI
    {
        public Booster Booster { get; set; }
        public Label UsagesLeftLabel { get; set; }
        public  Label PriceLabel { get; set; }
        public Button BuyButton { get; set; }

        public BoosterUI(Booster booster, Label usagesLeftLabel, Label priceLabel, Button buyButton)
        {
            Booster = booster;
            UsagesLeftLabel = usagesLeftLabel;
            PriceLabel = priceLabel;
            BuyButton = buyButton;
        }
    }
}
