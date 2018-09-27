using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Forest0 : Terrain
    {
        public static int MIN_HP = 0;
        public static int MAX_HP = 0;
        public static String IMAGE_DEBUG_LOCATION_0 = "../../resources/Tile/medievalTile_49.png";
        public static String IMAGE_DEBUG_LOCATION_1 = "../../resources/Tile/medievalTile_50.png";
        public static String IMAGE_DEBUG_LOCATION_2 = "../../resources/Tile/medievalTile_51.png";
        public static String IMAGE_HASWATER_DEBUG_LOCATION = "../../resources/Tile/forest_hasWater_00.png";

        public Forest0(Tile tile, Random rng) : base(tile, rng)
        {
            int imageNum = rng.Next(3);
            if (imageNum == 0)
                this.debugLocation = IMAGE_DEBUG_LOCATION_0;
            else if (imageNum == 1)
                this.debugLocation = IMAGE_DEBUG_LOCATION_1;
            else 
                this.debugLocation = IMAGE_DEBUG_LOCATION_2;

            minHp = MIN_HP;
            maxHp = MAX_HP;
        }

        public override void transform()
        {
            currentHp = 0;
        }

        public override void setHasWater()
        {
            hasWater = true;
            debugLocation = IMAGE_HASWATER_DEBUG_LOCATION;
            tile.gameBoard.main.updateTile(tile.row, tile.col);
        }

    }
}
