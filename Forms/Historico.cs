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
        #region Variaveis operacionais.
        public static bool volta_ficha_aluno;   // Cria variavel para validar o metodo de voltar ficha do aluno.
        public static bool volta_ficha_plano;   // Cria variavel para validar o metodo de voltar a ficha do plano.
        #endregion

        #region Instanciando Objetos.
        DB_PA dB_PA = new DB_PA();              // Instancia objeto para a classe DB_PA.
        #endregion

        #region Metodo Construtor.
        public frm_historico()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodo que executa ao carregar a tela

        private void Historico_Load(object sender, EventArgs e)
        {
                dB_PA.Executa_Pesquisa_Log();               // Chama o metodo que executa a pesquisa.
                dtgrid_historico.DataSource = dB_PA.log;    // Datagrid recebe o conteudo do objeto log.
        }

        #endregion

        #region Metodo do Botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (volta_ficha_aluno == true)  // Se a variavel volta_ficha_aluno for true.
            {
                volta_ficha_aluno = false;                                  // Atribui false a variavel volta_ficha_aluno.
                frm_ficha_alunos frm_Ficha_Alunos = new frm_ficha_alunos(); // Instancia objeto para a tela fiha_alunos.
                frm_Ficha_Alunos.Show();                                    // Abre a tela da ficha do aluno.
                this.Close();                                               // Fecha a tela atual.

            }
            else if (volta_ficha_plano == true) // Se a variavel volta_ficha_plano for true.
            {
                volta_ficha_plano = false;                                  // Atribui false a variavel volta_ficha_plano.
                frm_ficha_planos frm_Ficha_Planos = new frm_ficha_planos(); // Instancia objeto para a tela ficha_planos.
                frm_Ficha_Planos.Show();                                    // Abre a tela ficha de planos.
                this.Close();                                               // Fecha a tela atual.

            }
        }

        #endregion
    }
}

