using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Forest2 : Terrain
    {
        public static int MIN_HP = 1000;
        public static int MAX_HP = 2500;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Tile/medievalTile_46.png";

        public Forest2(Tile tile, Random rng) : base(tile, rng)
        {
            this.debugLocation = IMAGE_DEBUG_LOCATION;
            minHp = MIN_HP;
            maxHp = MAX_HP;
            currentHp = rng.Next(MAX_HP - MIN_HP - 1) + MIN_HP + 1;
        }

        public override void transform()
        {
            Forest1 tmp = new Forest1(tile, rng);
            tmp.currentHp = Forest1.MAX_HP;
            tile.terrain = tmp;
        }
    }
}
