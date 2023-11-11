using System;
using System.Collections;

namespace WebApp
{
    public class Database
    {   
        ArrayList memoria = new ArrayList();

        public void insertUser(Utente p){
            p.Id +=1;
            memoria.Add(p);
        }

        public ArrayList getUtenti(){
            return memoria;
        }
        public Utente login(string email,string password){

            foreach (Utente item in memoria)
            {
                if(item.Email == email && item.Password == password){
                    Console.WriteLine("Utente Verificato,benvenuto");
                    return item;
                }            
            }

            return null;
        }


        public void Update(string id){

            foreach (Utente item in memoria)
            {
                if(item.Email == id){
                    Console.WriteLine("Cosa vuoi modificare? 1-Nome, 2-Cognome, 3-Email, 4-Password ,5-Numero");
                    int comando = int.Parse(Console.ReadLine());
                    if(comando == 1){
                        Console.WriteLine("inserisci il nome nuovo");
                        item.Nome = Console.ReadLine();
                    }else if(comando == 2){
                         Console.WriteLine("inserisci il cognome nuovo");
                        item.Cognome = Console.ReadLine();
                    }else if(comando ==3){
                         Console.WriteLine("inserisci l'email nuova");
                        item.Email = Console.ReadLine();
                    }else if(comando == 4){
                        Console.WriteLine("inserisci la password");
                        item.Password = Console.ReadLine();
                    }else{
                         Console.WriteLine("inserisci il numero nuovo");
                         item.Numero = Console.ReadLine();
                    }

                }
            }

        }

        public void update_password(string email,string psw){

            foreach (Utente item in memoria)
            {
                if(item.Email == email){
                    item.Password = psw;
                }
            }

        }



        
    }
    
}
