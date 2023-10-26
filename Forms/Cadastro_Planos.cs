using Plantando_Alegria.MysqlDb;
using System;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_cadastro_planos : Form
    {
        #region Instanciando Objetos

        frm_tela_principal frm_tela_Principal = new frm_tela_principal();
        DB_PA.Encerramento encerramento = new DB_PA.Encerramento();
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

        #region Metodo do botão adicionar plano.
        private void btn_adicionar_plano_Click(object sender, EventArgs e)
        {
            #region Repassando os valores do textbox para as variaveis.

            DB_PA.planos_codigo = txtb_codigo_plano.Text.ToUpper();
            DB_PA.planos_nome = txtb_nome_plano.Text.ToUpper();
            DB_PA.planos_qtd_aulas_semana = txtb_qtd_aulas_semana.Text.ToUpper();
            DB_PA.planos_qtd_aulas_total = txtb_qtd_aulas_total.Text.ToUpper();
            DB_PA.planos_valor_mensal = txtb_valor_mensal_plano.Text.ToUpper().Replace(",", ".");
            DB_PA.planos_valor_total = txtb_valor_total_plano.Text.ToUpper().Replace(",", ".");

            #endregion

            #region Valida os campos do cadastro do plano.
            
            dB_PA.Verifica_Campos_Plano();

            #endregion

            #region Se foram validados cadastra o plano e registra o log.

            if (DB_PA.campos_validados == true)
            {
                #region Cadastra os dados do plano.
                dB_PA.Query_Cadastrar_Plano();
                dB_PA.Cadastrar_Atualizar_Planos_Cadastro();
                dB_PA.Executa_Banco();
                #endregion

                #region Se cadastro voltar ok grava o log.
                if (DB_PA.Cad_Ok == "OK")
                {
                    DB_PA.e_log = true;
                    dB_PA.Log_Query_Cadastrar_Plano();
                    dB_PA.Cadastrar_Atualizar_Planos_Cadastro();
                    dB_PA.Executa_Banco();

                    if (DB_PA.Cad_Ok == "OK")
                    {
                    encerramento.Mensagem_29();
                    btn_limpar.PerformClick();
                    }
                }
                #endregion
            }

            #endregion
        }

        #endregion

    }
}
