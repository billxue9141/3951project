using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame.buildings
{
    class EnergyGenerator : Building
    {
        public static int BUILD_COST = 10;
        public static int UPGRADE_COST = 30;
        public static int MIN_HP = 0;
        public static int MAX_HP = 1000;
        public static int WATER_USAGE = 1;
        public static int WATER_PRODUCTION = 0;
        public static int ENERGY_PRODUCTION = 1;
        static int MIN_DAMAGE = 0;
        static int MAX_DAMAGE = 0;
        static int RADIUS = 0;
        public static String INIT_DESCRIPTION = "Energy Generator";
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Structure/medievalStructure_01.png";

        public EnergyGenerator(Tile tile, Random rng) : base(tile, rng)
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
            upgradeCost = UPGRADE_COST;
            description = INIT_DESCRIPTION;
            
            nextLevelHp = maxHp;
            nextLevelMinDamage = minDamage;
            nextLevelMaxDamage = maxDamage;
            nextLevelRange = radius;
            nextLevelWaterProduction = waterProduction;
            nextLevelEnergyProduction = energyProduction + 1;

            tile.gameBoard.gameResource.waterUsage += waterUsage;
            tile.gameBoard.gameResource.waterProduction += waterProduction;
            tile.gameBoard.gameResource.energyGeneration += energyProduction;
        }

        public override void upgrade()
        {
            base.upgrade();

            nextLevelEnergyProduction = energyProduction + 1;
            upgradeCost = upgradeCost * 3;
            update();
        }
    }
}

