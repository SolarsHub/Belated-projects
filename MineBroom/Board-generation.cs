using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineBroom
{
    public class Grid
    {
        private Cell[,] _gameGrid;
        private int _gridWidth;
        private int _gridHeight;


        public int GridWidth { get { return _gridWidth; } }
        public int GridHeight { get { return _gridHeight; } }
        public Cell[,] GameGrid { get { return _gameGrid; } }

        public Grid(int gridWidth, int gridHeight)
        {
            _gridWidth = gridWidth;
            _gridHeight = gridHeight;
            _gameGrid = new Cell[_gridWidth, _gridHeight];
            GenerateBoard();
        }

        private void GenerateBoard()
        {
            for (int i = 0; i < _gridWidth; i++)
            {
                for (int g = 0; g < _gridHeight; g++)
                {
                    _gameGrid[i, g] = new Cell();
                }
            }
        }

        public int BombCreator(int maxBombs)
        {
            int b = 0;
            Random rnd = new Random();

            while (b <= maxBombs)
            {
                int col = rnd.Next(0, 9);
                int row = rnd.Next(0, 9);

                if (!_gameGrid[col, row].isBomb)
                {
                    _gameGrid[col, row].isBomb = true;
                    b++;
                }
            }
            return b;
        }

        public string BombChecker(int col, int row)
        {
            int counter = 0;

            if (col - 1 >= 0 && _gameGrid[(col - 1), row].isBomb == true)
                counter++;

            if (col + 1 < _gridWidth && _gameGrid[(col + 1), row].isBomb == true)
                counter++;

            if (row - 1 >= 0 && _gameGrid[col, (row - 1)].isBomb == true)
                counter++;

            if (row + 1 < _gridHeight && _gameGrid[col, (row + 1)].isBomb == true)
                counter++;

            if (col - 1 > 0 && row - 1 >= 0 && _gameGrid[(col - 1), (row - 1)].isBomb == true)
                counter++;

            if (col + 1 < _gridWidth && row - 1 >= 0 && _gameGrid[(col + 1), (row - 1)].isBomb == true)
                counter++;

            if (col + 1 < _gridWidth && row + 1 < _gridHeight && _gameGrid[(col + 1), (row + 1)].isBomb == true)
                counter++;

            if (col - 1 > 0 && row + 1 < _gridHeight && _gameGrid[(col - 1), (row + 1)].isBomb == true)
                counter++;

            return $"There are {counter} bomb(s) nearby";
        }
    }
}
