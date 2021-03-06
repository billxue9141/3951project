﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class SmallFire : Fire
    {
        static int MIN_HP = 0;
        static int MAX_HP = 200;
        static int MY_SPREAD_RADIUS = 0;
        static int MY_SPREAD_CHANCE = 0;
        static int MIN_DAMAGE = 1;
        static int MAX_DAMAGE = 3;
        public static String IMAGE_DEBUG_LOCATION = "../../resources/Environment/fire1.png";

        public SmallFire(Tile tile, Random rng) : base(ref tile, rng)
        {
            currentHp = MIN_HP + 1;
            minHp = MIN_HP;
            maxHp = MAX_HP;
            minDamage = MIN_DAMAGE;
            maxDamage = MAX_DAMAGE;
            spreadChance = MY_SPREAD_CHANCE;
            spreadRadius = MY_SPREAD_RADIUS;
            this.debugLocation = IMAGE_DEBUG_LOCATION;
        }

        public override void transform()
        {
            if (currentHp >= maxHp)
            {
                MediumFire tmp = new MediumFire(tile, rng);
                tile.fire = tmp;
            }
            else if (currentHp <= minHp)
            {
                //to-do: maybe a sound effect when a fire has been put out?
            }
            tile.gameBoard.main.updateTile(tile.row, tile.col);
        }
    }
}
