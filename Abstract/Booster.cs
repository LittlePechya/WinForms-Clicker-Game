using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Clicker_Game.Abstract
{
    public abstract class Booster
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Price { get; set; }
        public int UsagesCount { get; set; }
        public int UsagesLeft { get; set; }

        public event Action OnBoosterChanged;
        public Booster(string name, int price)
        {
            Name = name;
            Price = price;
            IsActive = false;
        }
        protected void BoosterChanged()
        {
            OnBoosterChanged?.Invoke();
        }

        public abstract bool BuyBooster(Player player);
        public abstract void DeactivateBooster(Player player);
    }
}
