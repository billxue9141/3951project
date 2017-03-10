using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class SmallFire : Fire
    {
        static int MIN_HP = 0;
        static int MAX_HP = 100;
        static int MY_SPREAD_RADIUS = 0;
        static int MY_SPREAD_CHANCE = 0;
        static int MIN_DAMAGE = 1;
        static int MAX_DAMAGE = 5;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Environment/medievalEnvironment_21.png";

        public SmallFire(int row, int col)
        {
            this.row = row;
            this.col = col;
            currentHp = MIN_HP + 1;
            spreadChance = MY_SPREAD_CHANCE;
            spreadRadius = MY_SPREAD_RADIUS;
            this.debugLocation = IMAGE_DEBUG_LOCATION;
        }

        public override void update()
        {
            currentHp++;
        }
    }
}
