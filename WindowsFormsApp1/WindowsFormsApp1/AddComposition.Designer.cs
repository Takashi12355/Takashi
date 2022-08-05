
namespace WindowsFormsApp1
{
    partial class AddComposition
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
            this.CompositionLabel = new System.Windows.Forms.Label();
            this.CompositionTextBox = new System.Windows.Forms.TextBox();
            this.ExecutorLabel = new System.Windows.Forms.Label();
            this.ExecutorTextBox = new System.Windows.Forms.TextBox();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.AlbumTextBox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.CompositionAdd = new System.Windows.Forms.Button();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompositionLabel
            // 
            this.CompositionLabel.AutoSize = true;
            this.CompositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompositionLabel.Location = new System.Drawing.Point(36, 9);
            this.CompositionLabel.Name = "CompositionLabel";
            this.CompositionLabel.Size = new System.Drawing.Size(121, 20);
            this.CompositionLabel.TabIndex = 0;
            this.CompositionLabel.Text = "Произведение";
            // 
            // CompositionTextBox
            // 
            this.CompositionTextBox.Location = new System.Drawing.Point(12, 33);
            this.CompositionTextBox.Name = "CompositionTextBox";
            this.CompositionTextBox.Size = new System.Drawing.Size(166, 20);
            this.CompositionTextBox.TabIndex = 1;
            this.CompositionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExecutorLabel
            // 
            this.ExecutorLabel.AutoSize = true;
            this.ExecutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecutorLabel.Location = new System.Drawing.Point(36, 56);
            this.ExecutorLabel.Name = "ExecutorLabel";
            this.ExecutorLabel.Size = new System.Drawing.Size(111, 20);
            this.ExecutorLabel.TabIndex = 2;
            this.ExecutorLabel.Text = "Исполнитель";
            // 
            // ExecutorTextBox
            // 
            this.ExecutorTextBox.Location = new System.Drawing.Point(12, 79);
            this.ExecutorTextBox.Name = "ExecutorTextBox";
            this.ExecutorTextBox.Size = new System.Drawing.Size(166, 20);
            this.ExecutorTextBox.TabIndex = 3;
            this.ExecutorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlbumLabel.Location = new System.Drawing.Point(54, 102);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(68, 20);
            this.AlbumLabel.TabIndex = 4;
            this.AlbumLabel.Text = "Альбом";
            // 
            // AlbumTextBox
            // 
            this.AlbumTextBox.Location = new System.Drawing.Point(12, 125);
            this.AlbumTextBox.Name = "AlbumTextBox";
            this.AlbumTextBox.Size = new System.Drawing.Size(166, 20);
            this.AlbumTextBox.TabIndex = 5;
            this.AlbumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 226);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(166, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CompositionAdd
            // 
            this.CompositionAdd.Location = new System.Drawing.Point(12, 197);
            this.CompositionAdd.Name = "CompositionAdd";
            this.CompositionAdd.Size = new System.Drawing.Size(166, 23);
            this.CompositionAdd.TabIndex = 6;
            this.CompositionAdd.Text = "Добавить произведение";
            this.CompositionAdd.UseVisualStyleBackColor = true;
            this.CompositionAdd.Click += new System.EventHandler(this.CompositionAdd_Click);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Enabled = false;
            this.GenreTextBox.Location = new System.Drawing.Point(12, 171);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(166, 20);
            this.GenreTextBox.TabIndex = 9;
            this.GenreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Жанр";
            // 
            // AddComposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 260);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CompositionAdd);
            this.Controls.Add(this.AlbumTextBox);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.ExecutorTextBox);
            this.Controls.Add(this.ExecutorLabel);
            this.Controls.Add(this.CompositionTextBox);
            this.Controls.Add(this.CompositionLabel);
            this.Name = "AddComposition";
            this.Text = "Добавление композитора";
            this.Load += new System.EventHandler(this.AddComposition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompositionLabel;
        private System.Windows.Forms.TextBox CompositionTextBox;
        private System.Windows.Forms.Label ExecutorLabel;
        private System.Windows.Forms.TextBox ExecutorTextBox;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.TextBox AlbumTextBox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button CompositionAdd;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label label4;
    }
}