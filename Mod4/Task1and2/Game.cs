namespace Mod4
{
    internal class Game
    {
        private Board board;
        private Player player;
        private ComputerPlayer computer;
        private bool isPlayerTurn;

        public Game()
        {
            board = new Board();
            player = new Player('X');
            computer = new ComputerPlayer('O');
            Random rand = new Random();
            isPlayerTurn = rand.Next(2) == 0;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            board.Display();

            while (!board.IsFull() && !board.HasWinner())
            {
                if (isPlayerTurn)
                {
                    player.MakeMove(board);
                }
                else
                {
                    computer.MakeMove(board);
                }

                isPlayerTurn = !isPlayerTurn;
                board.Display();
            }

            if (board.HasWinner())
            {
                Console.WriteLine(isPlayerTurn ? "Computer wins!" : "Player wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }

}
