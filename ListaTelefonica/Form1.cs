using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTelefonica
{
    public partial class Form1 : Form
    {
        public List<Contato> listacontatos;
        public List<TipoTelefone> listatipo;
        public Form1()
        {
            InitializeComponent();

            listacontatos = new List<Contato>();
            listatipo = new List<TipoTelefone>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato contato2 = dataGridView1.CurrentRow.DataBoundItem as Contato;

            listacontatos.Remove(contato2);
            AtualizaGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        public void AtualizaGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listacontatos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contato contato3 = dataGridView1.CurrentRow.DataBoundItem as Contato;

            if (contato3 != null)
            {
                contato3.nome = dataGridView1.CurrentRow.Cells["nome"].Value.ToString();
                contato3.telefone = dataGridView1.CurrentRow.Cells["telefone"].Value.ToString();
                contato3.tipo = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();

                AtualizaGrid();
            }
        }
    }
}





