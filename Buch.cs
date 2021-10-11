using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo
{
    class Buch
    {
        private int isbn;
        private String autor;
        private String titel;

        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public String Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public String Titel
        {
            get { return titel; }
            set { titel = value; }
        }
    }
}
