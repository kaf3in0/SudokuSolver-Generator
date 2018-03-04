namespace Sudoku
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.PlayButton = new System.Windows.Forms.Button();
            this.GenerateSolvedButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(123, 34);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(168, 58);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseCompatibleTextRendering = true;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // GenerateSolvedButton
            // 
            this.GenerateSolvedButton.Location = new System.Drawing.Point(123, 98);
            this.GenerateSolvedButton.Name = "GenerateSolvedButton";
            this.GenerateSolvedButton.Size = new System.Drawing.Size(168, 58);
            this.GenerateSolvedButton.TabIndex = 0;
            this.GenerateSolvedButton.Text = "Generate Solved";
            this.GenerateSolvedButton.UseCompatibleTextRendering = true;
            this.GenerateSolvedButton.UseVisualStyleBackColor = true;
            this.GenerateSolvedButton.Click += new System.EventHandler(this.GenerateSolvedButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 58);
            this.button2.TabIndex = 0;
            this.button2.Text = "Solve My Sudoku";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GenerateSolvedButton);
            this.Controls.Add(this.PlayButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button GenerateSolvedButton;
        private System.Windows.Forms.Button button2;
    }
}