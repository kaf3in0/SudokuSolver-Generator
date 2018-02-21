using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    struct Number
    {
        public bool isFixed;
        public int value;
    };

    class Sudoku
    {
        public Number[,] board = new Number[9, 9];


        /*
        private void PrintConsole()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j]);
                    if (j % 3 == 2)
                        Console.Write("\n");
                }
                if (i % 3 == 2)
                    Console.Write("\n");
            }
        }*/

        bool IsSolution(int row, int col) { return row < 9 && col < 9; }
        bool IsValid(int row, int col, int value)
        {
            int newRow = row - row % 3;
            int newCol = col - col % 3;

            for (int i = 0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    if (board[i + newRow, j + newCol].value == value)
                        return false;
                }
            }

            for(int i = 0; i<9; i++)
            {
                if (board[i, col].value == value || board[row, i].value == value)
                    return false;
            }
            return true;
        }

        bool Solve(int row, int col)
        {
            if (IsSolution(row, col))
            {

                if (board[row,col].isFixed)
                    {
                        if ((col + 1) < 9) return Solve(row, col + 1);
                        else if ((row + 1) < 9) return Solve(row + 1, 0);
                        else return true; // The board is full => solution
                    }
                else if (!board[row,col].isFixed)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            if (IsValid(row, col, i))
                            {
                                board[row,col].value = i;
                                if ((col + 1) < 9)
                                {
                                    if (Solve(row, col + 1))
                                        return true;
                                    else
                                        board[row,col].value = 0;
                                }
                                else if ((row + 1) < 9)
                                {
                                    if (Solve(row + 1, 0))
                                        return true;
                                    else
                                        board[row,col].value = 0;
                                }

                                else return true;
                            }
                        }

                    }

                return false;
            }
            else return true;
        }

        void GeneratePuzzle()
        {
            Random random = new Random();
            int fixedRemaining = 17;
            while(fixedRemaining > 0)
            {
                int row = random.Next(0, 8);
                int col = random.Next(0, 8);
                int value = random.Next(1, 9);

                if(board[row, col].value == 0 &&
                    IsValid(row, col, value))
                {
                    board[row, col].value = value;
                    board[row, col].isFixed = true;
                }
                else
                {
                    continue;
                }

                fixedRemaining--;
            }
        }


        private void InitBoard()
        {
            for(int i = 0; i<9; i++)
            {
                for (int j = 0; j < 9; j++)
                    board[i, j].value = 0;
            }
        }
        public bool main()
        {
            InitBoard();
            GeneratePuzzle();
            if(Solve(0,0))
            {
                return true;
            }

            return false;
        }

    }
}
