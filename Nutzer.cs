using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo
{
    class Nutzer
    {
        private int ausweisnr;
        private String vorname;
        private String nachname;
        private double gebuehrenstand;

        public int AusweisNr
        {
            get { return ausweisnr; }
            set { ausweisnr = value; }
        }

        public String Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        public String Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        public double Gebuehrenstand
        {
            get { return gebuehrenstand; }
            set { gebuehrenstand = value; }
        }
    }
}
