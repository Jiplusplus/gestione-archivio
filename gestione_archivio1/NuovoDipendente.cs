using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gestione_archivio1
{
    public partial class NuovoDipendente : Form
    {
        public NuovoDipendente(Dipendenti dpi)
        {
            InitializeComponent();
            archivio = dpi;
        }
        Dipendente dipendente = null;   
        Dipendenti archivio=null;
  
        private void button1_Click(object sender, EventArgs e)
        {
            CharEnumerator car;
            long hashCode, posizioneRelativa;

            if(textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Devi Compilare tutti i Campi!","errore",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dipendente = new Dipendente(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text));
                hashCode = 0;
                car=dipendente.Cognome.GetEnumerator();
                while (car.MoveNext()==true)
                {
                    hashCode=hashCode+car.Current;
                }
                hashCode = hashCode * dipendente.Cognome.Length;
                posizioneRelativa = (hashCode % archivio.GetNumDip());
                posizioneRelativa = posizioneRelativa * 55;
                archivio.inserisci(posizioneRelativa, dipendente);
            }
            this.Close();

        }
        
    }
}
