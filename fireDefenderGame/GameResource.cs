using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    /// <summary>
    /// keeps track of the game resources we use.
    /// </summary>
    class GameResource
    {
        public int waterProduction { get; set; }
        public int waterUsage { get; set; }
        public int energy { get; set; }
        public int energyGeneration {get;set; }

        public GameResource()
        {
            waterProduction = 0;
            waterUsage = 0;
            energy = 0;
            energyGeneration = 0;
        }

        /// <summary>
        /// update the resources on the board
        /// </summary>
        public void update()
        {
            energy += energyGeneration;
        }
    }
}
