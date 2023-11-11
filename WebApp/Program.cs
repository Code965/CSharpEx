using System;

namespace WebApp
{
    public class Programs{

        public static void Main(string[] args){
            Database lista = new Database();

            
            string nome,cognome,email,password,numeroTelefono;

              
            while(true){
            

                Console.WriteLine("Cosa vuoi fare? 1 - aggiungi un nuovo utente 2 - Lista utenti 3 - login 4 - Modifica Utente 5 - cambia password");

                int scelta = int.Parse(Console.ReadLine());

                switch(scelta){
                    case 1:
                    Console.WriteLine("Nome");
                    nome = Console.ReadLine();
                    Console.WriteLine("Cognome");
                    cognome = Console.ReadLine();
                    Console.WriteLine("Email");
                    email = Console.ReadLine();
                    Console.WriteLine("Password");
                    password = Console.ReadLine();
                    Console.WriteLine("Numero Telefono");
                    numeroTelefono = Console.ReadLine();
                    Utente p = new Utente(nome,cognome,email,password,numeroTelefono);
                    lista.insertUser(p);

                    break;

                    case 2:
                        foreach (Utente item in lista.getUtenti())
                        {
                            Console.WriteLine(item.toString());
                        }
                    break;

                    case 3:
                        Console.WriteLine("Inserisci la tua email");
                        string email2 = Console.ReadLine();
                        Console.WriteLine("Inserisci la tua password");
                        string password2 = Console.ReadLine();
                        try
                        {   
                            Console.WriteLine(lista.login(email2,password2).toString());

                        }
                        catch (System.Exception ex)
                        {
                             Console.WriteLine("Errore Nessun utente registrato");
                        }
                    break;

                    case 4:
                     
                     Console.WriteLine("Inserisci l'email");
                     string  emailCercata = Console.ReadLine();
                     foreach (Utente item in lista.getUtenti())
                     {
                        if(emailCercata == item.Email){
                            lista.Update(item.Email);
                        }
                     }  

                    break;

                    case 5:
                        Console.WriteLine("Inserisci l'email");
                        string puffo = Console.ReadLine();
                        Console.WriteLine("Inserisci la nuova password");
                        string psw = Console.ReadLine();
                        lista.update_password(puffo,psw);  
                    break;

                    case 0:
                        break;
                    break;
                    
                }
            }
            
        }

    }
    
}
