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
        private int CountColumGenre = 0;
        private int CountColumComposition = 0;
        private int CountGenre = 0;
        private int CountComposition = 0;
        public string GenreCellClick;
        public string[,] arrayGenre = new string[0, 0];
        public string[,] arrayComposition = new string[0, 0];
        public static MusicalWorks MusicalWorksinstance;
        public MusicalWorks()
        {
            InitializeComponent();
            MusicalWorksinstance = this;
        }

        private void Addgenre_Click(object sender, EventArgs e)
        {
            AddGenre OpenAddGenre = new AddGenre();
            OpenAddGenre.Show();
        }//Открытие формы добавление жанра музыки

        public void AddGenre(string textGenre)
        {
            CountGenre++;
            ResizeArray(ref arrayGenre, CountGenre, 1);
            arrayGenre[CountColumGenre, 0] = textGenre;
            int m = arrayGenre.GetLength(0);
            int n = arrayGenre.GetLength(1);
            DGVGenre.ColumnCount = n;
            DGVGenre.RowCount = m;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    DGVGenre.Rows[i].Cells[j].Value = arrayGenre[i, j];
                }
            }
            CountColumGenre++;
        }//Добавление жанра в таблицу

        private void DGVGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridClear(DGVComposition);
            int DGVRowIndex = e.RowIndex;
            int DGVColumnIndex = e.ColumnIndex;
            if (DGVColumnIndex == -1)
            {
                DGVColumnIndex = 0;
            }
            else
            {
                DGVColumnIndex = 0;
            }
            GenreCellClick = arrayGenre[DGVRowIndex, DGVColumnIndex];
            SearchMass1();
        }

        public void ResizeArray<T>(ref T[,] array, int size1, int size2)//изменение размера массива
        {
            T[,] new_array = new T[size1, size2];
            size1 = Math.Min(array.GetLength(0), size1);
            size2 = Math.Min(array.GetLength(1), size2);
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++) 
                    new_array[i, j] = array[i, j];
            }
            array = new_array;
        }

        private void AddComposition_Click(object sender, EventArgs e)
        {
            if (GenreCellClick != null)
            {
                AddComposition OpenAddComposition = new AddComposition(GenreCellClick);
                OpenAddComposition.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Внимание, вы не выбрали жанр музыки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AddCompositionText(string Composition, string Executor, string Album, string Genre)
        {
            CountComposition++;
            ResizeArray(ref arrayComposition, CountComposition, 4);
            arrayComposition[CountColumComposition, 0] = Composition;
            arrayComposition[CountColumComposition, 1] = Executor;
            arrayComposition[CountColumComposition, 2] = Album;
            arrayComposition[CountColumComposition, 3] = Genre;
            int m = arrayComposition.GetLength(0);
            int n = arrayComposition.GetLength(1);
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        DGVComposition.Rows[i].Cells[j].Value = arrayComposition[i, j];
            //    }
            //}
            CountColumComposition++;
        }

        public void SearchMass()
        {
            for (int i = 0; i < arrayComposition.GetLength(0); i++)
            {
                
                if (GenreCellClick == arrayComposition[i, 3])
                {
                    textBox1.Text = arrayComposition[i, 1];
                    for (int j = 0; j < arrayComposition.GetLength(1); j++)
                    {
                        DGVComposition.Rows[i].Cells[j].Value = arrayComposition[i, j];
                        
                    }
                    CountColumComposition++;
                }
            }
        }

        public void SearchMass1()
        {
            int a=0;
            int s=0;
            int count = 0;
            string[,] mass = new string[10,4];
            for (int i = 0; i < arrayComposition.GetLength(0); i++)
            {
                if (GenreCellClick == arrayComposition[i, 3])
                {
                    for (int j = 0; j < arrayComposition.GetLength(1); j++)
                    {
                        mass[s, j] = arrayComposition[i, j];
                       
                    }
                    count++;
                    s++;
                }
                a++;
            }
            if (mass[0,0] != null)
            { 
            ResizeArray(ref mass, count, 4);
            int m = mass.GetLength(0);
            int n = mass.GetLength(1);
            
                DGVComposition.ColumnCount = n;
                DGVComposition.RowCount = m;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        DGVComposition.Rows[i].Cells[j].Value = mass[i, j];
                    }
                }
            }
        }
        public void DataGridClear(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
        }
    }
}
