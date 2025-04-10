using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Clicker_Game.Abstract
{
    public abstract class UsableBooster : Booster
    {
        public int Multiplier { get; set; }
        private readonly Func<Player, List<Booster>> _getBoosterList;

        public UsableBooster(string name, int price, int usagesCount, int multiplier, Func<Player, List<Booster>> getBoosterList)
            : base(name, price)
        {
            UsagesCount = usagesCount;
            UsagesLeft = usagesCount;
            Multiplier = multiplier;
            _getBoosterList = getBoosterList;
        }

        public override int UseBooster(Player player)
        {
            if (UsagesLeft > 0)
            {
                UsagesLeft--;
                BoosterChanged();
                return Multiplier;
            }
            else
            {
                DeactivateBooster(player);
                return 1;
            }
        }

        public override bool BuyBooster(Player player)
        {
            if (IsActive) return false;
            if (player.CurrentMoney < Price) return false;

            player.CurrentMoney -= Price;
            UsagesLeft = UsagesCount;
            IsActive = true;
            _getBoosterList(player).Add(this);
            BoosterChanged();
            return true;
        }

        public override void DeactivateBooster(Player player)
        {
            IsActive = false;
            _getBoosterList(player).Remove(this);
            BoosterChanged();
        }
    }
}
