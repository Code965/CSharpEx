using System;
using System.Collections;
using WebApp.Models;

namespace WebApp
{
    public class Database
    {   
        ArrayList database = new ArrayList();

        public void insertUser(Utente p){
            database.Add(p);
        }

        public Utente[] getUtenti(){

            Utente[] arrayUtente = new Utente[database.Count];

            foreach (Utente item in database)
            {
                for(var i=0; i<database.Count; i++){
                    arrayUtente[i] = item;
                }
                
            }

            return arrayUtente;
        }

        
    }
    
}
