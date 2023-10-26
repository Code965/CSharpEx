using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ecommerce
{
    public class Articoli
    {
        private int codiceNumerico;
        string descrizione;
        double costo;

        public Articoli(string descrizione, double costo)
        {
            this.codiceNumerico = codiceNumerico + 1;
            this.descrizione = descrizione;
            this.costo = costo;
        }

        //PROPRIETA'
        
        public string Descrizione
        {
            get
            {
                return this.descrizione;
            }

            set
            {
                this.descrizione = value;
            }
        }

        public double Costo
        {
            get
            {
                return this.costo;
            }

            set
            {
                this.costo = value;
            }
        }

        public string toString()
        {
            return "Codice: " + this.codiceNumerico + "Descrizione: " + this.descrizione + "Costo: " + this.costo;
        }


    }
}
