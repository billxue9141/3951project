﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Forest1 : Terrain
    {
        public static int MIN_HP = 0;
        public static int MAX_HP = 1000;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Tile/medievalTile_45.png";
        public static String IMAGE_HASWATER_DEBUG_LOCATION = "../../resources/Tile/forest_hasWater_01.png";

        public Forest1(Tile tile, Random rng) : base(tile, rng)
        {
            this.debugLocation = IMAGE_DEBUG_LOCATION;
            minHp = MIN_HP;
            maxHp = MAX_HP;
            currentHp = rng.Next(MAX_HP / 2) + MAX_HP / 2;
        }

        public override void transform()
        {
            Forest0 tmp = new Forest0(tile, rng);
            tile.terrain = tmp;
        }

        public override void setHasWater()
        {
            hasWater = true;
            debugLocation = IMAGE_HASWATER_DEBUG_LOCATION;
            tile.gameBoard.main.updateTile(tile.row, tile.col);
        }
    }
}
