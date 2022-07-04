
namespace WindowsFormsApp1
{
    partial class MusicalWorks
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
            this.DGVGenre = new System.Windows.Forms.DataGridView();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVComposition = new System.Windows.Forms.DataGridView();
            this.Composition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Executor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addgenre = new System.Windows.Forms.Button();
            this.DeleteGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComposition)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVGenre
            // 
            this.DGVGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Genre});
            this.DGVGenre.Location = new System.Drawing.Point(1, -1);
            this.DGVGenre.Name = "DGVGenre";
            this.DGVGenre.Size = new System.Drawing.Size(144, 227);
            this.DGVGenre.TabIndex = 0;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            // 
            // DGVComposition
            // 
            this.DGVComposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVComposition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Composition,
            this.Executor,
            this.Album,
            this.Genre1});
            this.DGVComposition.Location = new System.Drawing.Point(151, -1);
            this.DGVComposition.Name = "DGVComposition";
            this.DGVComposition.Size = new System.Drawing.Size(448, 227);
            this.DGVComposition.TabIndex = 1;
            // 
            // Composition
            // 
            this.Composition.HeaderText = "Произведение";
            this.Composition.Name = "Composition";
            // 
            // Executor
            // 
            this.Executor.HeaderText = "Исполнитель";
            this.Executor.Name = "Executor";
            // 
            // Album
            // 
            this.Album.HeaderText = "Альбом";
            this.Album.Name = "Album";
            // 
            // Genre1
            // 
            this.Genre1.HeaderText = "Жанр";
            this.Genre1.Name = "Genre1";
            // 
            // Addgenre
            // 
            this.Addgenre.Location = new System.Drawing.Point(13, 232);
            this.Addgenre.Name = "Addgenre";
            this.Addgenre.Size = new System.Drawing.Size(99, 23);
            this.Addgenre.TabIndex = 2;
            this.Addgenre.Text = "Добавить жанр";
            this.Addgenre.UseVisualStyleBackColor = true;
            this.Addgenre.Click += new System.EventHandler(this.Addgenre_Click);
            // 
            // DeleteGenre
            // 
            this.DeleteGenre.Location = new System.Drawing.Point(13, 262);
            this.DeleteGenre.Name = "DeleteGenre";
            this.DeleteGenre.Size = new System.Drawing.Size(98, 23);
            this.DeleteGenre.TabIndex = 3;
            this.DeleteGenre.Text = "Удалить жанр";
            this.DeleteGenre.UseVisualStyleBackColor = true;
            // 
            // MusicalWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 291);
            this.Controls.Add(this.DeleteGenre);
            this.Controls.Add(this.Addgenre);
            this.Controls.Add(this.DGVComposition);
            this.Controls.Add(this.DGVGenre);
            this.Name = "MusicalWorks";
            this.Text = "Музыкальные произведения";
            ((System.ComponentModel.ISupportInitialize)(this.DGVGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComposition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridView DGVComposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Composition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre1;
        private System.Windows.Forms.Button Addgenre;
        private System.Windows.Forms.Button DeleteGenre;
    }
}

