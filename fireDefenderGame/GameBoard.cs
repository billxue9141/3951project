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
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Tile newTile = new Tile(i, j);
                    newTile.terrain = new Forest(i, j);
                    board[i, j] = newTile;
                }
            //add 1 fire to the board
            board[0, 0].fire = new SmallFire(0, 0);
        }
    }
}