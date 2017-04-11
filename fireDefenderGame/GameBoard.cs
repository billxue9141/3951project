using fireDefenderGame.buildings;
using System;
using System.Collections;

namespace fireDefenderGame
{
    /// <summary>
    /// a 2D matrix consists of Tiles.
    /// Also stores all the fires, units and buildings on the gameboard as arraylist.
    /// </summary>
    class GameBoard
    {
        public Tile[,] board { get; }
        public ArrayList fires { get; set; }
        public ArrayList units { get; set; }
        public ArrayList buildings { get; set; }
        public Building fireStation { get; set; }
        public Random random { get; set; }
        public GameResource gameResource;
        public FormMain main;
        private int row;
        private int col;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="row">number of rows on the gameboard</param>
        /// <param name="col">number of columns on the gameboard</param>
        /// <param name="main">the windows form that created this object</param>
        public GameBoard(int row, int col, FormMain main)
        {
            this.row = row;
            this.col = col;
            this.main = main;
            gameResource = new GameResource();
            board = new Tile[row, col];
            fires = new ArrayList();
            units = new ArrayList();
            buildings = new ArrayList();
            init();
        }

        /// <summary>
        /// initiate the game world with simple objects
        /// </summary>
        public void init()
        {
            random = new Random();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Tile newTile = new Tile(i, j, this);
                    int rand = random.Next(100);
                    if (rand < 50)
                        newTile.terrain = new Forest4(newTile, random);
                    else if (rand < 75)
                        newTile.terrain = new Forest3(newTile, random);
                    else if (rand < 90)
                        newTile.terrain = new Forest2(newTile, random);
                    else
                        newTile.terrain = new Forest1(newTile, random);

                    board[i, j] = newTile;
                }
            //add 3 fires to the board
            int randomCol = random.Next(col);
            fires.Add(board[0, randomCol].fire = new SmallFire(board[0, randomCol], random));
            randomCol = random.Next(col);
            fires.Add(board[1, randomCol].fire = new MediumFire(board[1, randomCol], random));
            randomCol = random.Next(col);
            fires.Add(board[2, randomCol].fire = new LargeFire(board[2, randomCol], random));

            //add 1 firestation and 1 defender
            randomCol = random.Next(col);
            fireStation = new FireStation(board[row - 1, randomCol], random);
            buildings.Add((board[row - 1, randomCol]).building = fireStation);
            Tile[] poweredTiles = board[row - 1, randomCol].findNeighbors(fireStation.radius);
            Tile poweredTile = poweredTiles[random.Next(poweredTiles.Length)];
            units.Add(poweredTile.unit = new Defender(poweredTile, random));
        }

        /// <summary>
        /// check if the location (x,y) is within the board.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Boolean isWithinBoard(int x, int y)
        {
            if (x >= 0 && x < FormMain.ROW && y >= 0 && y < FormMain.COL)
                return true;
            return false;
        }


    }
}