using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class Tile
    {
        public int row { get; set; }
        public int col { get; set; }
        public GameBoard gameBoard { get; }
        public Fire fire { get; set; }
        public Terrain terrain { get; set; }
        public bool isSelected;

        public Tile(int row, int col, GameBoard gameBoard)
        {
            this.row = row;
            this.col = col;
            this.gameBoard = gameBoard;
            this.isSelected = false;
        }

        public void update()
        {
            if (fire != null)
                if (fire.currentHp <= 0)
                {
                    fire = null;
                    gameBoard.main.updateTile(row, col);
                }
                else
                    fire.update();
            terrain.update();
        }
    }
}
