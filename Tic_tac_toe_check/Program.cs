using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board =
            {
                {"X", "O", "O" },
                {"O", "O", "X" },
                {"O", "X", "X" }
            };
            if(TicTacToe.Checker(board) == false)
            {
                Console.WriteLine("It is a draw!");
            }
            Console.ReadKey();
        }

    }
    public class TicTacToe
    {
        public static bool Checker(string[,] board)
        {
            int bint = 0;
            int mint = 0;
            bool mool = false;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == "O")
                    {
                        bint++;
                        if (bint == 3)
                        {
                            Console.WriteLine("Player O wins!!");
                            mool = true;
                            return true;
                        }
                    }
                    else if (board[i, j] == "X")
                    {
                        mint++;
                        if (mint == 3)
                        {
                            Console.WriteLine("Player X wins!!");
                            mool = true;
                            return true;
                        }
                    }
                }
                if(mool == true)
                {
                    break;
                }
                bint = 0;
                mint = 0;
            }
            bint = 0;
            mint = 0;
            if (mool == false)
            {
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    for (int j = 0; j < board.GetLength(0); j++)
                    {
                        if (board[j, i] == "O")
                        {
                            bint++;
                            if (bint == 3)
                            {
                                Console.WriteLine("Player O wins!!");
                                mool = true;
                                return true;
                            }
                        }
                        else if (board[j, i] == "X")
                        {
                            mint++;
                            if (mint == 3)
                            {
                                Console.WriteLine("Player X wins!!");
                                mool = true;
                                return true;
                            }
                        }
                    }
                    bint = 0;
                    mint = 0;
                }
            }
            if (mool == false)
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    if (board[i, i] == "O")
                    {
                        bint++;
                        if (bint == 3)
                        {
                            Console.WriteLine("Player O wins!!");
                            mool = true;
                            return true;
                        }
                    }
                    else if (board[i, i] == "X")
                    {
                        mint++;
                        if (mint == 3)
                        {
                            Console.WriteLine("Player X wins!!");
                            mool = true;
                            return true;
                        }
                    }
                }
            }
            bint = 0;
            mint = 0;
            if (mool == false)
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = board.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (i + j == board.GetLength(1) - 1)
                        {
                            if (board[i, j] == "O")
                            {
                                bint++;
                                if (bint == 3)
                                {
                                    Console.WriteLine("Player O wins!!");
                                    mool = true;
                                    return true;
                                }
                            }
                            else if (board[i, j] == "X")
                            {
                                mint++;
                                if (mint == 3)
                                {
                                    Console.WriteLine("Player X wins!!");
                                    mool = true;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
            }
        }
    }

