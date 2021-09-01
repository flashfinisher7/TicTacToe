using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{

    class TicTacToeGame
    {

        public char player;
        public char computer;
        //UC1
        public void InitializeBoard()
        {
            char[] board = new char[10];

            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }
        //UC2
        public void ChooseOption()
        {
            Console.Write("Choose X or O : ");
            
            char input = Convert.ToChar(Console.ReadLine());
            //if player selects X
            if (input == 'X')
            {
                player = 'X';
                computer = 'O';
            }
            //if player selects O
            else if (input == 'O')
            {
                computer = 'O';
                player = 'X';
            }
            else
            {
                Console.WriteLine("Invalid player input");
            }
        }
        //UC3
        public void ShowBoard()
        {
            Console.WriteLine(" "+ "\t|" + "\t|");
            Console.WriteLine("--------------------------");
            Console.WriteLine(" "+ "\t|" +"\t|" );
            Console.WriteLine("--------------------------");
            Console.WriteLine(" "+ "\t|" +"\t|" );


        }
    }

}

