using System;
using System.Collections;

namespace fireDefenderGame
{
    class GameBoard
    {
        public Tile[,] board { get; }
        public ArrayList fires;
        private int row;
        private int col;


        public GameBoard(int row, int col)
        {
            this.row = row;
            this.col = col;
            board = new Tile[row, col];
            fires = new ArrayList();
            init();
        }

        public void init()
        {
            Random random = new Random();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Tile newTile = new Tile(i, j);
                    int rand = random.Next(100);
                    if (rand < 50)
                        newTile.terrain = new Forest4(i, j, random);
                    else if (rand < 75)
                        newTile.terrain = new Forest3(i, j, random);
                    else if (rand < 90)
                        newTile.terrain = new Forest2(i, j, random);
                    else
                        newTile.terrain = new Forest1(i, j, random);

                    board[i, j] = newTile;
                }
            //add 1 fire to the board
          
            fires.Add(board[0, 0].fire = new SmallFire(board[0, 0], random));
            fires.Add(board[1, 0].fire = new MediumFire(board[1, 0], random));
            fires.Add(board[2, 0].fire = new LargeFire(board[2, 0], random));
        }
    }
}