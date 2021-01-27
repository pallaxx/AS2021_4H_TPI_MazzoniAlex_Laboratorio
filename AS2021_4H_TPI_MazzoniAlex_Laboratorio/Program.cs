using System;
using AS2021_4H_TPI_MazzoniAlex_Laboratorio.Models;

namespace AS2021_4H_TPI_MazzoniAlex_Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Laboratorio laboratorio = new Laboratorio();

            Console.WriteLine("Inserisco nuovo Strumento...\n");
            laboratorio.InserisciStrumento("DDDD", 12.99, "Tastiera", Convert.ToDateTime("02/20/2021"), Convert.ToDateTime("02/20/2023"));
            Console.WriteLine("Strumento Aggiunto\n");

            Console.WriteLine("------------------- questo non lo trova RICERCA PER NUMERO IDENTIFICATIVO --------------------");
            //questo non lo trova RICERCA PER NUMERO IDENTIFICATIVO
            try
            {
                Console.WriteLine(laboratorio.RecuperoStrumentodaCodice("0000"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\n--------------------- Questo lo trova RICERCA PER NUMERO IDENTIFICATIVO ------------------\n");
            //questo lo trova RICERCA PER NUMERO IDENTIFICATIVO
            try
            {
                Console.WriteLine(laboratorio.RecuperoStrumentodaCodice("BBBB"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\n----------------- Ricerca per Descrizione RESTITUISCE UNA LISTA DI TUTTI GLI STRUMENTI CON LA STESSA DESCRIZIONE ----------------------");
            //ricerca per Descrizione RESTITUISCE UNA LISTA DI TUTTI GLI STRUMENTI CON LA STESSA DESCRIZIONE 
            try
            {
                Console.WriteLine(laboratorio.RecuperoStrumentodaDescrizione("Tastiera"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\n----------------- ricerca per ANNO DI GARANZIA RESTITUISCE UNA LISTA DI TUTTI GLI STRUMENTI CON LO STESSO ANNO DI GARANZIA  ----------------------");
            //ricerca per ANNO DI GARANZIA RESTITUISCE UNA LISTA DI TUTTI GLI STRUMENTI CON LO STESSO ANNO DI GARANZIA 
            try
            {
                Console.WriteLine(laboratorio.RecuperoStrumentodaGaranzia(Convert.ToDateTime("12/14/2022")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\n----------------------------------------");

            Console.WriteLine("\nElimino Strumento dal Codice 'AAAA'...\n");
            laboratorio.EliminazioneStrumento("AAAA"); //ELIMININAZIONE DAL CODICE IDENTIFICATIVO
            Console.WriteLine("Strumento Eliminato");

            Console.WriteLine("\n------------------- LISTA DI TUTTI GLI STRUMENTI -------------------");
            try //LISTA DI TUTTI GLI STRUMENTI 
            {
                Console.WriteLine(laboratorio.ListaStrumenti());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            laboratorio.SalvataggioDati();
        }
    }
}
