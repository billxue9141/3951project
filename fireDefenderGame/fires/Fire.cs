using fireDefenderGame.buildings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    /// <summary>
    /// Abstract class for all the game objects that acts as a fire.
    /// </summary>
    abstract class Fire
    {
        public Tile tile { get; set; }
        public int currentHp { get; set; }
        public int minHp { get; set; }
        public int maxHp { get; set; }
        protected int spreadRadius { get; set; }
        protected int spreadChance { get; set; }
        protected int damage { get; set; }
        protected int minDamage { get; set; }
        protected int maxDamage { get; set; }
        protected string debugLocation;
        public Random rng;

        public Fire(ref Tile tile, Random rng)
        {
            this.tile = tile;
            this.rng = rng;
        }

        /// <summary>
        /// returns the relative location of this object's image
        /// </summary>
        /// <returns></returns>
        public virtual string getImageDebugLocation()
        {
            return debugLocation;
        }

        /// <summary>
        /// update properties of this object on game tick
        /// </summary>
        public virtual void update()
        {
            if (tile.terrain.currentHp > 0)
                currentHp++;
            else if (currentHp > 0)
                currentHp = currentHp - 10;

            damage = rng.Next(maxDamage - minDamage) + minDamage;

            //currently fire only damages the fire station for testing purpose
            if(tile.building != null && tile.building.GetType() == typeof(FireStation))
                tile.building.currentHp -= damage;
            else if (tile.unit != null)
                tile.unit.currentHp -= damage;
            else
                tile.terrain.currentHp -= damage;

            if (currentHp >= maxHp || currentHp <= minHp)
            {
                transform();
            }
            spreadFire();
        }


        /// <summary>
        /// spread fire to neighbor tiles if possible
        /// </summary>
        public void spreadFire()
        {
            if (rng.Next(100) <= spreadChance)
            {
                if (tile.findNeighborsWithoutFire(spreadRadius) == null)
                    return;
                Tile[] neighborsWithoutFire = tile.findNeighborsWithoutFire(spreadRadius);
                int randomIndex = rng.Next(tile.countNeighborsWithoutFire(spreadRadius));
                Fire newFire = new SmallFire(neighborsWithoutFire[randomIndex], rng);
                newFire.currentHp = rng.Next(newFire.maxHp - newFire.minHp);
                neighborsWithoutFire[randomIndex].fire = newFire;
                tile.gameBoard.main.updateTile(newFire.tile.row, newFire.tile.col);
            }
        }

        public abstract void transform();

    }
}
