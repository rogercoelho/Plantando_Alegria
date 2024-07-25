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
        private Alunos alunos;
        private bool historico_aluno;
        private string query;
        private string codigo;
        Conexao_Banco_PA Conexao_Banco_PA = new Conexao_Banco_PA();
        Mensagens mensagens = new Mensagens();
        MySqlCommand cmd = new MySqlCommand();
        DataTable dataTable = new DataTable();

        public object Datagrid { get; set; }

        #region Inicio - Metodo Construtor.
        public frm_historico()
        {
            InitializeComponent();
            alunos = new Alunos();
            
        }

        public frm_historico(bool historico_aluno, string codigo) : this()
        {
            this.historico_aluno = historico_aluno;
            this.codigo = codigo;
        }


        #endregion Fim - Metodo Construtor.

        #region Inicio - Metodo que executa ao carregar a tela.

        private void Historico_Load(object sender, EventArgs e)
        {
            if (historico_aluno == true)
            {
                query = "SELECT * from Alunos_Cadastro_log WHERE Alunos_Codigo = " + codigo;      // variavel que recebe o comando para executar no mysql + o que esta na variavel.
                cmd.CommandText = query;
                try
                {
                    cmd.Connection = Conexao_Banco_PA.Conectar_DB();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dtgrid_historico.DataSource = dataTable;
                    Conexao_Banco_PA.Desconectar_DB();
                }
                catch (MySqlException erro_db)
                {
                    mensagens.Mensagem_04("--->" + erro_db.Message);
                    historico_aluno = false;
                    return;
                }
                
                
            }
        }

        #endregion Fim - Metodo que executa ao carregar a tela.

        #region Inicio - Metodo do Botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (historico_aluno == true)  // Se a variavel volta_ficha_aluno for true.
            {
                historico_aluno = false;                                  // Atribui false a variavel volta_ficha_aluno.
                frm_ficha_alunos frm_Ficha_Alunos = new frm_ficha_alunos(alunos); // Instancia objeto para a tela ficha_alunos.
                frm_Ficha_Alunos.Show();                                    // Abre a tela da ficha do aluno.
                this.Close();                                               // Fecha a tela atual.

            }
            //else if (volta_ficha_plano == true) // Se a variavel volta_ficha_plano for true.
            //{
            //    volta_ficha_plano = false;                                  // Atribui false a variavel volta_ficha_plano.
            //    frm_ficha_planos frm_Ficha_Planos = new frm_ficha_planos(); // Instancia objeto para a tela ficha_planos.
            //    frm_Ficha_Planos.Show();                                    // Abre a tela ficha de planos.
            //    this.Close();                                               // Fecha a tela atual.

            //}
        }

        #endregion Fim - Metodo do Botao Voltar.
    }
}

