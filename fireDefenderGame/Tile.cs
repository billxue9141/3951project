using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Tile
    {
        private int row { get; set; }
        private int col { get; set; }
        public Fire fire { get; set; }
        public Terrain terrain { get; set; }

        public Tile(int row, int col)
        {
            this.row = row;
            this.col = col;
        }


    }
}
