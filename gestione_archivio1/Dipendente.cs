using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_archivio1
{
    public class Dipendente
    {
        private string cognome,nome;
        private long posizione;
        private double stipendio;
        public Dipendente(string cognome,string nome,double stipendio)
        {
            this.nome=nome;
            this.cognome=cognome;
            this.stipendio=stipendio;
        }
        public Dipendente(string cognome, string nome, double stipendio,long posizione)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.stipendio = stipendio;
            this.posizione = posizione; 
        }
        public string Nome 
        {
            get => nome;
            set => nome = value;
        }
        public string Cognome
        {
            get => cognome;
            set => cognome = value;
        }
        public long Posizione
        {
            get => posizione;
            set => posizione = value;
        }
        public double Stipendio
        {
            get => stipendio;
            set => stipendio = value;
        }
        public int getAliquota()
        {
            int a;
            if ((stipendio * 13) < 30000) a = 27;
            else
                if ((stipendio * 13) > 30000.00 && (stipendio * 13) < 50000.00) a = 35;
            else a = 40;
            return a;
        }
        public double getStipendioNetto()
        {
            double imposta;
            imposta = (stipendio * getAliquota())/100;
            return (stipendio - imposta);
        }

    }
}
