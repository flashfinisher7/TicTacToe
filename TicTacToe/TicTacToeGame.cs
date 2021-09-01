using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{

    class TicTacToeGame
    {
        public char[] board { get; set; }
        public char player = ' ';
        public char computer = ' ';
        
        public void InitializeBoard()
        {
            board = new char[10];

            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }
        
        public char ChooseOption()
        {
            Console.Write("Choose X or O : ");
            var input = Convert.ToChar(Console.ReadLine());

            return (input == 'X' || input == 'O') ? input : ChooseOption();
        }
        
        public void ShowBoard()
        {
            Console.WriteLine("" + board[1] + "\t|" + board[2] + "\t|" + board[3]);
            Console.WriteLine("--------------------------");
            Console.WriteLine("" + board[4] + "\t|" + board[5] + "\t|" + board[6]);
            Console.WriteLine("--------------------------");
            Console.WriteLine("" + board[7] + "\t|" + board[8] + "\t|" + board[9]);


        }

    }
}