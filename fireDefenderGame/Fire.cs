using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    abstract class Fire
    {
        protected int row { get; set; }
        protected int col { get; set; }
        protected int currentHp { get; set; }
        protected int spreadRadius { get; set; }
        protected int spreadChance { get; set; }
        protected int damage { get; set; }

        /// <summary>
        /// update properties of this object on game tick
        /// </summary>
        public virtual void update() { }


    }
}
