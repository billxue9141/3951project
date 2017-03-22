using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Forest4 : Terrain
    {
        public static int MIN_HP = 5000;
        public static int MAX_HP = 10000;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Tile/medievalTile_48.png";

        public Forest4(Tile tile, Random rng) : base(tile, rng)
        {
            this.debugLocation = IMAGE_DEBUG_LOCATION;
            minHp = MIN_HP;
            maxHp = MAX_HP;
            currentHp = rng.Next(MAX_HP - MIN_HP - 1) + MIN_HP + 1;
        }

        public override void transform()
        {
            Forest3 tmp = new Forest3(tile, rng);
            tmp.currentHp = Forest3.MAX_HP;
            tile.terrain = tmp;
        }
    }
}
