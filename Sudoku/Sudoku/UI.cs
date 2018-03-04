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
                        box.ReadOnly = true;
                    }
                    else
                    {
                        box.ForeColor = Color.Black;
                        box.ReadOnly = false;
                    }
                    if (sudoku.board[i, j].value != 0)
                        box.Text = sudoku.board[i, j].value.ToString();
                    else box.Text = " "; // Print an empty space instead of 0

                    // We set the textBox to a click event, so we can select everything inside it on click
                    // The syntax is a bit wierd becaus we also have to pass in box as a parameter, that is how you do it
                    box.Click += delegate (object sender, EventArgs e) { TextBox_Click(sender, e, box); };
                    //this.BackButton.Click += new System.EventHandler(this.BackButton_Click);  ///example without param
                }
            }
        }


        //Selects everything in TextBox you click on
        private void TextBox_Click(object sender, System.EventArgs e, TextBox box)
        {
            box.SelectAll();
            /*or:
             * box.SelectionStart = 0;
             * box.SelectionLength = box.Text.Length;
             */
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
                        box.ReadOnly = true;

                    }
                    else
                    {
                        box.Text = " "; // Print an empty space instead of 0
                        box.ForeColor = Color.Black;
                        box.ReadOnly = false;
                    }

                    // We set the textBox to a click event, so we can select everything inside it on click
                    // The syntax is a bit wierd becaus we also have to pass in box as a parameter, that is how you do it
                    box.Click += delegate (object sender, EventArgs e) { TextBox_Click(sender, e, box); };
                    //this.BackButton.Click += new System.EventHandler(this.BackButton_Click);  ///example without param
                }

            }
        }
    }
}
