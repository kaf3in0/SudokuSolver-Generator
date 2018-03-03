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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GenerateSolvedButton_Click(object sender, EventArgs e)
        {
            GenerateSolvedForm form = new GenerateSolvedForm();
            form.Show();
            this.Hide();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayGameForm form = new PlayGameForm();
            form.Show();
            this.Hide();
        }
    }
}
