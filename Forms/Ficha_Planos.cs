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
        public static string selecao;       // Criando variavel de selecao do valor.
        public static string[] selecao2;    // Criando variavel de array de selecao.

        #endregion

        #region Instanciando objetos.

        DB_PA dB_PA = new DB_PA();              // Instancia objeto para a classe DB_PA.
        Mensagens mensagens = new Mensagens();  // Instancia objeto para a classe mensagens.
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
            txtb_codigo_plano.Clear();          // Limpa os textbox.
            txtb_nome_plano.Clear();            // Limpa os textbox.
            txtb_qtd_aulas_semana.Clear();      // Limpa os textbox.
            txtb_qtd_aulas_total.Clear();       // Limpa os textbox.
            txtb_valor_mensal_plano.Clear();    // Limpa os textbox.
            txtb_valor_total_plano.Clear();     // Limpa os textbox.
        }


        #endregion

        #region Metodo do Botao Cancelar.
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
            btn_cancelar.Visible = false;               // Altera a visibilidade do botao.
            btn_limpar.Visible = false;                 // Altera a visibilidade do botao.                      
            btn_salvar.Visible = false;                 // Altera a visibilidade do botao.                      
            btn_editar.Visible = true;                  // Altera a visibilidade do botao.                      
            btn_voltar.Visible = true;                  // Altera a visibilidade do botao.                      
            Carrega_Ficha_Plano();                      // Chama o metodo de carregar a ficha do plano.
        }
        #endregion

        #region Metodo do botao Historico.
        private void btn_historico_Click(object sender, EventArgs e)
        {
            frm_historico frm_Historico = new frm_historico();  // Instancia objeto para a form historico.
            frm_historico.volta_ficha_plano = true;             // Atribui true a variavel volta_ficha_plano. 
            DB_PA.planos_codigo = selecao2[1];                  // Variavel planos_codigo recebe o valor da selecao2 posicao 1.
            frm_Historico.Show();                               // Abre a tela de historico.
            this.Close();                                       // Fecha a tela atual
        }
        #endregion

        #region Metodo do Botao Editar.
        private void btn_editar_Click(object sender, EventArgs e)
        {
            txtb_nome_plano.Enabled = true;         // Altera a permissao do textbox.
            txtb_qtd_aulas_semana.Enabled = true;   // Altera a permissao do textbox.
            txtb_qtd_aulas_total.Enabled = true;    // Altera a permissao do textbox.
            txtb_valor_mensal_plano.Enabled = true; // Altera a permissao do textbox.
            txtb_valor_total_plano.Enabled = true;  // Altera a permissao do textbox.
            txtb_situacao_plano.Visible = false;    // Altera a permissao do textbox.
            cbbox_situacao_plano.Visible = true;    // Altera a permissao do combobox.
            btn_voltar.Visible = false;             // Altera a visibilidade do botao.
            btn_editar.Visible = false;             // Altera a visibilidade do botao.
            btn_salvar.Visible = true;              // Altera a visibilidade do botao.
            btn_cancelar.Visible = true;            // Altera a visibilidade do botao.
            btn_limpar.Visible = true;              // Altera a visibilidade do botao.
        }
        #endregion

        #region Metodo do Botao Voltar
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();   // Instancia objeto para a tela principal.
            frm_Tela_Principal.Show();                                          // Abre a tela principal.
            this.Close();                                                       // Fecha a tela atual.
        }
        #endregion

        #region Metodo de execucao ao carregar tela.
        private void frm_ficha_planos_Load(object sender, EventArgs e)
        {
            Carrega_Ficha_Plano();  // Chama o metodo que carrega a ficha do plano.
        }
        #endregion

        #region Metodo que carrega a ficha do plano.
        public void Carrega_Ficha_Plano()
        {
            char[] remove = new char[] { '|' };                                         // Criando um array de variaveis com caracteres que serao removidos da selecao.
            selecao2 = selecao.Split(remove, StringSplitOptions.RemoveEmptyEntries);    // Selecao2 recebe de selecao com os caracteres removidos.
            txtb_codigo_plano.Text = selecao2[1].ToString();                            // Textbox recebe o valor da variavel selecao na posicao 1.
            txtb_nome_plano.Text = selecao2[3].ToString();                              // Textbox recebe o valor da variavel selecao na posicao 3.
            txtb_qtd_aulas_semana.Text = selecao2[5].ToString();                        // Textbox recebe o valor da variavel selecao na posicao 5.
            txtb_qtd_aulas_total.Text = selecao2[7].ToString();                         // Textbox recebe o valor da variavel selecao na posicao 7.
            txtb_valor_mensal_plano.Text = selecao2[9].ToString();                      // Textbox recebe o valor da variavel selecao na posicao 9.
            txtb_valor_total_plano.Text = selecao2[11].ToString();                      // Textbox recebe o valor da variavel selecao na posicao 11.
            txtb_situacao_plano.Text = selecao2[13].ToString();                         // Textbox recebe o valor da variavel selecao na posicao 13.
        }

        #endregion

        #region Metodo do Botao Salvar.
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            #region Atribui valor para as variaveis.
            DB_PA.planos_codigo = txtb_codigo_plano.Text.Trim();                    // Variavel recebe o valor do textbox.
            DB_PA.planos_nome = txtb_nome_plano.Text.Trim();                        // Variavel recebe o valor do textbox.
            DB_PA.planos_qtd_aulas_semana = txtb_qtd_aulas_semana.Text.Trim();      // Variavel recebe o valor do textbox.
            DB_PA.planos_qtd_aulas_total = txtb_qtd_aulas_total.Text.Trim();        // Variavel recebe o valor do textbox.
            DB_PA.planos_valor_mensal = txtb_valor_mensal_plano.Text.Trim();        // Variavel recebe o valor do textbox.
            DB_PA.planos_valor_total = txtb_valor_total_plano.Text.Trim();          // Variavel recebe o valor do textbox.
            DB_PA.planos_situacao = cbbox_situacao_plano.SelectedItem.ToString();   // Variavel recebe o valor do combobox.
            #endregion

            #region Valida os campos da Ficha do Plano.

            dB_PA.Compara_Ficha_Planos();   // chama o metodo de validacao dos campos.

            #endregion

            #region Verifica o que foi alterado e executa a mudanca.

            if (DB_PA.dados_alterados == true)                  // Se a variavel for igual a true.
            {
                dB_PA.Query_Atualizar_Cadastro_Plano();         // Chama o metodo da Query que atualiza o plano.
                dB_PA.Cadastrar_Atualizar_Planos_Cadastro();    // Chama o metodo dos parametros de atualizacao.
                dB_PA.Executa_Banco();                          // Chama o metodo que executa atualizacao no banco.
                DB_PA.e_log = true;                             // Atribui true para a variavel e_log.
                dB_PA.Log_Query_Cadastrar_Plano();              // Chama o metodo da query do log do plano.
                dB_PA.Cadastrar_Atualizar_Planos_Cadastro();    // Chama o metodo dos parametros do log do plano.
                dB_PA.Executa_Banco();                          // Chama o metodo que executa a atualizacao do banco.
                Carrega_Ficha_Plano();                          // Chama o metodo que carrega a ficha do plano novamente.
            }
            else
            {
                mensagens.Mensagem_31();                        // Mostra a mensagem na tela.
            }

            #endregion

        }
        #endregion
    }
}
