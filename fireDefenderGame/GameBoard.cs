using System;

namespace fireDefenderGame
{
    class GameBoard
    {
        public Tile[,] board { get; }
        private int row;
        private int col;


        public GameBoard(int row, int col)
        {
            this.row = row;
            this.col = col;
            board = new Tile[row, col];
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
                        newTile.terrain = new Forest4(i, j);
                    else if (rand < 75)
                        newTile.terrain = new Forest3(i, j);
                    else if (rand < 90)
                        newTile.terrain = new Forest2(i, j);
                    else
                        newTile.terrain = new Forest1(i, j);

                    board[i, j] = newTile;
                }
            //add 1 fire to the board
            board[0, 0].fire = new SmallFire(0, 0);
            board[0, 1].fire = new MediumFire(0, 1);
            board[0, 2].fire = new LargeFire(0, 2);
        }
    }
}