using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class LargeFire : Fire
    {
        static int MIN_HP = 200;
        static int MAX_HP = 500;
        static int MY_SPREAD_RADIUS = 0;
        static int MY_SPREAD_CHANCE = 0;
        static int MIN_DAMAGE = 7;
        static int MAX_DAMAGE = 10;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Environment/fire3.png";

        public LargeFire(Tile tile, Random rng) : base(ref tile, rng)
        {
            currentHp = MIN_HP + 1;
            minDamage = MIN_DAMAGE;
            maxDamage = MAX_DAMAGE;
            spreadChance = MY_SPREAD_CHANCE;
            spreadRadius = MY_SPREAD_RADIUS;
            this.debugLocation = IMAGE_DEBUG_LOCATION;
        }

    }
}
