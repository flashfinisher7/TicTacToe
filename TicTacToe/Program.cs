using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t This Is A TicTacToe Game Problem");
            //UC1
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.InitializeBoard();
            //UC2
            ticTacToeGame.ChooseOption();
            //UC3
            ticTacToeGame.ShowBoard();

        }
    }
}
