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
    public partial class MusicalWorks : Form
    {
        public static MusicalWorksProgram MWP = new MusicalWorksProgram();
        public MusicalWorks()
        {
            
            InitializeComponent();
        }

        private void Addgenre_Click(object sender, EventArgs e)
        {
            AddGenre OpenAddGenre = new AddGenre(DGVGenre, DGVComposition);
            OpenAddGenre.Show();
        }
    }
}
