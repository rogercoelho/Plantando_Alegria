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
    public partial class frm_ficha_planos : Form
    {
        #region Variaveis operacionais.
        public static string selecao;
        public static string[] selecao2;

        #endregion

        #region Metodo Construtor
        public frm_ficha_planos()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodo do Botao Limpar
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

        #region Metodo do Botao Cancelar.
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txtb_codigo_plano.Enabled = false;
            txtb_nome_plano.Enabled = false;
            txtb_qtd_aulas_semana.Enabled = false;
            txtb_qtd_aulas_total.Enabled = false;
            txtb_valor_mensal_plano.Enabled = false;
            txtb_valor_total_plano.Enabled = false;
            txtb_situacao_plano.Visible = true;
            cbbox_situacao_plano.Visible = false;
            btn_cancelar.Visible = false;
            btn_limpar.Visible = false;
            btn_salvar.Visible = false;
            btn_editar.Visible = true;
            btn_voltar.Visible = true;
            Carrega_Ficha_Plano();
        }
        #endregion

        #region Metodo do botao Historico.
        private void btn_historico_Click(object sender, EventArgs e)
        {
            frm_historico frm_Historico = new frm_historico();
            frm_historico.volta_ficha_plano = true;
            DB_PA.planos_codigo = selecao2[1];
            frm_Historico.Show();
            this.Close();            
        }
        #endregion

        #region Metodo do Botao Editar.
        private void btn_editar_Click(object sender, EventArgs e)
        {
            txtb_nome_plano.Enabled = true;
            txtb_qtd_aulas_semana.Enabled = true;
            txtb_qtd_aulas_total.Enabled = true;
            txtb_valor_mensal_plano.Enabled = true;
            txtb_valor_total_plano.Enabled = true;
            txtb_situacao_plano.Visible = false;
            cbbox_situacao_plano.Visible = true;
            btn_voltar.Visible = false;
            btn_editar.Visible = false;
            btn_salvar.Visible = true;
            btn_cancelar.Visible = true;
            btn_limpar.Visible = true;
        }
        #endregion

        #region Metodo do Botao Voltar
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();
            frm_Tela_Principal.Show();
            this.Close();
        }
        #endregion

        #region Metodo que carrega a ficha do plano.
        public void Carrega_Ficha_Plano()
        {
            char[] remove = new char[] { '|' };                                         // Criando um array de variaveis com caracteres que serao removidos da selecao.
            selecao2 = selecao.Split(remove, StringSplitOptions.RemoveEmptyEntries);    // Selecao2 recebe de selecao com os caracteres removidos.
            txtb_codigo_plano.Text = selecao2[1].ToString();
            txtb_nome_plano.Text = selecao2[3].ToString();
            txtb_qtd_aulas_semana.Text = selecao2[5].ToString();
            txtb_qtd_aulas_total.Text = selecao2[7].ToString();
            txtb_valor_mensal_plano.Text = selecao2[9].ToString();
            txtb_valor_total_plano.Text = selecao2[11].ToString();
            txtb_situacao_plano.Text = selecao2[13].ToString();
        }

        #endregion

        #region Metodo de execucao ao carregar tela.
        private void frm_ficha_planos_Load(object sender, EventArgs e)
        {
            Carrega_Ficha_Plano();
        }
        #endregion

        #region Metodo do Botao Salvar.
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            #region Atribui valor para as variaveis.
            DB_PA.planos_codigo = txtb_codigo_plano.Text.Trim();
            DB_PA.planos_nome = txtb_nome_plano.Text.Trim();
            DB_PA.planos_qtd_aulas_semana = txtb_qtd_aulas_semana.Text.Trim();
            DB_PA.planos_qtd_aulas_total = txtb_qtd_aulas_total.Text.Trim();
            DB_PA.planos_valor_mensal = txtb_valor_mensal_plano.Text.Trim();
            DB_PA.planos_valor_total = txtb_valor_total_plano.Text.Trim();
            DB_PA.planos_situacao = cbbox_situacao_plano.SelectedItem.ToString();
            #endregion



        }
        #endregion
    }
}
