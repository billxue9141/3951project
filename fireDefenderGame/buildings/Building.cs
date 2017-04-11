using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame.buildings
{
    /// <summary>
    /// abstract class for all the game objects that acts as a building
    /// </summary>
    abstract class Building
    {
        public Tile tile { get; set; }
        public Random rng { get; set; }
        public int minHp { get; set; }
        public int maxHp { get; set; }
        public int currentHp { get; set; }
        public string description { get; set; }
        protected int damage { get; set; }
        public int minDamage { get; set; }
        public int maxDamage { get; set; }
        public int waterProduction { get; set; }
        public int waterUsage { get; set; }
        public int radius { get; set; }

        public int upgradeCost { get; set; }
        public int nextLevelHp { get; set; }
        public int nextLevelMinDamage { get; set; }
        public int nextLevelMaxDamage { get; set; }
        public int nextLevelWaterProduction { get; set; }
        public int nextLevelRange { get; set; }
        protected string debugLocation;

        public Building(Tile tile, Random rng)
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
            PowerNeighborTiles(radius);
        }

        /// <summary>
        /// power neighboring tiles within this building's range with water.
        /// </summary>
        /// <param name="radius"></param>
        public void PowerNeighborTiles(int radius)
        {
            if (!tile.terrain.hasWater)
                tile.terrain.setHasWater();
            Tile[] tiles = tile.findNeighbors(radius);
            foreach (Tile tile in tiles)
            {
                if (!tile.terrain.hasWater)
                    tile.terrain.setHasWater();
            }
        }

        public virtual void upgrade() { }
    }
}
