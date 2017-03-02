using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireDefenderGame
{
    class GameBoard
    {
        private Tile[ , ] board;
        private int row;
        private int column;

        public GameBoard(int row, int col)
        {
            this.row = row;
            this.column = col;
            board = new Tile[row,col];

        }
    }
}
