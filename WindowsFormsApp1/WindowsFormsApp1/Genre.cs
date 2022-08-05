using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Genre
    {
        private string GenreName;
        public Genre()
        {
            
        }
        public Genre(string Genre)
        {
            this.GenreName = Genre;
        }
        public string Genres
        {
            get
            {
                return GenreName;
            }
            set
            {
                GenreName = value;
            }
        }
    }
}
