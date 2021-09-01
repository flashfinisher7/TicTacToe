using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public void InitializeBoard()
        {
            char[] board = new char[10];

            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }

    }
}
