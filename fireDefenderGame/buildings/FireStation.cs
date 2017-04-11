using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame.buildings
{
    /// <summary>
    /// the main building player has to protect. 
    /// If the fire station catches on fire, game over.
    /// </summary>
    class FireStation : Building
    {
        public static int UPGRADE_COST = 30;
        public static int MIN_HP = 0;
        public static int MAX_HP = 1000;
        public static int WATER_PRODUCTION = 1;
        static int MIN_DAMAGE = 0;
        static int MAX_DAMAGE = 0;
        static int RADIUS = 1;
        public static String INIT_DESCRIPTION = "Fire Station";
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Structure/medievalStructure_20.png";

        public FireStation(Tile tile, Random rng) : base(tile, rng)
        {
            debugLocation = IMAGE_DEBUG_LOCATION;
            minHp = MIN_HP;
            maxHp = MAX_HP;
            minDamage = MIN_DAMAGE;
            maxDamage = MAX_DAMAGE;
            radius = RADIUS;
            currentHp = maxHp;
            waterProduction = WATER_PRODUCTION;
            description = INIT_DESCRIPTION;
            tile.terrain = new Forest1(tile, rng);
            upgradeCost = UPGRADE_COST;

            nextLevelHp = maxHp;
            nextLevelMinDamage = minDamage;
            nextLevelMaxDamage = maxDamage;
            nextLevelRange = radius + 1;
            nextLevelWaterProduction = waterProduction + 1;

            tile.gameBoard.gameResource.waterProduction += waterProduction;
        }

        public override void upgrade()
        {
            base.upgrade();
            radius = nextLevelRange;
            tile.gameBoard.gameResource.waterProduction += nextLevelWaterProduction - waterProduction;
            waterProduction = nextLevelWaterProduction;

            nextLevelRange = radius + 1;
            nextLevelWaterProduction = waterProduction + 1;
            upgradeCost = upgradeCost * 3;
            update();
        }
    }
}
