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
        protected int currentHp { get; set; }
    }
}
