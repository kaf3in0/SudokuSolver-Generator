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
    public partial class PlayGameForm : Form
    {
        private Sudoku sudoku = new Sudoku();
        public static string[,] userBoard = new string[9, 9];
        UI ui = new UI();


        public PlayGameForm()
        {
            InitializeComponent();
        }

        
        private void PlayGameForm_Loadddddd(object sender, EventArgs e)
        {
            // TODO this class should contain 2 boards, 1 fully solved and 1 that only 
                    //  shows the fixed values, for the user

            // We will compare the twos to see if it's right or not
            /*
             * TODO add difficulty levels
                Easy - every user error is highlighted;
                     every good placement is highlighted
                Normal - only highlight for good placements
                Hard - no highlights

                OR 
                check if right button ? 
             */

            // TODO add score system
            // TODO add different type of puzzles, ex:fixed number >17
        }
        private void table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FindWhatChanged()
        {

        }
        
        private void InitUserBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox box = ui.GetTextBoxAt(i, j, table);
                    userBoard[i, j] = box.Text;
                }
            }
        }
        private void Game()
        {   
            sudoku.GeneratePuzzle();
            sudoku.Solve(0, 0);
            ui.PrintNotSolvedPuzzle(sudoku, table);
            InitUserBoard();
                /* 
                 * TODO: When the user changes smth compare the 2 boards 
                 *      do stuff after
                 * When do we stop ? - Never, or when New/Back button is clicked
                 * 
                 */
        }

        // Form main
        private void PlayGameForm_Load(object sender, EventArgs e)
        {
            ui.CreateTextBoxes(table);
            Game();        
        }
    }
}
