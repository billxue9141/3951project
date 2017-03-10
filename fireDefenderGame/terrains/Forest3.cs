using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Forest3 : Terrain
    {
        public static int MIN_HP = 1000;
        public static int MAX_HP = 1500;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Tile/medievalTile_47.png";

        public Forest3(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.debugLocation = IMAGE_DEBUG_LOCATION;
            currentHp = MAX_HP;
        }
    }
}
