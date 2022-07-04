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
    public partial class AddGenre : Form
    {
        private DataGridView DGVGenre;
        private DataGridView DGVCompsition;
        public AddGenre(DataGridView DGVGenre, DataGridView DGVCompsition)
        {
            InitializeComponent();
            this.DGVGenre = DGVGenre;
            this.DGVCompsition = DGVCompsition;
            Up();
        }
        public void Up()
        {
          
        }
    

        private void AddGanre_Click(object sender, EventArgs e)
        {
            MusicalWorks.MWP.AddGenre(TextGenre.Text);
            DGVGenre.RowCount++;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены,что хотите выйти? Все данные будут утеряны", "Предупреждение", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
