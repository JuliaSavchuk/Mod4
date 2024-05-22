namespace Mod4
{
    internal class ComputerPlayer
    {
        private char symbol;
        private Random rand;

        public ComputerPlayer(char symbol)
        {
            this.symbol = symbol;
            rand = new Random();
        }

        public void MakeMove(Board board)
        {
            int row, col;
            do
            {
                row = rand.Next(3);
                col = rand.Next(3);
            } while (!board.PlaceSymbol(row, col, symbol));
            Console.WriteLine($"Computer places {symbol} at ({row}, {col})");
        }
    }
}
