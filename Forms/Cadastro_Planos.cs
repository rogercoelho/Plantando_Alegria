using MySql.Data.MySqlClient;
using Plantando_Alegria.MysqlDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_cadastro_planos : Form
    {
        #region Instanciando Objetos

        frm_tela_principal frm_tela_Principal = new frm_tela_principal();
        DB_PA dB_PA = new DB_PA();

        #endregion

        #region Metodo Construtor
        public frm_cadastro_planos()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodo do botao voltar
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_Principal.Show();
            this.Close();

        }

        #endregion

        #region Metodo do botao limpar
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtb_codigo_plano.Clear();
            txtb_nome_plano.Clear();
            txtb_qtd_aulas_semana.Clear();
            txtb_qtd_aulas_total.Clear();
            txtb_valor_mensal_plano.Clear();
            txtb_valor_total_plano.Clear();
        }


        #endregion

        private void btn_adicionar_plano_Click(object sender, EventArgs e)
        {

        }
    }
}
