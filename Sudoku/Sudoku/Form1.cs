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
        { return (TextBox)table.GetControlFromPosition(row, col);
        }

        void InitTable()
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
                    // Creaza acest text box la pozitia indicata
                    table.Controls.Add(textBox, row, col);
                    textBox.Text = 0.ToString();
                }
            }
        }
        // This is like the contructor of Form
        private void Form1_Load(object sender, EventArgs e)
        {

            InitTable();
            Sudoku sudoku = new Sudoku();
            if (sudoku.main())  // TODO change the way this works
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        TextBox box = GetTextBoxAt(i, j);
                        box.Text = sudoku.board[i, j].value.ToString();
                    }
                }
            }


        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
