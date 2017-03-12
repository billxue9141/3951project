using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    abstract class Terrain
    {
        protected int row { get; set; }
        protected int col { get; set; }
        public int currentHp { get; set; }
        protected string debugLocation;


        public virtual string getImageDebugLocation()
        {
            return debugLocation;
        }

    }
}
