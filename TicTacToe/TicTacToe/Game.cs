using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game:Rules
    {
        static void Main(string[] args)
        {
            string[,] board = new string[3, 3];
            Console.WriteLine("Can you beat the computer in Tic Tac Toe?");
            //Picking X or O
            bool checkAnswer = false;
            string human = null;
            string cpu = null;
            int turn = 0;
            while (!checkAnswer)
            {
                Console.WriteLine("X or O? X goes first.");
                string input = Console.ReadLine().ToLower();
                if (input=="x")
                {
                    human = "X";
                    cpu = "O";
                    checkAnswer = true;
                }
                if (input=="o")
                {
                    human = "O";
                    cpu = "X";
                    turn = 1;
                    checkAnswer = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid seletion.");
                }

            }

            //Starting Game
            Console.WriteLine("These are the cells to choose from:");
            Console.WriteLine();
            PrintCell();
            Startgame(board);
            while(true)
            {
                Print(board);

                //Picking a cell
                bool validAnswer = false;
                int pickedCell = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Enter the cell you want to play: ");
                    validAnswer = int.TryParse(Console.ReadLine(), out pickedCell);
                    if (!validAnswer) Console.WriteLine("Please enter a valid integer.");
                    if (pickedCell < 1 || pickedCell > 9)
                    {
                        validAnswer = false;
                        Console.WriteLine("Please enter an integer from 1-9.");
                    }
                }

                var selected = SelCell(pickedCell);

                string currentPlayer;

                if (turn%2==0)
                {
                    currentPlayer = human;
                }
                else
                {
                    currentPlayer = cpu;
                }

                board[selected.row, selected.col] = currentPlayer;
                turn++;

            }
            


        }
    }
}
