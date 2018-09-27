using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame.buildings
{
    /// <summary>
    /// pipe powers neighboring tiles with water
    /// </summary>
    class Pipe:Building
    {
        public static int BUILD_COST = 25;
        public static int UPGRADE_COST = 50;
        public static int MIN_HP = 0;
        public static int MAX_HP = 1000;
        public static int WATER_USAGE = 1;
        public static int WATER_PRODUCTION = 0;
        public static int ENERGY_PRODUCTION = 0;
        static int MIN_DAMAGE = 0;
        static int MAX_DAMAGE = 0;
        static int RADIUS = 2;
        public static String INIT_DESCRIPTION = "Water Pipe";
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Structure/medievalStructure_12.png";

        public Pipe(Tile tile, Random rng) : base(tile, rng)
        {
            debugLocation = IMAGE_DEBUG_LOCATION;
            minHp = MIN_HP;
            maxHp = MAX_HP;
            minDamage = MIN_DAMAGE;
            maxDamage = MAX_DAMAGE;
            radius = RADIUS;
            currentHp = maxHp;
            waterUsage = WATER_USAGE;
            waterProduction = WATER_PRODUCTION;
            energyProduction = ENERGY_PRODUCTION;
            waterUsage = WATER_USAGE;
            description = INIT_DESCRIPTION;
            upgradeCost = UPGRADE_COST;

            nextLevelHp = maxHp;
            nextLevelMinDamage = minDamage;
            nextLevelMaxDamage = maxDamage;
            nextLevelRange = radius + 1;
            nextLevelWaterProduction = waterProduction;
            nextLevelEnergyProduction = energyProduction;

            tile.gameBoard.gameResource.waterUsage += waterUsage;
            tile.gameBoard.gameResource.waterProduction += waterProduction;
            tile.gameBoard.gameResource.energyGeneration += energyProduction;
        }

        public override void upgrade()
        {
            base.upgrade();

            nextLevelRange = radius + 1;
            upgradeCost = upgradeCost * 2;
            update();
        }
    }
}
