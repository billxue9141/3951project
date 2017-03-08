using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Forest : Terrain
    {
        static int MIN_HP = 0;
        static int MAX_HP = 1000;
        static String LOCATION = "resources/Tile/medievalTile_48.png";

        public Forest(int row, int col)
        {
            this.row = row;
            this.col = col;
            currentHp = MAX_HP;
        }
    }
}
