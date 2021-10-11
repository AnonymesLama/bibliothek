using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo
{
    class Exemplar
    {
        private int exemplarnr;
        private int isbn;
        private Boolean status;

        public int ExemplarNr
        {
            get { return exemplarnr; }
            set { exemplarnr = value; }
        }

        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
