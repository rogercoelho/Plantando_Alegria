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
using static Plantando_Alegria.MysqlDb.DB_PA;

namespace Plantando_Alegria.Forms
{
    public partial class frm_pesquisar_planos : Form
    {
        #region Instanciando Objetos.

        DB_PA dB_PA = new DB_PA();
        DB_PA.Encerramento encerramento = new DB_PA.Encerramento();

        #endregion

        #region Metodo Construtor.
        public frm_pesquisar_planos()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodo do botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();
            frm_Tela_Principal.Show();
            this.Close();
        }
        #endregion

        #region Metodo do botao Limpar
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtb_codigo_plano.Clear();
            txtb_nome_plano.Clear();
            chkbox_resultado.Items.Clear();
        }

        #endregion

        #region Metodo do botao Pesquisar.
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            #region Tratando as variaveis.
            dB_PA.Limpa_Variaveis_Plano();
            DB_PA.planos_codigo = txtb_codigo_plano.Text.ToUpper();
            DB_PA.planos_nome = txtb_nome_plano.Text.ToUpper();
            DB_PA.pesquisar_planos = true;

            #endregion

            #region Retorna todas as informacoes da tabela.

            if (txtb_codigo_plano.Text == "" && txtb_nome_plano.Text == "")       // Pesquisa com os campos em branco.
            {

                encerramento.Mensagem_01();                                   // Da um aviso que retorna tudo da tabela.

                dB_PA.Pesquisar_Tudo_tbl_planos_cadastro();
            }

            #endregion

            #region Retorna a pesquisa pelo codigo.

            else if (txtb_nome_plano.Text == "" && txtb_codigo_plano.Text != "")                                 // Faz a busca pelo Codigo_Aluno.
            {
                dB_PA.Pesquisar_pelo_Codigo_tbl_planos_cadastro();
            }

            #endregion

            #region Retorna a pesquisa pelo nome.

            else if (txtb_codigo_plano.Text == "" && txtb_nome_plano.Text != "")                                        // Faz a busca pelo label Nome Aluno
            {
                dB_PA.Pesquisar_Pelo_Nome_tbl_planos_cadastro();
            }

            #endregion

            #region Retorna a pesquisa pelo nome ou pelo codigo.

            else if (txtb_nome_plano.Text != "" && txtb_codigo_plano.Text != "")      // Se a pesquisa tiver dados em ambos os campos.
            {
                encerramento.Mensagem_30();                                       // Informa que a pesquisa vai retornar valores de ambos os campos.
                dB_PA.Pesquisar_pelo_Nome_Codigo_tbl_planos_cadastro();
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
                DB_PA.Cad_Ok = null;
            }
            else
            {
                btn_limpar.PerformClick();
            }

            #endregion
        }


        #endregion

        #region Metodo do Checklistbox.
        private void chkbox_resultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm_ficha_planos frm_Ficha_Planos = new frm_ficha_planos();             // Isntanciando objeto para a classe ficha do aluno.    
            frm_ficha_planos.selecao = chkbox_resultado.SelectedItem.ToString();    // Variavel selecao recebe o item selecionado do checklistbox.
            frm_Ficha_Planos.Show();                                                // Abre a tela ficha do aluno.
            this.Close();                                                           // Fecha a tela atual.
        }

        #endregion
    }
}
