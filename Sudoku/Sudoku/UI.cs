using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    class UI
    {
        
        public TextBox GetTextBoxAt(int row, int col, TableLayoutPanel table)
        // This is just how this retarded function works  COL then ROW
        {
            return (TextBox)table.GetControlFromPosition(col, row);
        }


        public void CreateTextBoxes(TableLayoutPanel table)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // Create the textBox formatting
                    TextBox textBox = new TextBox
                    {
                        TextAlign = HorizontalAlignment.Center,
                        Font = new Font("Arial", 20f, FontStyle.Bold),
                        Dock = DockStyle.Fill,
                        MaxLength = 1,
                        BackColor = Color.White
                    };

                    // Creates the textbox as a controller at the indicated position
                    table.Controls.Add(textBox, row, col);
                    textBox.Text = 0.ToString(); // Default value
                }
            }
        }


        public void PrintSolvedPuzzle(Sudoku sudoku, TableLayoutPanel table)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox box = GetTextBoxAt(i, j, table);
                    if (sudoku.board[i, j].isFixed)
                    {
                        box.ForeColor = Color.MediumVioletRed;
                    }
                    else box.ForeColor = Color.Black;
                    if (sudoku.board[i, j].value != 0)
                        box.Text = sudoku.board[i, j].value.ToString();
                    else box.Text = " "; // Print an empty space instead of 0
                }
            }
        }


        public void PrintNotSolvedPuzzle(Sudoku sudoku, TableLayoutPanel table)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox box = GetTextBoxAt(i, j, table);
                    if (sudoku.board[i, j].isFixed)
                    {
                        box.ForeColor = Color.MediumVioletRed;
                        box.Text = sudoku.board[i, j].value.ToString();
                    }
                    else box.Text = " "; // Print an empty space instead of 0
                }
            }
        }
    }
}
