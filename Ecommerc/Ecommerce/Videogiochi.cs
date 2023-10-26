using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Videogiochi : Articoli
    {
        private string piattaforma;
        private string titolo;
      
        public Videogiochi( string descrizione, double costo, string piattaforma, string titolo) : base(descrizione, costo)
        {
            this.piattaforma = piattaforma;
            this.titolo = titolo;
        }

        public string Piattaforma
        {
            get
            {
                return this.piattaforma;
            }

            set
            {
                this.piattaforma = value;
            }
        }

        public string Titolo
        {
            get
            {
                return this.titolo;
            }

            set
            {
                this.titolo = value;
            }
        }


        public string toStringVideogiochi()
        {
            return base.toString() + "Piattaforma: " + this.piattaforma + "Titolo" + this.titolo;
        }

    }
}
