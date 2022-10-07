using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace gestione_archivio1
{
    public class Dipendenti
    {
        private long numeroDipendenti, numRecInseriti = 0;
        private string archivio = "dipendenti.dat";
        BinaryReader br = null;
        BinaryWriter bw = null;
        FileStream fs = null;

        public void setNumDip(long numeroDipendenti)
        {
            this.numeroDipendenti = numeroDipendenti;
        }
        public void setNumRec(long numRecInseriti)
        {
            this.numRecInseriti = numRecInseriti;
        }

        public Dipendenti(long record)
        {

            int i;
            fs = new FileStream(archivio, FileMode.Create, FileAccess.Write);
            numeroDipendenti = record;

            for (i = 0; i < record * 55; i++) fs.WriteByte(Convert.ToByte('-'));
            fs.Close();
        }
        public Dipendenti()
        {
            int i;
            if (File.Exists(archivio))
            {
                fs = File.Open(archivio, FileMode.Open);
                numeroDipendenti = fs.Length / 55;
                fs.Seek(0, SeekOrigin.Begin);
                for (i = 0; i < numeroDipendenti; i++)
                {
                    if (Convert.ToByte(fs.ReadByte()) != '-')
                        numRecInseriti++;
                    fs.Seek(54, SeekOrigin.Current);
                }
                fs.Close();
            }
        }
        public long getNumRec()
        {
            return numRecInseriti;
        }
        public long GetNumDip()
        {
            return numeroDipendenti;
        }

        public void inserisci(long p, Dipendente dip)
        {

            fs = new FileStream(archivio, FileMode.Open);
            fs.Seek(p, SeekOrigin.Begin);
            while (fs.ReadByte() != Convert.ToByte('-'))
            {

                //("collisione cerco nuova posizione");
                if (fs.Position < (numeroDipendenti * 55) - 54)
                    fs.Seek(54, SeekOrigin.Current);
                else
                    fs.Position = 0;
            }
            //trovata la posizione finalmente inserisco il record
            numRecInseriti++;
            fs.Seek(-1, SeekOrigin.Current);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(dip.Cognome.PadRight(19, ' '));
            bw.Write(dip.Nome.PadRight(14, ' '));
            bw.Write(dip.Stipendio);
            bw.Write(dip.getAliquota());
            bw.Write(dip.getStipendioNetto());
            bw.Close();
            fs.Close();

        }
        public List<Dipendente> cerca(string cognomeDaCercare, bool cerca)
        {
            long letti = 0, pos;
            List<Dipendente> elenco = new List<Dipendente>();
            fs = new FileStream(archivio, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            while (letti < numRecInseriti)
            {
                while (fs.ReadByte() == Convert.ToByte('-'))
                    fs.Seek(54, SeekOrigin.Current);

                fs.Seek(-1, SeekOrigin.Current);
                pos = fs.Position;
                Dipendente letto = new Dipendente(br.ReadString().Trim(), br.ReadString().Trim(), br.ReadDouble(), pos);
                br.ReadInt32();
                br.ReadDouble();
                letti++;
                if (cerca)
                {
                    if (letto.Cognome == cognomeDaCercare)
                        elenco.Add(letto);
                }
                else
                    elenco.Add(letto);
            }
            fs.Close();
            br.Close();
            return elenco;
        }
        public List<Dipendente> cercaDipendente(string cognomeDacercare)
        {
            return cerca(cognomeDacercare, true);
        }
        public List<Dipendente> visualizzaDipendenti()
        {
            return cerca(null, false);
        }
        public void modifica(Dipendente d)
        {
            fs = new FileStream(archivio, FileMode.Open, FileAccess.Write);
            bw = new BinaryWriter(fs);
            fs.Seek(d.Posizione, SeekOrigin.Begin);
            bw.Write(d.Cognome.PadRight(19,' '));
            bw.Write(d.Nome.PadRight(14,' '));
            bw.Write(d.Stipendio);
            bw.Write(d.getAliquota());
            bw.Write(d.getStipendioNetto());
            fs.Close();
            bw.Close();
        }
        public void cencella(long pos)
        {
            fs=new FileStream(archivio, FileMode.Open, FileAccess.Write);
            fs.Seek(pos,SeekOrigin.Begin);
            fs.WriteByte(Convert.ToByte('-'));
            fs.Close();
            numRecInseriti--;
        }

    } 
}

