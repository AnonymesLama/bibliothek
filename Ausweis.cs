using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo
{
    class Ausweis
    {
        private int ausweisnr;
        private DateTime ablaufdatum;
        private Boolean kartenstatus;

        public int AusweisNr
        {
            get { return ausweisnr; }
            set { ausweisnr = value; }
        }

        public DateTime Ablaufdatum
        {
            get { return ablaufdatum; }
            set { ablaufdatum = value; }
        }

        public Boolean Kartenstatus
        {
            get { return kartenstatus; }
            set { kartenstatus = value; }
        }
    }
}
