using System;

namespace WebApp{
    public class Persona{
        private int id;
        private string nome;
        private string cognome;

        public Persona(string nome, string cognome){
            this.id = 0;
            this.nome = nome;
            this.cognome = cognome;
        }

        public string Nome{
            get{return this.nome;}
            set{
                this.nome = value;
            }
        }

        public string Cognome{
            get{
                return this.cognome;
            }

            set{
                this.cognome = value;
            }
        }

        public int  Id{
            get{
                return this.id;
            }
            set{
                this.id = value;
            }
        }

        //METODI
        public virtual string toString()
        {
            return this.id + " " + this.Nome + " " + this.Cognome;
        }

        
        
    }

}