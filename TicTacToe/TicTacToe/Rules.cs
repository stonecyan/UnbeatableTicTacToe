using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Rules
    {
        //Print empty board
        public static void Startgame(string[,] board)
        {
            for(int row=0; row<3; row++)
            {
                for(int col=0;col<3;col++)
                {
                    board[row, col] = " ";
                }
            }
        }

        //Print current board
        public static void Print(string[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (col == 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(board[row, col]);
                    if (col == 0 || col == 1)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
                if (row == 0 || row == 1)
                    Console.WriteLine("-----------");
            }
            Console.ReadLine();
        }

        //Print example board
        public static void PrintCell()
        {
            int c = 1;
            string [,] cellboard = new string[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    string d = Convert.ToString(c);
                    cellboard[row, col] = d;
                    c++;
                }
            }

            Print(cellboard);
        }

        //Convert picked cell into row,col combination for board
        public static (int row, int col) SelCell(int pickedCell)
        {
            int row=0;
            int col=0;

            if (pickedCell==1)
            {
                row = 0;
                col = 0;
            }
            if (pickedCell == 2)
            {
                row = 0;
                col = 1;
            }
            if (pickedCell == 3)
            {
                row = 0;
                col = 2;
            }
            if (pickedCell == 4)
            {
                row = 1;
                col = 0;
            }
            if (pickedCell == 5)
            {
                row = 1;
                col = 1;
            }
            if (pickedCell == 6)
            {
                row = 1;
                col = 2;
            }
            if (pickedCell == 7)
            {
                row = 2;
                col = 0;
            }
            if (pickedCell == 8)
            {
                row = 2;
                col = 1;
            }
            if (pickedCell == 9)
            {
                row = 2;
                col = 2;
            }

            return (row, col);
        }

        public static CheckWin(string[,] board)
        {
            bool win;
            if (board[0,0]==board[0,1] && board[0,1]==board[0,2])
            {
                win = true;
            }
            if (board[1,0]==board[1, 1] && board[1, 1] == board[1, 2])
            {
                win = true;
            }
            if (board[2, 0] == board[2, 1] && board[2,1] == board[2, 2])
            {
                win = true;
            }
            if (board[0, 0] == board[1, 0] && board[0, 1] == board[2, 0])
            {
                win = true;
            }
            if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 0])
            {
                win = true;
            }
            if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2])
            {
                win = true;
            }

        }
        
    }
}
