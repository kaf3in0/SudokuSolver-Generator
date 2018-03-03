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
    public partial class GenerateSolvedForm: Form
    {
        public GenerateSolvedForm()
        {
            InitializeComponent();
        }

        private TextBox GetTextBoxAt(int row, int col)
            // This is just how this retarded function works  COL then ROW
        { return (TextBox)table.GetControlFromPosition(col, row); 
        }

        void CreateTextBoxes()
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

        void PrintPuzzle(Sudoku sudoku)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox box = GetTextBoxAt(i, j);
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
        void PrintAndSolvePuzzle()
        {
            Sudoku sudoku = new Sudoku(); // We need the logic from this class
            sudoku.GeneratePuzzle();
            if(sudoku.Solve(0, 0))
            {
                PrintPuzzle(sudoku);
            }
        }

        // From main
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTextBoxes();
            PrintAndSolvePuzzle();
        }


        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            this.Hide();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Sudoku sudoku = new Sudoku();
            sudoku.GeneratePuzzle();
            if(sudoku.Solve(0,0))
            {
                PrintPuzzle(sudoku);
            }

        }
    }
}
