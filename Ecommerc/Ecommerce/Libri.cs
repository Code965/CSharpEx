using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Libri : Articoli 
    {
        private string titolo;
        private string autore;
        public Libri(  string descrizione, double costo, string titolo, string autore) : base(descrizione,costo)
        {
            this.titolo = titolo;
            this.autore = autore;
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

        public string Autore
        {
            get
            {
                return this.autore;
            }

            set
            {
                this.autore = value;
            }
        }

        public string toStringLibri()
        {
            return base.toString() + "Titolo: " + this.titolo + "Autore: " + this.autore;
        }

    }
}
