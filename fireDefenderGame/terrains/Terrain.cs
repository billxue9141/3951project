using System;


namespace fireDefenderGame
{
    /// <summary>
    /// abstract class for different types of terrain. 
    /// For now we only have forests.
    /// </summary>
    abstract class Terrain
    {
        public Tile tile { get; set; }
        public Random rng { get; set; }
        public int minHp { get; set; }
        public int maxHp { get; set; }
        public int currentHp { get; set; }
        public Boolean hasWater { get; set; }
        protected string debugLocation;

        public Terrain(Tile tile, Random rng)
        {
            this.tile = tile;
            this.rng = rng;
            hasWater = false;
        }

        /// <summary>
        /// returns the relative location of this object's image file.
        /// </summary>
        /// <returns></returns>
        public virtual string getImageDebugLocation()
        {
            return debugLocation;
        }

        /// <summary>
        /// update this terrain. 
        /// if conditions are met (eg. trees falls below 0), transform this object into a different one.
        /// </summary>
        public virtual void update()
        {
            if (currentHp <= minHp)
            {
                transform();
                tile.gameBoard.main.updateTile(tile.row, tile.col);
            }
        }
        /// <summary>
        /// transform this object into a different one if conditions are met.
        /// </summary>
        public abstract void transform();

        /// <summary>
        /// set this terrain's water resources to true
        /// </summary>
        public abstract void setHasWater();

    }
}
