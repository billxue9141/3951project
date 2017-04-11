using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Defender:Unit
    {
        public static int BUILD_COST = 20;
        public static int UPGRADE_COST = 100;
        public static int MIN_HP = 0;
        public static int MAX_HP = 200;
        public static int HP_REGEN = 0;
        public static int MIN_DAMAGE = 5;
        public static int MAX_DAMAGE = 8;
        public static int ATTACK_RANGE = 1;
        public static int WATER_USAGE = 1;
        public static String INIT_DESCRIPTION = "Defender";
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Unit/character01.png";

        public Defender(Tile tile, Random rng) : base(tile, rng)
        {
            this.debugLocation = IMAGE_DEBUG_LOCATION;
            minHp = MIN_HP;
            maxHp = MAX_HP;
            currentHp = maxHp;
            hpRegen = HP_REGEN;
            minDamage = MIN_DAMAGE;
            maxDamage = MAX_DAMAGE;
            upgradeCost = UPGRADE_COST;
            waterUsage = WATER_USAGE;
            attackRange = ATTACK_RANGE;
            description = INIT_DESCRIPTION;

            nextLevelHp = maxHp * 2;
            nextLevelMinDamage = minDamage * 2;
            nextLevelMaxDamage = maxDamage * 2;
            nextLevelRange = attackRange + 1;
            tile.gameBoard.gameResource.waterUsage += waterUsage;
        }

        override
        public Unit copy()
        {
            Unit tmpUnit = new Defender(this.tile, this.rng);
            tmpUnit.currentHp = this.currentHp;
            tmpUnit.minDamage = minDamage;
            tmpUnit.maxDamage = maxDamage;
            tmpUnit.waterUsage = waterUsage;
            tmpUnit.attackRange = attackRange;
            tmpUnit.description = description;
            tmpUnit.maxHp = maxHp;
            tmpUnit.attackRange = attackRange;

            tmpUnit.nextLevelHp = nextLevelHp;
            tmpUnit.nextLevelMinDamage = nextLevelMinDamage;
            tmpUnit.nextLevelMaxDamage = nextLevelMaxDamage;
            tmpUnit.nextLevelRange = nextLevelRange;
            tmpUnit.upgradeCost = upgradeCost;
            tile.gameBoard.gameResource.waterUsage -= waterUsage;
            return tmpUnit;
        }

        public override void upgrade()
        {
            base.upgrade();
            maxHp = nextLevelHp;
            currentHp = maxHp;
            minDamage = nextLevelMinDamage;
            maxDamage = nextLevelMaxDamage;
            attackRange = nextLevelRange;

            nextLevelHp = nextLevelHp * 2;
            nextLevelMinDamage = nextLevelMinDamage * 2;
            nextLevelMaxDamage = nextLevelMaxDamage * 2;
            nextLevelRange = attackRange + 1;
            upgradeCost = upgradeCost * 4;
        }
    }
}
