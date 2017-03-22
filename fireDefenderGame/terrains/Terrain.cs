using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    abstract class Terrain
    {
        public Tile tile { get; set; }
        public Random rng { get; set; }
        public int minHp { get; set; }
        public int maxHp { get; set; }
        public int currentHp { get; set; }
        protected string debugLocation;

        public Terrain(Tile tile, Random rng)
        {
            this.tile = tile;
            this.rng = rng;
        }

        public virtual string getImageDebugLocation()
        {
            return debugLocation;
        }

        public virtual void update()
        {
            if (currentHp <= minHp)
            {
                transform();
                tile.gameBoard.main.updateTile(tile.row, tile.col);
            }
        }

        public abstract void transform();

    }
}
