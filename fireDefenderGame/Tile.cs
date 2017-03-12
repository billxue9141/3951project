using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Tile
    {
        public int row { get; set; }
        public int col { get; set; }
        public Fire fire { get; set; }
        public Terrain terrain { get; set; }
        public bool isSelected;

        public Tile(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.isSelected = false;
        }

    }
}
