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
    public partial class Modifica : Form
    {
        ListView list;
        private string cognome, nome, stipendio;

        private void button1_Click(object sender, EventArgs e)
        {
            cognome = textBox1.Text;
            nome = textBox2.Text;
            stipendio = textBox3.Text;
            this.DialogResult = DialogResult.OK;    
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Modifica(ListView lista)
        {
            list = lista;
            InitializeComponent();
            
            this.textBox1.Text = lista.SelectedItems[0].Text.Trim();
            this.textBox2.Text = lista.SelectedItems[0].SubItems[1].Text.Trim();
            this.textBox3.Text = lista.SelectedItems[0].SubItems[2].Text;

        }

        public string Cognome
        {
            get => cognome;
            set => cognome = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Stipendio
        {
            get => stipendio;
            set => stipendio = value;
        }

        private void Modifica_Load(object sender, EventArgs e)
        {

        }
    }
}
