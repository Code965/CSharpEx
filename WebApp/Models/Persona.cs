using System;

namespace WebApp.Models{
    public class Persona{

        public int id = 0;
        public string nome;
        public string cognome;

        public Persona(string nome, string cognome){
            this.id++;
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

        //METODI
        public virtual string toString()
        {
            return this.Nome + " " + this.Cognome;
        }

        
        
    }

}