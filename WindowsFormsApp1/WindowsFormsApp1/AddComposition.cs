using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddComposition : Form
    {
        public AddComposition(string GenreText)
        {
            InitializeComponent();
            GenreTextBox.Text = GenreText;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены,что хотите выйти? Все данные будут утеряны", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CompositionAdd_Click(object sender, EventArgs e)
        {
            if (CompositionTextBox.Text != "" && AlbumTextBox.Text !="" && ExecutorTextBox.Text!="")
            {
                MusicalWorks.MusicalWorksinstance.AddCompositionText(CompositionTextBox.Text,ExecutorTextBox.Text,AlbumTextBox.Text,GenreTextBox.Text);
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Внимание, вы не ввели жанр музыки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddComposition_Load(object sender, EventArgs e)
        {

        }
    }
}
