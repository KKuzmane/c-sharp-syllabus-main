using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
        }

        private static void InitBoard()
        {
            string player1 = "X";
            string player2 = "O";
            int counter = 0;
            string activePlayer = player1;
            var r = 0;
            var c = 0;
            bool victory = false;

            for (r = 0; r < 3; r++)
            {
                for (c = 0; c < 3; c++)
                {
                    board[r, c] = ' ';
                }
            }
            while (victory == true || counter < 9)
            {
                Console.WriteLine(activePlayer + " turn. Insert row number and then column number to locate your move.");
                Console.WriteLine("Insert row number (0 to 2) ");
                r = int.Parse(Console.ReadLine());
                while(r < 0 || r > 2)
                {
                    Console.WriteLine("Invalid number! Try again");
                    r = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Insert column number (0 to 2) ");
                c = int.Parse(Console.ReadLine());
                while (c < 0 || c > 2)
                {
                    Console.WriteLine("Invalid number! Try again");
                    c = int.Parse(Console.ReadLine());
                }
                while(board[r, c] == 'X' || board[r, c] == 'O')
                {
                    Console.WriteLine("This space is taken! Try again");
                    Console.WriteLine("Insert row number (0 to 2) ");
                    r = int.Parse(Console.ReadLine());
                    while (r < 0 || r > 2)
                    {
                        Console.WriteLine("Invalid number! Try again");
                        r = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Insert column number (0 to 2) ");
                    c = int.Parse(Console.ReadLine());
                    while (c < 0 || c > 2)
                    {
                        Console.WriteLine("Invalid number! Try again");
                        c = int.Parse(Console.ReadLine());
                    }
                }
                
                if (activePlayer == player1)
                {
                    board[r, c] = 'X';
                }
                else
                {
                    board[r, c] = 'O';
                }
                DisplayBoard();
                //Victory conditions
                if ((board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2] && board[0, 0] != ' ') ||
                (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2] && board[1, 0] != ' ') ||
                (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2] && board[2, 0] != ' ') ||
                (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0] && board[0, 0] != ' ') ||
                (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1] && board[0, 1] != ' ') ||
                (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2] && board[0, 2] != ' ') ||
                (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0] != ' ') ||
                (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[0, 2] != ' '))
                {
                    victory = true;
                }
                else if (counter == 8)
                {
                    Console.WriteLine("It's a draw!");
                    break;
                }
                else
                {
                    if (activePlayer == player1)
                    {
                        activePlayer = player2;
                    }
                    else
                    {
                        activePlayer = player1;
                    }
                    counter++;
                }
                if(victory == true)
                {
                    Console.WriteLine(activePlayer + " has won!");
                    break;
                }
            }
            Console.ReadKey();
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
