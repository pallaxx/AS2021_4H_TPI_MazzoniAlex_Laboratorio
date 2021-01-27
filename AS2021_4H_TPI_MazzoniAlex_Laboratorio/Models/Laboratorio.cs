using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AS2021_4H_TPI_MazzoniAlex_Laboratorio.Models
{
    class Laboratorio
    {
        List<Strumento> _strumenti = new List<Strumento>();
        public Laboratorio()
        {
            _strumenti = new List<Strumento>
            {
                new Strumento("AAAA", 399.99, "Telescopio", Convert.ToDateTime("12/14/2020"), Convert.ToDateTime("12/14/2022")),
                new Strumento("BBBB", 19.99, "Tastiera", Convert.ToDateTime("12/12/2020"), Convert.ToDateTime("12/12/2024")),
                new Strumento("CCCC", 399.99, "Computer", Convert.ToDateTime("12/14/2020"), Convert.ToDateTime("12/14/2022")),
            };
        }

        public void InserisciStrumento(string identificativo, double costo, string descrizione, DateTime acquisizione, DateTime garanzia)
        {
            _strumenti.Add(new Strumento(identificativo, costo, descrizione, acquisizione, garanzia));
        }

        public string RecuperoStrumentodaDescrizione(string descrizione)
        {
            List<Strumento> ListaStrumentodaDescrizione = new List<Strumento>();

            for (int i = 0; i < _strumenti.Count; i++)
                if (_strumenti[i].Descrizione == descrizione)
                    ListaStrumentodaDescrizione.Add(_strumenti[i]);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListaStrumentodaDescrizione.Count; i++)
                sb.AppendLine(ListaStrumentodaDescrizione[i].ToString());

            return sb.ToString();
        }

        public Strumento RecuperoStrumentodaCodice(string codice)
        {
            for (int i = 0; i < _strumenti.Count; i++)
                if (_strumenti[i].NumeroIdentificativo == codice)
                    return _strumenti[i];

            throw new Exception("Lo strumento non è stato trovato!");
        }

        public string RecuperoStrumentodaGaranzia(DateTime garanzia)
        {
            List<Strumento> ListaStrumentodaGaranzia = new List<Strumento>();

            for (int i = 0; i < _strumenti.Count; i++)
                if (_strumenti[i].Garanzia == garanzia)
                    ListaStrumentodaGaranzia.Add(_strumenti[i]);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListaStrumentodaGaranzia.Count; i++)
                sb.AppendLine(ListaStrumentodaGaranzia[i].ToString());

            return sb.ToString();
        }

        public string ListaStrumenti()
        {
            Console.WriteLine("Lista Strumenti:\n");
            List<Strumento> ListaStrumenti = new List<Strumento>();
            for (int i = 0; i < _strumenti.Count; i++)
                ListaStrumenti.Add(_strumenti[i]);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListaStrumenti.Count; i++)
                sb.AppendLine(ListaStrumenti[i].ToString());

            return sb.ToString();
        }

        public bool EliminazioneStrumento(string identificativo)
        {
            for (int i = 0; i < _strumenti.Count; i++)
                if (_strumenti[i].NumeroIdentificativo == identificativo)
                {
                    _strumenti.RemoveAt(i);
                    return true;
                }
            return false;
        }
        public void SalvataggioDati()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\t\tLISTA STRUMENTI\t{DateTime.Today:dd/MM/yyyy}");
            for (int i = 0; i < _strumenti.Count; i++)
                sb.AppendLine(_strumenti[i].ToString());

            File.AppendAllText("ListaStrumenti.txt", sb.ToString());
        }
    }
}
