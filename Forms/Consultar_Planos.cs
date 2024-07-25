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
        #region Inicio - Instanciando Objetos.

        DB_PA dB_PA = new DB_PA();              // Isntancia objeto para a classe DB_PA.
        Mensagens mensagens = new Mensagens();  // Instancia objeto para a clase mensagens.

        #endregion Fim - Instanciando Objetos.

        #region Inicio - Metodo Construtor.
        public frm_pesquisar_planos()
        {
            InitializeComponent();
        }

        #endregion Fim - Metodo Construtor.

        #region Inicio - Metodo do botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();   // Instancia objeto para o form tela principal.
            frm_Tela_Principal.Show();                                          // Abre a tela principal.
            this.Close();                                                       // Fecha esta tela.
        }
        #endregion Fim - Metodo do botao Voltar.

        #region Inicio - Metodo do botao Limpar.
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtb_codigo_plano.Clear();          // Limpa o textbox.
            txtb_nome_plano.Clear();            // Limpa o textbox.
            chkbox_resultado.Items.Clear();     // Limpa o checklistbox.
        }

        #endregion Fim - Metodo do botao Limpar.

        #region Inicio - Metodo do botao Pesquisar.
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            dB_PA.Limpar_Variaveis_Tbl_Planos_Cadastro();                                 // Chama o metodo que limpa as variaveis do plano.
            DB_PA.tela_pesquisa_codigo_plano = txtb_codigo_plano.Text.ToUpper().Trim();  // Atribui o valor do textbox para a variavel.
            DB_PA.tela_pesquisa_nome_plano = txtb_nome_plano.Text.ToUpper().Trim();      // Atribui o valor do textbox para a variavel.
            DB_PA.pesquisar_planos = true;                                               // Atribui true a variavel pesquisar_planos.
            dB_PA.Transfere_Pesquisa_PlanosXTabela_Planos_Cadastro();
            
            if (txtb_codigo_plano.Text == "" && txtb_nome_plano.Text == "") // Pesquisa com os campos em branco.
            {
                mensagens.Mensagem_01();                                    // Da um aviso que retorna tudo da tabela.
                dB_PA.Pesquisar_Tudo_tbl_planos_cadastro();                 // Chama o metodo que pesquisa todos os planos
            }
            else if (txtb_nome_plano.Text == "" && txtb_codigo_plano.Text != "")    // Faz a busca pelo Codigo_Aluno.
            {
                dB_PA.Pesquisar_pelo_Codigo_tbl_planos_cadastro();                  // Chama o metodo que pesquisa pelo codigo do plano.
            }
            else if (txtb_codigo_plano.Text == "" && txtb_nome_plano.Text != "")    // Faz a busca pelo label Nome Aluno
            {
                dB_PA.Pesquisar_Pelo_Nome_tbl_planos_cadastro();                    // Chama o metodo que pesquisa pelo nome do plano.
            }
            else if (txtb_nome_plano.Text != "" && txtb_codigo_plano.Text != "")    // Se a pesquisa tiver dados em ambos os campos.
            {
                mensagens.Mensagem_30();                                            // Informa que a pesquisa vai retornar valores de ambos os campos.
                dB_PA.Pesquisar_pelo_Nome_Codigo_tbl_planos_cadastro();             // Chama o metodo que pesquisa pelo nome e pelo codigo do plano.
            }
            dB_PA.Executa_Pesquisa();                                               // Chama o metodo que executa a pesquisa.

            if (DB_PA.retornou_pesquisa == true)
            {
                chkbox_resultado.Items.Clear();                             // Limpa o checklistbox para incluir valores novos.
                chkbox_resultado.Items.AddRange(dB_PA.lista.ToArray());     // Passa os itens da variavel resultado para um array e depois adiciona do checklistbox.
                mensagens.Mensagem_03();                                    // Mostra mensagem em tela.
                DB_PA.Cad_Ok = null;                                        // Atribui null a variavel Cad_OK.
            }
            else
            {
                btn_limpar.PerformClick();                                  // Executa o metodo do botao limpar.
            }
        }

        #endregion Fim - Metodo do botao Pesquisar.

        #region Inicio - Metodo do Checklistbox.
        private void chkbox_resultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm_ficha_planos frm_Ficha_Planos = new frm_ficha_planos();                             // Isntanciando objeto para a classe ficha do aluno.    
            DB_PA.planos_selecao = chkbox_resultado.SelectedItem.ToString().Trim();   // Variavel selecao recebe o item selecionado do checklistbox.
            frm_Ficha_Planos.Show();                                                                // Abre a tela ficha do aluno.
            this.Close();                                                                           // Fecha a tela atual.
        }

        #endregion Fim - Metodo do Checklistbox.
    }
}
