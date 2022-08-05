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
        public AddGenre()
        {
            InitializeComponent();
        }

        public  void AddGanre_Click(object sender, EventArgs e) //кнопка отправки названия жанра на главную форму 
        {
            if (GenreTextBox.Text != "")
            {
                MusicalWorks.MusicalWorksinstance.AddGenre(GenreTextBox.Text);
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Внимание, вы не ввели жанр музыки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены,что хотите выйти? Все данные будут утеряны", "Предупреждение", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }//выход из формы с предупреждением 
    }
}
