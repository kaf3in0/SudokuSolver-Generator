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
    public partial class Form1 : Form
    {
        public Form1()
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

        void PrintAndSolvePuzzle()
        {
            Sudoku sudoku = new Sudoku(); // We need the logic from this class
            if (sudoku.main())  // TODO change the way this works
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
                        box.Text = sudoku.board[i, j].value.ToString();
                    }
                }
            }
        }
        void UI()
        {
            // TODO Add another form with main menu where you can choose wether 
            // you generate/solve your own input/play sudoku

        }
        // This is like the main function
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTextBoxes();
            PrintAndSolvePuzzle();
            UI();

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; 
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
