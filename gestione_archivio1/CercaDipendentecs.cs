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
    public partial class CercaDipendentecs : Form
    {
        Dipendenti dp;
        public CercaDipendentecs(Dipendenti d)
        {
            dp= d;
            InitializeComponent();
        }
        private void CercaDipendentecs_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Dipendente> trovati;
            trovati = dp.cercaDipendente(textBox1.Text);
            if (trovati.Count != 0)
            {
                listBox1.Items.Clear();
                foreach (Dipendente trovato in trovati)
                {
                    listBox1.Items.Add("Cognome :".PadRight(18, ' ') + trovato.Cognome);
                    listBox1.Items.Add("Nome :".PadRight(21, ' ') + trovato.Nome);
                    listBox1.Items.Add("StipendioLordo :" + trovato.Stipendio);
                    listBox1.Items.Add("Aliquota :".PadRight(22, ' ') + trovato.getAliquota());
                    listBox1.Items.Add("StipendioNeto :" + trovato.getStipendioNetto());
                    listBox1.Items.Add(new string('-', 50));
                }
            }
            else MessageBox.Show("Cognome inesistente");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
