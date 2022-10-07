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
    public partial class CreaArchivio : Form
    {
        public CreaArchivio()
        {
            InitializeComponent();
        }
        private long numeroDipendenti;

        public long NumeroDipendenti
        {
            get => numeroDipendenti;
            set => numeroDipendenti = value;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeroDipendenti=long.Parse(textBox1.Text);
            this.Close();
        }
    }
}
