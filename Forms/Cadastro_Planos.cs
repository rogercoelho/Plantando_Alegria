using Plantando_Alegria.MysqlDb;
using System;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_cadastro_planos : Form
    {
        #region Instanciando Objetos

        frm_tela_principal frm_tela_Principal = new frm_tela_principal();   // Instancia objeto para o form tela principal.
        Mensagens mensagens = new Mensagens();                              // Instancia objeto para a classe de mensagens.
        DB_PA dB_PA = new DB_PA();                                          // Instancia objeto para a classe DB_PA.

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
            frm_tela_Principal.Show();  // Abre a tela principal.
            this.Close();               // fecha a tela atual.

        }

        #endregion

        #region Metodo do botao limpar
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtb_codigo_plano.Clear();          // Limpa os textbox.
            txtb_nome_plano.Clear();            // Limpa os textbox.
            txtb_qtd_aulas_semana.Clear();      // Limpa os textbox.
            txtb_qtd_aulas_total.Clear();       // Limpa os textbox.
            txtb_valor_mensal_plano.Clear();    // Limpa os textbox.
            txtb_valor_total_plano.Clear();     // Limpa os textbox.
        }


        #endregion

        #region Metodo do botão adicionar plano.
        private void btn_adicionar_plano_Click(object sender, EventArgs e)
        {
            #region Repassando os valores do textbox para as variaveis.

            DB_PA.planos_codigo = txtb_codigo_plano.Text.ToUpper();                                 // Variavel recebe valor do textbox.
            DB_PA.planos_nome = txtb_nome_plano.Text.ToUpper();                                     // Variavel recebe valor do textbox.
            DB_PA.planos_qtd_aulas_semana = txtb_qtd_aulas_semana.Text.ToUpper();                   // Variavel recebe valor do textbox.
            DB_PA.planos_qtd_aulas_total = txtb_qtd_aulas_total.Text.ToUpper();                     // Variavel recebe valor do textbox.
            DB_PA.planos_valor_mensal = txtb_valor_mensal_plano.Text.ToUpper().Replace(",", ".");   // Variavel recebe valor do textbox e faz substituicao.
            DB_PA.planos_valor_total = txtb_valor_total_plano.Text.ToUpper().Replace(",", ".");     // Variavel recebe valor do textbox e faz substituicao.

            #endregion

            #region Valida os campos do cadastro do plano.

            dB_PA.Verifica_Campos_Plano();  // Chama o metodo que valida os campos.

            #endregion

            #region Se foram validados cadastra o plano e registra o log.

            if (DB_PA.campos_validados == true)
            {
                #region Cadastra os dados do plano.
                DB_PA.e_cadastro = true;                        // Atribui true na variavel para cadastrar a situacao do plano.
                DB_PA.planos_situacao = "ATIVO";
                dB_PA.Query_Cadastrar_Plano();                  // Chama o metodo da query de cadastrar plano.
                dB_PA.Cadastrar_Atualizar_Planos_Cadastro();    // Chama o metodo dos parametros da atualizacao do plano.
                dB_PA.Executa_Banco();                          // Chama o metodo que executa a atualizacao do banco.
                DB_PA.e_cadastro = false;                       // Atribui false a variavel é cadastro.

                #endregion

                #region Se cadastro voltar ok grava o log.
                if (DB_PA.Cad_Ok == "OK")
                {
                    DB_PA.e_log = true;                             // Atribui true a variavel e_log.
                    dB_PA.Log_Query_Cadastrar_Plano();              // Chama o metodo da query de log do plano.
                    dB_PA.Cadastrar_Atualizar_Planos_Cadastro();    // Chama o metodo dos parametros da query de log.
                    dB_PA.Executa_Banco();                          // Chama o metodo que atualiza o banco.

                    if (DB_PA.Cad_Ok == "OK")
                    {
                        mensagens.Mensagem_29();    // Mostra a mensagem na tela.
                        btn_limpar.PerformClick();  // Executa o metodo do botao limpar.
                        DB_PA.Cad_Ok = null;        // atribui null para resetar a variavel.
                    }
                }
                #endregion
            }

            #endregion
        }

        #endregion

    }
}
