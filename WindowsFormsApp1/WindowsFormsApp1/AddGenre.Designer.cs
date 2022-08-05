
namespace WindowsFormsApp1
{
    partial class AddGenre
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
            this.Genrelabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.AddGanre = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Genrelabel
            // 
            this.Genrelabel.AutoSize = true;
            this.Genrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Genrelabel.Location = new System.Drawing.Point(28, 9);
            this.Genrelabel.Name = "Genrelabel";
            this.Genrelabel.Size = new System.Drawing.Size(107, 20);
            this.Genrelabel.TabIndex = 0;
            this.Genrelabel.Text = "Жанр музыки";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(12, 32);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(141, 20);
            this.GenreTextBox.TabIndex = 1;
            this.GenreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddGanre
            // 
            this.AddGanre.Location = new System.Drawing.Point(13, 59);
            this.AddGanre.Name = "AddGanre";
            this.AddGanre.Size = new System.Drawing.Size(140, 23);
            this.AddGanre.TabIndex = 2;
            this.AddGanre.Text = "Добавить жанр";
            this.AddGanre.UseVisualStyleBackColor = true;
            this.AddGanre.Click += new System.EventHandler(this.AddGanre_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(13, 88);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(140, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddGenre
            // 
            this.ClientSize = new System.Drawing.Size(166, 117);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddGanre);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.Genrelabel);
            this.Name = "AddGenre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Genrelabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Button AddGanre;
        private System.Windows.Forms.Button Exit;
    }
}