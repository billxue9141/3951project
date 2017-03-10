using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Forest4 : Terrain
    {
        public static int MIN_HP = 1500;
        public static int MAX_HP = 2000;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Tile/medievalTile_48.png";

        public Forest4(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.debugLocation = IMAGE_DEBUG_LOCATION;
            currentHp = MAX_HP;
        }
    }
}
