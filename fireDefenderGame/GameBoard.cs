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
                    board[i, j] = new Tile(i, j);

            //add 1 fire to the board
            board[0, 0].addFire(new SmallFire(0, 0));
        }
    }
}