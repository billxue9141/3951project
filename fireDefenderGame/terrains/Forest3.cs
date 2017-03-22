using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Forest3 : Terrain
    {
        public static int MIN_HP = 2500;
        public static int MAX_HP = 5000;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Tile/medievalTile_47.png";

        public Forest3(Tile tile, Random rng) : base(tile, rng)
        {
            this.debugLocation = IMAGE_DEBUG_LOCATION;
            minHp = MIN_HP;
            maxHp = MAX_HP;
            currentHp = rng.Next(MAX_HP - MIN_HP - 1) + MIN_HP + 1;
        }

        public override void transform()
        {
            Forest2 tmp = new Forest2(tile, rng);
            tmp.currentHp = Forest2.MAX_HP;
            tile.terrain = tmp;
        }
    }
}
