using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestione_archivio1
{
    public partial class Form1 : Form
    {
        Dipendenti mioArchivio = null;
        public Form1()
        {
           
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // non funziona perche il oggeto è sempre vuoto
          /*  mioArchivio = new Dipendenti();

            if (mioArchivio.GetNumDip() > 0)
                enableMenuOperation();
            else
                disableMenuOperation();
            */
            
        }
        public void enableMenuOperation()
        {
            creaArchivioToolStripMenuItem.Enabled = false;
            visualzzaElencoToolStripMenuItem.Enabled = true;
            nuovoDipendenteToolStripMenuItem.Enabled = true;
            cercaDipendenteToolStripMenuItem.Enabled = true;
            modificaDipendenteToolStripMenuItem.Enabled = true;
            cancellaDipendeteToolStripMenuItem.Enabled = true;
        }
        public void disableMenuOperation()
        {
            creaArchivioToolStripMenuItem.Enabled = true;
            visualzzaElencoToolStripMenuItem.Enabled= false;
            nuovoDipendenteToolStripMenuItem.Enabled = false;
            cercaDipendenteToolStripMenuItem.Enabled = false;
            modificaDipendenteToolStripMenuItem.Enabled = false;
            cancellaDipendeteToolStripMenuItem.Enabled = false;
        }

        private void creaArchivioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CreaArchivio ca=new CreaArchivio();
           ca.ShowDialog();
            mioArchivio = new Dipendenti(ca.NumeroDipendenti);
            

        }

        private void nuovoDipendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuovoDipendente nd;
            if (mioArchivio.getNumRec() < mioArchivio.GetNumDip())
            {
                nd = new NuovoDipendente(mioArchivio);
                nd.ShowDialog();
            }
            else MessageBox.Show("l'archivio è pieno !!", "errore", 
                                    MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            
        }

        private void visualzzaElencoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem riga;
            List<Dipendente> elenco;
            if (mioArchivio.getNumRec() == 0)
                MessageBox.Show("L'archivio è vuoto");
            else
            {
                elenco = mioArchivio.visualizzaDipendenti();
                resettaListView();
                foreach(Dipendente trovato in elenco)
                {
                    riga = new ListViewItem(trovato.Cognome);
                    riepilogo.Items.Add(riga);
                    riga.SubItems.Add(trovato.Nome);
                    riga.SubItems.Add(Convert.ToString(trovato.Stipendio));
                    riga.SubItems.Add(Convert.ToString(trovato.getAliquota())); 
                    riga.SubItems.Add(Convert.ToString(trovato.getStipendioNetto()));
                    riga.SubItems.Add(Convert.ToString(trovato.Posizione));
                }
            }
        }
        private void resettaListView()
        {
            riepilogo.Clear();
            riepilogo.Columns.Add("Cognome");
            riepilogo.Columns.Add("Nome");
            riepilogo.Columns.Add("Stipendio Lordo");
            riepilogo.Columns.Add("Aliquota");
            riepilogo.Columns.Add("Stipendio Netto");
            riepilogo.Columns.Add("");
            riepilogo.Columns[0].Width = 124;
            riepilogo.Columns[1].Width = 104;
            riepilogo.Columns[2].Width = 119;
            riepilogo.Columns[3].Width = 69;
            riepilogo.Columns[4].Width = 114;
            riepilogo.Columns[5].Width = 0;
            riepilogo.View = View.Details;
        }

        private void riepilogo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cercaDipendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CercaDipendentecs cd = new CercaDipendentecs(mioArchivio);
            cd.Show();
        }

        private void modificaDipendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (riepilogo.SelectedItems.Count == 0) MessageBox.Show("devi selezinare un dipendente da modificare");
            else
            {
                Modifica frm = new Modifica(riepilogo);
                if (frm.ShowDialog() == DialogResult.OK) 
                {
                    string pos=riepilogo.SelectedItems[0].SubItems[5].Text;
                    Dipendente modificato = new Dipendente(frm.Cognome, frm.Nome, double.Parse(frm.Stipendio));
                    mioArchivio.modifica(modificato);
                    visualzzaElencoToolStripMenuItem_Click(this, null);
                        }
            }
        }

        private void cancellaDipendeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (riepilogo.SelectedItems.Count == 0) MessageBox.Show("devi selezinare un dipendente da modificare");
            else
            {
                if(MessageBox.Show("sei sicuro di voler cancellare il dipendente selezinato ?","conferma cancellazione",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    mioArchivio.cencella(Convert.ToInt64(riepilogo.SelectedItems[0].SubItems[5].Text));
                    visualzzaElencoToolStripMenuItem_Click(this,null);
                }
            }
        }
    }
}
