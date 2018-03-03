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
        public PlayGameForm()
        {
            InitializeComponent();
        }

        private void PlayGameForm_Load(object sender, EventArgs e)
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
                check button ? 
             */

            // TODO add score system



        }
        private void table_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
