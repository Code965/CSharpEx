using System;
using System.Collections;

namespace Ecommerce
{
    class Principale
    {
        public static void Main()
        {
            ArrayList lista = new ArrayList();

            while (true)
            {
                Console.WriteLine("Cosa vuoi fare? 1 - aggiungi libro 2 - Aggiungi Videogioco 3 - rimuovi articolo 4 - stampa tuto 5 - totale carrello 6 - totale costo libri 7 - totale costo videogiochi 8 - stampa libri 9 - stampa videogiochi");
                int scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:

                        Console.WriteLine("Inserisci la  descrizione");
                        string descrizione = Console.ReadLine();
                        Console.WriteLine("Inserisci il costo");
                        double costo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci il titolo");
                        string titolo = Console.ReadLine();
                        Console.WriteLine("Inserisci l'autore");
                        string autore = Console.ReadLine();

                        lista.Add(new Libri(descrizione, costo, titolo, autore));
                        break;
                    case 2:

                        Console.WriteLine("Inserisci la  descrizione");
                        string descrizioneVideo = Console.ReadLine();
                        Console.WriteLine("Inserisci il costo");
                        double costoVideo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci la piattaforma");
                        string piattaforma = Console.ReadLine();
                        Console.WriteLine("Inserisci il titolo");
                        string titoloVideo = Console.ReadLine();

                        lista.Add(new Videogiochi(descrizioneVideo, costoVideo, piattaforma, titoloVideo));
                        break;
                    case 3:
                        Console.WriteLine("Vuoi rimuovere un libro o un videogioco? 1 - libro 2 - videogioco");
                        Console.WriteLine("Cosa vuoi fare?");
                        int numero = int.Parse(Console.ReadLine());

                        if(numero == 1)
                        {
                            Console.WriteLine("Inserisci il titolo");
                            string stringa = Console.ReadLine();
                               foreach(Libri valore in lista)
                            {
                                if(valore.Titolo == stringa)
                                {
                                    lista.Remove(new Libri(valore.Descrizione, valore.Costo,valore.Titolo,  valore.Autore));
                                }
                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("Inserisci il titolo");
                            string stringa = Console.ReadLine();
                            foreach (Videogiochi valore in lista)
                            {
                                if (valore.Titolo == stringa)
                                {
                                    lista.Remove(new Libri(valore.Descrizione, valore.Costo, valore.Piattaforma, valore.Titolo));
                                }

                            }

                        }
                        break;

                    case 4:
                        foreach(Articoli val in lista)
                        {
                            Console.WriteLine(val.toString());
                        }
                        break;


                    case 5:
                        double contatore = 0.0;
                        foreach (Articoli valore in lista)
                        {
                            contatore = contatore + valore.Costo;
                        }
                        Console.WriteLine("Costo totlae: " + contatore);
                        break;
                    case 6:
                        double contatoreLibri = 0.0;
                        foreach (Libri valore in lista)
                        {
                            contatoreLibri = contatoreLibri + valore.Costo;
                        }
                        Console.WriteLine("Costo totale Libri: " + contatoreLibri);

                        break;

                    case 7:
                        double contatoreVideo = 0.0;
                        foreach (Videogiochi valore in lista)
                        {
                            contatoreVideo = contatoreVideo + valore.Costo;
                        }
                        Console.WriteLine("Costo totale Libri: " + contatoreVideo);
                        break;
                    case 8:
                        foreach (Libri valore in lista)
                        {
                            Console.WriteLine(valore.toStringLibri());
                        }
                        break;
                    case 9:
                        foreach(Videogiochi valore in lista)
                        {
                            Console.WriteLine(valore.toStringVideogiochi());
                        }
                        break;
               

                }

            }



        }
       

}
}