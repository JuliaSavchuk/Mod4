namespace Mod4
{
    public class Player
    {
        private char symbol;

        public Player(char symbol)
        {
            this.symbol = symbol;
        }

        public void MakeMove(Board board)
        {
            int row, col;
            do
            {
                Console.WriteLine("Enter your move (row and column): ");
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());
            } while (!board.PlaceSymbol(row, col, symbol));
        }
    }
}
