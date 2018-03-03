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
        UI ui = new UI();
        public GenerateSolvedForm()
        {
            InitializeComponent();
        }

        private void PrintAndSolve()
        {
            Sudoku sudoku = new Sudoku(); // We need the logic from this class
            sudoku.GeneratePuzzle();       //Generate a random puzzle
            if (sudoku.Solve(0, 0))
            {
                ui.PrintSolvedPuzzle(sudoku, table);
            }
        }
        // From main
        private void Form1_Load(object sender, EventArgs e)
        {
            // We init every [i,j] with a text box so we can output stuff
            ui.CreateTextBoxes(table);
            PrintAndSolve();
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
            PrintAndSolve(); // To create a new solved puzzle we just recall this function
        }
    }
}
