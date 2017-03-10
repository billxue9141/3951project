using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Forest1 : Terrain
    {
        public static int MIN_HP = 0;
        public static int MAX_HP = 500;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Tile/medievalTile_45.png";

        public Forest1(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.debugLocation = IMAGE_DEBUG_LOCATION;
            currentHp = MAX_HP;
        }
    }
}
