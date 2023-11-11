using System;

namespace WebApp{

    public class Utente : Persona{

        private int id;
        private string nome;
        private string cognome;
        private string email;
        private string password;
        private string numeroTelefono;

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