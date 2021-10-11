using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo
{

    class Ausleihe
    {
        private int exemplarnr;
        private int ausweisnr;
        private DateTime rueckgabedatum;
        private int rueckgabefrist;
        private int verlaengerungen;

        public Ausleihe(int exemplar, int ausweis, DateTime datum, int frist, int verlaengerungen){
            this.exemplarnr = exemplar;
            this.ausweisnr = ausweis;
            this.rueckgabedatum = datum;
            this.rueckgabefrist = frist;
            this.verlaengerungen = verlaengerungen;
        }

        public int ExemplarNr
        {
            get { return exemplarnr; }
            set { exemplarnr = value; }
        }

        public int AusweisNr
        {
            get { return ausweisnr; }
            set { ausweisnr = value; }
        }

        public DateTime Rueckgabedatum
        {
            get { return rueckgabedatum; }
            set { rueckgabedatum = value; }
        }

        public int Rueckgabefrist
        {
            get { return rueckgabefrist; }
            set { rueckgabefrist = value; }
        }

        public int Verlaengerung
        {
            get { return verlaengerung; }
            set { verlaengerung = value; }
        }

        public Boolean verlaengern(){
            if (verlaengerungen < 3){
                this.rueckgabedatum = this.rueckgabedatum.AddDays(30);
                return true;
            }
            return false;
        }
    }
}
