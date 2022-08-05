using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MusicalWorksProgram
    {
        private Genre[,] Genres;
        private Composition[] Compositions;
        public int GenreCount = 0;
    
        public void AddGenre(string NameGanre)
        {
            Genres = new Genre[1, GenreCount];
            
            GenreCount++;
            for (int i = 0; i < 1; i++)
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("a[{0},{1}]: ", i, j);
                    
                }
        }


    }
}
