using System;


namespace fireDefenderGame
{

    /// <summary>
    /// abstract class for units
    /// </summary>
    abstract class Unit
    {
        public Tile tile { get; set; }
        public Random rng { get; set; }
        public int minHp { get; set; }
        public int maxHp { get; set; }
        public int currentHp { get; set; }
        public int hpRegen { get; set; }
        public int attackRange { get; set; }
        public string description { get; set; }
        protected int damage { get; set; }
        public int minDamage { get; set; }
        public int maxDamage { get; set; }
        public int waterUsage { get; set; }

        public int upgradeCost { get; set; }
        public int nextLevelHp { get; set; }
        public int nextLevelMinDamage { get; set; }
        public int nextLevelMaxDamage { get; set; }
        public int nextLevelRange { get; set; }
        protected string debugLocation;

        public Unit(Tile tile, Random rng)
        {
            this.tile = tile;
            this.rng = rng;
        }

        /// <summary>
        /// returns the relative location of this object's image file
        /// </summary>
        /// <returns></returns>
        public virtual string getImageDebugLocation()
        {
            return debugLocation;
        }

        /// <summary>
        /// update this unit, make it attack tiles with fire if possible
        /// </summary>
        public virtual void update()
        {
            if (currentHp < maxHp)
                currentHp += hpRegen;
            if (tile.countNeighborsWithFire(attackRange) == 0)
                if (tile.fire == null)
                    return;

            damage = rng.Next(maxDamage - minDamage) + minDamage;
            if (tile.fire != null)
            {
                tile.fire.currentHp -= damage;
                return;
            }
            Tile[] neighborsWithFire = tile.findNeighborsWithFire(attackRange);
            Tile tileWithSmallestFire = neighborsWithFire[0];

            foreach (Tile tile in neighborsWithFire)
                if (tile.fire.currentHp < tileWithSmallestFire.fire.currentHp)
                    tileWithSmallestFire = tile;

            tileWithSmallestFire.fire.currentHp -= damage;
        }

        /// <summary>
        /// make a copy of this unit.
        /// this method is used to move this object to a new location on the gameboard.
        /// </summary>
        /// <returns></returns>
        public abstract Unit copy();

        /// <summary>
        /// upgrade the unit 
        /// </summary>
        public virtual void upgrade()
        {

        }
    }
}