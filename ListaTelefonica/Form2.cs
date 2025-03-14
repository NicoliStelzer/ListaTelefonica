using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTelefonica
{
    public partial class Form2 : Form
    {
        Form1 TelaPrincipal;
        SqlConnection conexao;

        public Form2(Form1 TelaParametro)
        {
            this.TelaPrincipal = TelaParametro;
            InitializeComponent();

            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TiposTel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conexao.Open();

            var selecionar = conexao.CreateCommand();
            selecionar.CommandText = "SELECT * FROM TiposTel;";

            SqlDataReader leitor = selecionar.ExecuteReader();

            while (leitor.Read())
            {
                TipoTelefone tipo1 = new TipoTelefone(Convert.ToInt32(leitor["idTipo"]), leitor["nome"].ToString());
                TelaPrincipal.listatipo.Add(tipo1);
            }

            comboBox1.DataSource = null;
            comboBox1.DataSource = TelaPrincipal.listatipo;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato contato1 = new Contato(textBox1.Text, textBox2.Text, comboBox1.Text);
            TelaPrincipal.listacontatos.Add(contato1);
            TelaPrincipal.AtualizaGrid();
        }
    }
}

