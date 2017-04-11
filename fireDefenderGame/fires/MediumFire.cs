using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class MediumFire : Fire
    {
        static int MIN_HP = 200;
        static int MAX_HP = 500;
        static int MY_SPREAD_RADIUS = 1;
        static int MY_SPREAD_CHANCE = 1;
        static int MIN_DAMAGE = 4;
        static int MAX_DAMAGE = 6;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Environment/fire2.png";

        public MediumFire(Tile tile, Random rng) : base(ref tile, rng)
        {
            currentHp = MIN_HP + 1;
            minHp = MIN_HP;
            maxHp = MAX_HP;
            minDamage = MIN_DAMAGE;
            maxDamage = MAX_DAMAGE;
            spreadChance = MY_SPREAD_CHANCE;
            spreadRadius = MY_SPREAD_RADIUS;
            this.debugLocation = IMAGE_DEBUG_LOCATION;
        }

        public override void transform()
        {
            if (currentHp >= maxHp)
            {
                LargeFire tmp = new LargeFire(tile, rng);
                tile.fire = tmp;
            }
            else if (currentHp <= minHp)
            {
                SmallFire tmp = new SmallFire(tile, rng);
                tmp.currentHp = tmp.maxHp;
                tile.fire = tmp;
            }
            tile.gameBoard.main.updateTile(tile.row, tile.col);
        }
    }
}
