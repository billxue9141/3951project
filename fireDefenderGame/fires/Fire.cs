using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    abstract class Fire
    {
        public Tile tile { get; set; }
        public int currentHp { get; set; }
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

        public virtual string getImageDebugLocation()
        {
            return debugLocation;
        }

        /// <summary>
        /// update properties of this object on game tick
        /// </summary>
        public virtual void update() {
            currentHp++;
            damage = rng.Next(maxDamage - minDamage) + minDamage;
            tile.terrain.currentHp -= damage;

        }


    }
}
