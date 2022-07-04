using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MusicalWorksProgram
    {
        private Genre[] Genres;
        private Composition[] Compositions;
        public int GenreCount = 0;
        public void AddGenre(string NameGanre)
        {
            Genres[GenreCount] = new Genre(NameGanre);
            GenreCount++;
        }

    }
}
