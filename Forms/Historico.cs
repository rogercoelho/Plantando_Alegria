using MySql.Data.MySqlClient;
using Plantando_Alegria.MysqlDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_historico : Form
    {
        public static bool volta_ficha_aluno;
        public static bool volta_ficha_plano;
        public string query;
        Conexao_Banco_PA conexao_Banco_PA = new Conexao_Banco_PA();    
        MySqlCommand cmd = new MySqlCommand();    
        DataTable dataTable = new DataTable();
            


        public frm_historico()
        {
            InitializeComponent();

            //// propriedades do datagridview

            //dataGridView1.ColumnCount = 12;
            //dataGridView1.Columns[0].HeaderText = "Codigo do Aluno";
            //dataGridView1.Columns[1].HeaderText = "Nome do Aluno";
            //dataGridView1.Columns[2].HeaderText = "Endereco";
            //dataGridView1.Columns[3].HeaderText = "Bairro";
            //dataGridView1.Columns[4].HeaderText = "Cidade";
            //dataGridView1.Columns[5].HeaderText = "CEP";
            //dataGridView1.Columns[6].HeaderText = "Telefone";
            //dataGridView1.Columns[7].HeaderText = "Email";
            //dataGridView1.Columns[8].HeaderText = "Contato de Emergencia";
            //dataGridView1.Columns[9].HeaderText = "Telefone de Emergencia 1";
            //dataGridView1.Columns[10].HeaderText = "Telefone de Emergencia 2";
            //dataGridView1.Columns[11].HeaderText = "Atualizado Em";
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Modo de selecao



        }

        private void Historico_Load(object sender, EventArgs e)
        { 
            cmd.Connection = conexao_Banco_PA.Conectar_DB();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            conexao_Banco_PA.Conectar_DB();
            query = "SELECT * from Alunos_Cadastro_log WHERE Alunos_Codigo =" + DB_PA.Alunos_Codigo;      // variavel que recebe o comando para executar no mysql + o que esta na variavel.
            cmd.CommandText = query;                                                                            // Repassa a variavel query para os comandos do mysql.
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            //preenche o datatable via dataadapter
            dataAdapter.Fill(dataTable);

            //atribui o datatable ao datagridview para exibir o resultado
            dataGridView1.DataSource = dataTable;

            cmd.Connection.Close();

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (volta_ficha_aluno == true)
            {
                volta_ficha_aluno = false;
                frm_ficha_alunos frm_Ficha_Alunos = new frm_ficha_alunos();
                frm_Ficha_Alunos.Show();
                this.Close();

            }
            else if (volta_ficha_plano == true)
            {
                volta_ficha_plano = false;
                frm_ficha_planos frm_Ficha_Planos = new frm_ficha_planos();
                frm_Ficha_Planos.Show();
                this.Close();

            }
        }
    }
}

