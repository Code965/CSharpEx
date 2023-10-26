using System;

namespace WebApp.Models{

    public class Utente : Persona{

        public int id;
        public string email;
        public string password;
        public string nome;
        public string cognome;
        public string numeroTelefono;

        public Utente(string nome, string cognome, string email, string password, string numero):base(nome,cognome){
                this.email = email;
                this.password = password;
                this.numeroTelefono = numero;
        }

        public string Email{
            get{
                return this.email;
            }

            set{
                this.email = value;
            }
        }
        public string Password{
            get{
                return this.password;
            }

            set{
                this.password = value;
            }
        }


        public string Numero{
                    get{
                        return this.numeroTelefono;
                    }

                    set{
                        this.numeroTelefono = value;
                    }
                }
    
    public override string toString()
        {
            return base.toString() + " " + this.Email + " " + this.Password + " " + this.Numero;
        }

    }

}