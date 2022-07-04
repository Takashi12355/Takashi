
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
            this.label1 = new System.Windows.Forms.Label();
            this.Composition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Executor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.AddGanre = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Произведение";
            // 
            // Composition
            // 
            this.Composition.Location = new System.Drawing.Point(12, 33);
            this.Composition.Name = "Composition";
            this.Composition.Size = new System.Drawing.Size(166, 20);
            this.Composition.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Исполнитель";
            // 
            // Executor
            // 
            this.Executor.Location = new System.Drawing.Point(12, 79);
            this.Executor.Name = "Executor";
            this.Executor.Size = new System.Drawing.Size(166, 20);
            this.Executor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Альбом";
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(12, 125);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(166, 20);
            this.Album.TabIndex = 5;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 226);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(166, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // AddGanre
            // 
            this.AddGanre.Location = new System.Drawing.Point(12, 197);
            this.AddGanre.Name = "AddGanre";
            this.AddGanre.Size = new System.Drawing.Size(166, 23);
            this.AddGanre.TabIndex = 6;
            this.AddGanre.Text = "Добавить произведение";
            this.AddGanre.UseVisualStyleBackColor = true;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(12, 171);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(166, 20);
            this.Genre.TabIndex = 9;
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
            this.ClientSize = new System.Drawing.Size(286, 403);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddGanre);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Executor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Composition);
            this.Controls.Add(this.label1);
            this.Name = "AddComposition";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Composition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Executor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Album;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddGanre;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Label label4;
    }
}