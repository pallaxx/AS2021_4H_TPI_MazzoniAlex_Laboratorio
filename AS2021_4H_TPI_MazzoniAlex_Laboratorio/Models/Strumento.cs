using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_4H_TPI_MazzoniAlex_Laboratorio.Models
{
    class Strumento
    {
        string _numeroIdentificativo;
        public string NumeroIdentificativo { get => _numeroIdentificativo; set => _numeroIdentificativo = value; }

        double _costo;
        public double Costo { get => _costo; set => _costo = value; }

        string _descrizione;
        public string Descrizione { get => _descrizione; set => _descrizione = value; }

        DateTime _annodiacquisizione;

        DateTime _garanzia;
        public DateTime Garanzia { get => _garanzia; set => _garanzia = value; }

        public Strumento(string identificativo, double costo, string descrizione, DateTime acquisizione, DateTime garanzia)
        {
            _numeroIdentificativo = identificativo;
            _costo = costo;
            _descrizione = descrizione;
            _annodiacquisizione = acquisizione;
            _garanzia = garanzia;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codice Identificativo:\t\t\t{_numeroIdentificativo}");
            sb.AppendLine($"Costo:\t\t\t\t\t{_costo}"+" euro");
            sb.AppendLine($"Descrizione:\t\t\t\t{_descrizione}");
            sb.AppendLine($"Data di Acquisizione:{_annodiacquisizione}");
            sb.AppendLine($"Data di Garanzia:{_garanzia}");

            return sb.ToString();
        }
    }
}
