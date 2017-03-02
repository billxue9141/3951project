using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class SmallFire : Fire
    {
        static int MIN_HP = 0;
        static int MAX_HP = 100;

        public SmallFire(int row, int col)
        {
            this.row = row;
        }
    }
}
