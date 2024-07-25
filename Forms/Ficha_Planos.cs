using Plantando_Alegria.MysqlDb;
using System;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_ficha_planos : Form
    {
        #region Inicio - Instanciando objetos.

        DB_PA dB_PA = new DB_PA();              // Instancia objeto para a classe DB_PA.
        Mensagens mensagens = new Mensagens();  // Instancia objeto para a classe mensagens.

        #endregion Fim - Instanciando objetos.

        #region Inicio - Metodo Construtor.
        public frm_ficha_planos()
        {
            InitializeComponent();
        }

        #endregion Fim - Metodo Construtor.

        #region Inicio - Metodo de execucao ao carregar tela.
        private void frm_ficha_planos_Load(object sender, EventArgs e)
        {
            dB_PA.Limpar_Variaveis_Ficha_Plano();   // Limpa as variaveis da tela de ficha de planos
            dB_PA.Tela_Planos_Trata_Selecao();           // Chama o metodo que trata a selecao e atribui os valores nas variaveis do plano.
            dB_PA.Transfere_Ficha_PlanoXTabela_Planos_Cadastro(); //Chama o metodo que repassa os dados das variaveis da ficha de planos para as variaeis do banco.
            Carrega_Ficha_Plano();                  // Chama o metodo que carrega a ficha do plano.

        }
        #endregion Fim - Metodo de execucao ao carregar tela.

        #region Inicio - Metodo do Botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();   // Instancia objeto para a tela principal.
            frm_Tela_Principal.Show();                                          // Abre a tela principal.
            this.Close();                                                       // Fecha a tela atual.
        }

        #endregion Fim - Metodo do Botao Voltar.

        #region Inicio - Metodo do Botao Cancelar.
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txtb_codigo_plano.Enabled = false;          // Altera a permissao do textbox.
            txtb_nome_plano.Enabled = false;            // Altera a permissao do textbox.
            txtb_qtd_aulas_semana.Enabled = false;      // Altera a permissao do textbox.
            txtb_qtd_aulas_total.Enabled = false;       // Altera a permissao do textbox.
            txtb_valor_mensal_plano.Enabled = false;    // Altera a permissao do textbox.
            txtb_valor_total_plano.Enabled = false;     // Altera a permissao do textbox.
            txtb_situacao_plano.Visible = true;         // Altera a visibilidade do textbox.
            cbbox_situacao_plano.Visible = false;       // Altera a visibilidade do combobox
            txtb_qtd_meses.Visible = true;              // Altera a visibilidade do textbox
            cbbox_quantidade_meses.Visible = false;     // Altera a visibilidade do Combobox.
            btn_cancelar.Visible = false;               // Altera a visibilidade do botao.
            btn_limpar.Visible = false;                 // Altera a visibilidade do botao.                      
            btn_salvar.Visible = false;                 // Altera a visibilidade do botao.                      
            btn_editar.Visible = true;                  // Altera a visibilidade do botao.                      
            btn_voltar.Visible = true;                  // Altera a visibilidade do botao.
            Carrega_Ficha_Plano();                      // Volta a carregar a ficha do plano.
        }
        #endregion Fim - Metodo do Botao Cancelar.

        #region Inicio - Metodo do Botao Limpar.
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtb_codigo_plano.Clear();          // Limpa os textbox.
            txtb_nome_plano.Clear();            // Limpa os textbox.
            txtb_qtd_aulas_semana.Clear();      // Limpa os textbox.
            txtb_qtd_aulas_total.Clear();       // Limpa os textbox.
            txtb_valor_mensal_plano.Clear();    // Limpa os textbox.
            txtb_valor_total_plano.Clear();     // Limpa os textbox.
        }

        #endregion Fim - Metodo do Botao Limpar.

        #region Inicio - Metodo do Botao Editar.
        private void btn_editar_Click(object sender, EventArgs e)
        {
            txtb_nome_plano.Enabled = true;         // Altera a permissao do textbox.
            txtb_qtd_aulas_semana.Enabled = true;   // Altera a permissao do textbox.
            txtb_qtd_aulas_total.Enabled = true;    // Altera a permissao do textbox.
            txtb_valor_mensal_plano.Enabled = true; // Altera a permissao do textbox.
            txtb_valor_total_plano.Enabled = true;  // Altera a permissao do textbox.
            txtb_situacao_plano.Visible = false;    // Altera a permissao do textbox.
            cbbox_situacao_plano.Visible = true;    // Altera a permissao do combobox.
            txtb_qtd_meses.Visible = false;
            cbbox_quantidade_meses.Visible = true;
            cbbox_quantidade_meses.SelectedItem = DB_PA.tela_ficha_planos_qtd_meses;
            btn_voltar.Visible = false;             // Altera a visibilidade do botao.
            btn_editar.Visible = false;             // Altera a visibilidade do botao.
            btn_salvar.Visible = true;              // Altera a visibilidade do botao.
            btn_cancelar.Visible = true;            // Altera a visibilidade do botao.
            btn_limpar.Visible = true;              // Altera a visibilidade do botao.
        }
        #endregion Fim - Metodo do Botao Editar.

        #region Inicio - Metodo que carrega a ficha do plano pelas variaveis da tela.
        public void Carrega_Ficha_Plano()
        {
            txtb_codigo_plano.Text = DB_PA.tela_ficha_planos_codigo;
            txtb_nome_plano.Text = DB_PA.tela_ficha_planos_nome;
            txtb_qtd_meses.Text = DB_PA.tela_ficha_planos_qtd_meses;
            txtb_qtd_aulas_semana.Text = DB_PA.tela_ficha_planos_qtd_aulas_semana;
            txtb_qtd_aulas_total.Text = DB_PA.tela_ficha_planos_qtd_aulas_total;
            txtb_valor_mensal_plano.Text = Convert.ToString(DB_PA.tela_ficha_planos_valor_mensal);
            txtb_valor_mensal_plano.Text = txtb_valor_mensal_plano.Text.Replace(".", ",");
            txtb_valor_total_plano.Text = Convert.ToString(DB_PA.tela_ficha_planos_valor_total);
            txtb_valor_total_plano.Text = txtb_valor_total_plano.Text.Replace(".", ",");
            txtb_situacao_plano.Text = DB_PA.tela_ficha_planos_situacao;
        }

        #endregion Fim - Metodo que carrega a ficha do plano pelas variaveis da tela.

        #region Incio - Metodo do Botao Salvar.
        private void btn_salvar_Click(object sender, EventArgs e)
        {

            #region Inicio - Atribui valor alterado para as variaveis da ficha do plano.

            while (cbbox_quantidade_meses.SelectedItem == null)                           // Se nao for escolhida uma opcao no combobox.
            {
                mensagens.Mensagem_42();                                                // Mostra a mensagem
                return;                                                                 // Retorna.
            }
            while (cbbox_situacao_plano.SelectedItem == null)                           // Se nao for escolhida uma opcao no combobox.
            {
                mensagens.Mensagem_32();                                                // Mostra a mensagem
                return;                                                                 // Retorna.
            }

            DB_PA.tela_ficha_planos_codigo = txtb_codigo_plano.Text.ToUpper().Trim();            // Variavel recebe o valor do textbox.
            DB_PA.tela_ficha_planos_nome = txtb_nome_plano.Text.ToUpper().Trim();                // Variavel recebe o valor do textbox.
            DB_PA.tela_ficha_planos_qtd_meses = cbbox_quantidade_meses.SelectedItem.ToString();  // Variavel recebe o valor do combobox.
            DB_PA.tela_ficha_planos_qtd_aulas_semana = txtb_qtd_aulas_semana.Text.Trim();        // Variavel recebe o valor do textbox.
            DB_PA.tela_ficha_planos_qtd_aulas_total = txtb_qtd_aulas_total.Text.Trim();          // Variavel recebe o valor do textbox.
            DB_PA.tela_ficha_planos_valor_mensal = txtb_valor_mensal_plano.Text;                 // Variavel recebe valor do textbox e faz substituicao.
            DB_PA.tela_ficha_planos_valor_total = txtb_valor_total_plano.Text;                   // Variavel recebe valor do textbox e faz substituicao.
            DB_PA.tela_ficha_planos_situacao = cbbox_situacao_plano.SelectedItem.ToString();     // Variavel recebe o valor do combobox.

            #endregion Fim - Atribui valor alterado para as variaveis da ficha do plano.

            #region Inicio - Valida os campos da Ficha do Plano.

            dB_PA.Verifica_Campos_Tela_Ficha_Plano();
            dB_PA.Compara_Ficha_Planos();   // chama o metodo de validacao dos campos.

            #endregion Fim - Valida os campos da Ficha do Plano.

            #region Inicio - Transfere as variaveis da ficha do plano para as variaveis do banco.

            if (DB_PA.dados_alterados == true && DB_PA.campos_validados == true)
            {
                dB_PA.Transfere_Ficha_PlanoXTabela_Planos_Cadastro();
            }
            #endregion Fim - Transfere as variaveis da ficha do plano para as variaveis do banco.

            #region Inicio - Verifica o que foi alterado e executa a mudanca.

            if (DB_PA.dados_alterados == true)                  // Se a variavel for igual a true.
            {
                dB_PA.Query_Atualizar_Cadastro_Plano();         // Chama o metodo da Query que atualiza o plano.
                dB_PA.Cadastrar_Atualizar_Planos_Cadastro();    // Chama o metodo dos parametros de atualizacao.
                dB_PA.Executa_Banco();                          // Chama o metodo que executa atualizacao no banco.
                DB_PA.e_log = true;                             // Atribui true para a variavel e_log.
                dB_PA.Log_Query_Cadastrar_Plano();              // Chama o metodo da query do log do plano.
                dB_PA.Cadastrar_Atualizar_Planos_Cadastro();    // Chama o metodo dos parametros do log do plano.
                dB_PA.Executa_Banco();                          // Chama o metodo que executa a atualizacao do banco.
                DB_PA.dados_alterados = false;                                          // Atribui false na variavel apos fazer a alteracao.
                DB_PA.campos_validados = false;
                mensagens.Mensagem_33();                        // mostra a mensagem.
            }
            else
            {
                mensagens.Mensagem_31();                        // Mostra a mensagem na tela.
            }

            btn_cancelar.PerformClick();

            #endregion Fim - Verifica o que foi alterado e executa a mudanca.

        }
        #endregion Fim - Metodo do Botao Salvar.

        #region Inicio - Metodo do botao Historico.
        private void btn_historico_Click(object sender, EventArgs e)
        {
            frm_historico frm_Historico = new frm_historico();  // Instancia objeto para a form historico.
            //frm_historico.volta_ficha_plano = true;             // Atribui true a variavel volta_ficha_plano. 
            if (DB_PA.tela_ficha_planos_codigo != null)              // Se a variavel nao estiver vazia.
            {
                DB_PA.tbl_planos_cadastro_codigo = DB_PA.tela_ficha_planos_codigo;    // Variavel planos_codigo recebe o valor da selecao2 posicao 1.
            }
            frm_Historico.Show();                               // Abre a tela de historico.
            this.Close();                                       // Fecha a tela atual
        }
        #endregion Fim - Metodo do botao Historico.

    }
}
