namespace Mod4
{
    public class Board
    {
        private char[,] grid;
        private int size = 3;

        public Board()
        {
            grid = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = ' ';
                }
            }
        }

        public bool PlaceSymbol(int row, int col, char symbol)
        {
            if (row >= 0 && row < size && col >= 0 && col < size && grid[row, col] == ' ')
            {
                grid[row, col] = symbol;
                return true;
            }
            return false;
        }

        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(grid[i, j]);
                    if (j < size - 1) Console.Write("|");
                }
                Console.WriteLine();
                if (i < size - 1) Console.WriteLine("-----");
            }
        }

        public bool IsFull()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (grid[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool HasWinner()
        {
            for (int i = 0; i < size; i++)
            {
                if (grid[i, 0] != ' ' && grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2])
                {
                    return true;
                }
                if (grid[0, i] != ' ' && grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i])
                {
                    return true;
                }
            }
            if (grid[0, 0] != ' ' && grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2])
            {
                return true;
            }
            if (grid[0, 2] != ' ' && grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0])
            {
                return true;
            }
            return false;
        }
    }
}
