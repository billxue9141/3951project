
using fireDefenderGame.buildings;
using System;
using System.Collections;

namespace fireDefenderGame
{
    /// <summary>
    /// Each Tile represents one grid on the map. 
    /// Tiles have knowledge of the objects on the same grid location.
    /// Each Tile can only have 1 type of Fire, Unit and Building.
    /// </summary>
    class Tile
    {
        public int row { get; set; }
        public int col { get; set; }
        public GameBoard gameBoard { get; }
        public Fire fire { get; set; }
        public Unit unit { get; set; }
        public Building building { get; set; }
        public Terrain terrain { get; set; }
        public bool isSelected;

        public Tile(int row, int col, GameBoard gameBoard)
        {
            this.row = row;
            this.col = col;
            this.gameBoard = gameBoard;
            this.isSelected = false;
        }

        /// <summary>
        /// update all the game objects in this tile
        /// </summary>
        public void update()
        {
            if (unit != null)
                if (unit.currentHp <= 0)
                {
                    gameBoard.gameResource.waterUsage -= unit.waterUsage;
                    unit = null;
                }
                else
                    unit.update();

            if (fire != null)
                if (fire.currentHp <= 0)
                {
                    fire = null;
                    gameBoard.main.updateTile(row, col);
                }
                else
                    fire.update();
            if (building != null)
                if (building.currentHp <= 0)
                {
                    building = null;
                    gameBoard.main.updateTile(row, col);
                }
                else
                    building.update();
            terrain.update();
        }

        /// <summary>
        /// count the number of neighbor tiles within the radius
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public int countNeighbors(int radius)
        {
            int count = 0;
            for (int i = row - radius; i <= row + radius; i++)
            {
                for (int j = col - radius; j <= col + radius; j++)
                {
                    if (gameBoard.isWithinBoard(i, j))
                        count++;
                }
            }

            // -1 count to exclude this tile
            return count - 1;
        }

        /// <summary>
        /// return an array of all the neighbor cells within the radius
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public Tile[] findNeighbors(int radius)
        {
            Tile[] neighbors = new Tile[countNeighbors(radius)];
            int count = 0;
            for (int i = row - radius; i <= row + radius; i++)
                for (int j = col - radius; j <= col + radius; j++)
                    if (!(i == row && j == col) && gameBoard.isWithinBoard(i, j))
                        neighbors[count++] = (gameBoard.board[i, j]);

            return neighbors;
        }

        /// <summary>
        ///  find the number of neighbor tiles with fire
        /// </summary>
        /// <returns></returns>
        public int countNeighborsWithFire(int radius)
        {
            int count = 0;
            if (radius == 0)
                return 0;
            Tile[] allNeighbors = findNeighbors(radius);
            foreach (Tile tile in allNeighbors)          
                if (tile.fire != null)
                    count++;
            return count;
        }

        /// <summary>
        /// return an array of neighbor tiles with fire
        /// </summary>
        /// <returns></returns>
        public Tile[] findNeighborsWithFire(int radius)
        {
            int numNeighborsWithFire = countNeighborsWithFire(radius);
            if (numNeighborsWithFire == 0)
                return null;
            Tile[] allNeighbors = findNeighbors(radius);
            Tile[] neighborsWithFire = new Tile[numNeighborsWithFire];
            int count = 0;
            foreach (Tile tile in allNeighbors)
                if (tile.fire != null)
                    neighborsWithFire[count++] = tile;

            return neighborsWithFire;
        }


        /// <summary>
        ///  find the number of neighbor tiles without fire
        /// </summary>
        /// <returns></returns>
        public int countNeighborsWithoutFire(int radius)
        {
            int count = 0;
            if (radius == 0)
                return 0;
            Tile[] allNeighbors = findNeighbors(radius);
            foreach (Tile tile in allNeighbors)
                if (tile.fire == null && tile.terrain.currentHp > 0)
                    count++;

            return count;
        }

        /// <summary>
        /// return an array of neighbor tiles without fire
        /// </summary>
        /// <returns></returns>
        public Tile[] findNeighborsWithoutFire(int radius)
        {
            int numNeighborsWithoutFire = countNeighborsWithoutFire(radius);
            if (numNeighborsWithoutFire == 0)
                return null;
            Tile[] allNeighbors = findNeighbors(radius);
            Tile[] neighborsWithoutFire = new Tile[numNeighborsWithoutFire];
            int count = 0;
            foreach (Tile tile in allNeighbors)
                if (tile.fire == null && tile.terrain.currentHp > 0)
                    neighborsWithoutFire[count++] = tile;

            return neighborsWithoutFire;
        }
    }
}
