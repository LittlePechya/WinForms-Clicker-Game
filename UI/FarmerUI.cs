using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace WinForms_Clicker_Game
{
    public class FarmerUI
    {
        public Farmer Farmer { get; set; }
        public Label LevelLabel { get; set; }
        public Label PriceLabel { get; set; }
        public Button BuyButton { get; set; }

        public FarmerUI(Farmer farmer, Label levelLabel, Label priceLabel, Button buyButton)
        {
            Farmer = farmer;
            LevelLabel = levelLabel;
            PriceLabel = priceLabel;
            BuyButton = buyButton;
        }
    }


}
