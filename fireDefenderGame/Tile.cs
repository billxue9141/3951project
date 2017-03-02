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
        private Fire fire { get; set; }
        private Terrain terrain { get; set; }
        public bool hasFire { get; set; }

        public Tile(int row, int col)
        {
            this.row = row;
            this.col = col;
            hasFire = false;
        }

        public void addFire(Fire fire)
        {
            this.fire = fire;
            hasFire = true;
        }
    }
}
