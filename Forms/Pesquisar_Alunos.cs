using Plantando_Alegria.MysqlDb;
using System;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_pesquisar_alunos : Form
    {
        

        #region Metodo Construtor.
        public frm_pesquisar_alunos()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodo do Botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();       // Instancia o objeto para a classe frm_tela_Principal.
            frm_Tela_Principal.Show();                                              // Carrega a tela principal.
            this.Close();                                                           // Fecaa tela atual.
        }

        #endregion

        #region Metddo do Botao Limpar.
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtb_codigo.Clear();                // Faz a limpeza do txtb_codigo.
            txtb_nome_aluno.Clear();            // Faz a limpeza do txtb_nome_aluno.
            chkbox_resultado.Items.Clear();     // Faz a limpeza do checklistbox chkbox_resultado.
        }

        #endregion

        #region Metodo do botao Pesquisar.
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            
            #region Instanciando objetos para a classe.

            DB_PA.Encerramento encerramento = new DB_PA.Encerramento();
            DB_PA dB_PA = new DB_PA();
            DB_PA.Alunos_Codigo = txtb_codigo.Text;
            DB_PA.Alunos_Nome = txtb_nome_aluno.Text;
       
            #endregion

            #region Retorna todas as informacoes da tabela.

            if (txtb_codigo.Text == "" && txtb_nome_aluno.Text == "")       // Pesquisa com os campos em branco.
            {
                  
                encerramento.Mensagem_01();                                   // Da um aviso que retorna tudo da tabela.

                dB_PA.Pesquisar_Tudo_tbl_alunos_cadastro();
            }

            #endregion

            #region Retorna a pesquisa pelo nome.

            else if (txtb_codigo.Text == "" && txtb_nome_aluno.Text != "")                                        // Faz a busca pelo label Nome Aluno
            {
                dB_PA.Pesquisar_Pelo_Nome_tbl_alunos_cadastro();
            }

            #endregion

            #region Retorna a pesquisa pelo codigo.

            else if (txtb_nome_aluno.Text == "" && txtb_codigo.Text != "")                                 // Faz a busca pelo Codigo_Aluno.
            {
                dB_PA.Pesquisar_pelo_Codigo_tbl_alunos_cadastro();
            }

            #endregion

            #region Retorna a pesquisa pelo nome ou pelo codigo.

            else if (txtb_nome_aluno.Text != "" && txtb_codigo.Text != "")      // Se a pesquisa tiver dados em ambos os campos.
            {
                encerramento.Mensagem_05();                                       // Informa que a pesquisa vai retornar valores de ambos os campos.
                dB_PA.Pesquisar_pelo_Nome_Codigo_tbl_alunos_cadastro();
            }

            #endregion

            #region Inicia a execucao da pesquisa.

            dB_PA.Executa_Pesquisa();

            #endregion

            #region Transfere as informacoes para a tela (checklistbox).


            if (DB_PA.Cad_Ok == "OK")
            {

            chkbox_resultado.Items.Clear();                             // Limpa o checklistbox para incluir valores novos.
            chkbox_resultado.Items.AddRange(dB_PA.lista.ToArray());     // Passa os itens da variavel resultado para um array e depois adiciona do checklistbox.
            encerramento.Mensagem_03();

            }
            else
            {
                btn_limpar.PerformClick();
            }

            #endregion

        }

        #endregion

        #region Metodo de selecao do checklistbox.
        private void chkbox_resultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm_ficha_alunos frm_Ficha_Alunos = new frm_ficha_alunos();             // Isntanciando objeto para a classe ficha do aluno.

            frm_ficha_alunos.selecao = chkbox_resultado.SelectedItem.ToString();    // Variavel selecao recebe o item selecionado do checklistbox.

            frm_Ficha_Alunos.Show();                                                // Abre a tela ficha do aluno.
            this.Close();                                                           // Fecha a tela atual.
            
        }
        #endregion
    }



}