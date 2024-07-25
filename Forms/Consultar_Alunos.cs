using Plantando_Alegria.MysqlDb;
using System;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_consultar_alunos : Form
    {

        Mensagens mensagens = new Mensagens();

        private Alunos alunos;
        public frm_consultar_alunos()
        {
            InitializeComponent();
            alunos = new Alunos();

        }

        #region Inicio - Instanciando objetos.

        /* Funcao -> Instanciar objeto para a classe de mensagem e para a classe DB_PA para ser
         * chamado no decorrer da tela. */
   
        

        #endregion Fim - Instanciando objetos.

        #region Inicio - Metodo do Botao Voltar.
        public void btn_voltar_Click(object sender, EventArgs e)
        {
            /*   Funcao -> Retorna para a tela principal do programa.
             * - Instancia o objeto para a classe da tela principal.
             * - Chama o metodo que mostra a tela principal. 
             * - Chama o metodo que fecha a tela atual. */

            frm_controle_de_alunos frm_controle_de_alunos = new frm_controle_de_alunos();
            frm_controle_de_alunos.Show();
            this.Close();
        }

        #endregion Fim - Metodo do Botao Voltar.

        #region Inicio - Metodo do Botao Limpar.
        public void btn_limpar_Click(object sender, EventArgs e)
        {
            /* Funcao -> Faz a limpeza de todos os campos da tela de pesquisa de alunos chamando o metodo Clear() */

            txtb_codigo.Clear();
            txtb_nome_aluno.Clear();
            txtb_cpf.Clear();
            dtgrid_resultado.DataSource = null;
            
            
        }

        #endregion Fim - Metodo do Botao Limpar.

        #region Inicio - Metodo do botao Pesquisar.
        public void btn_pesquisar_Click(object sender, EventArgs e)
        {
 
            alunos.Consulta_Aluno(txtb_codigo.Text, txtb_nome_aluno.Text, txtb_cpf.Text);

            if (alunos.Pesquisa_feita == true)
            {

                dtgrid_resultado.DataSource = alunos.Datagrid;
                dtgrid_resultado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgrid_resultado.Columns[0].HeaderText = "Codigo do Aluno";
                dtgrid_resultado.Columns[1].HeaderText = "Nome do Aluno";
                dtgrid_resultado.Columns[2].HeaderText = "CPF do Aluno ou Resp.";
                dtgrid_resultado.Columns[3].HeaderText = "Nome do Responsavel";
                dtgrid_resultado.Columns[4].HeaderText = "Endereço do Aluno";
                dtgrid_resultado.Columns[5].HeaderText = "Bairro";
                dtgrid_resultado.Columns[6].HeaderText = "Cidade";
                dtgrid_resultado.Columns[7].HeaderText = "CEP";
                dtgrid_resultado.Columns[8].HeaderText = "Telefone do Aluno";
                dtgrid_resultado.Columns[9].HeaderText = "Email do Aluno";
                dtgrid_resultado.Columns[10].HeaderText = "Contato de Emergência";
                dtgrid_resultado.Columns[11].HeaderText = "Telefone de Emergencia 1";
                dtgrid_resultado.Columns[12].HeaderText = "Telefone de Emergencia 2";
                dtgrid_resultado.Columns[13].HeaderText = "Situaçao do Aluno";
                alunos.Pesquisa_feita = false;

                mensagens.Mensagem_03();
            }
        }

        #endregion Fim - Metodo do botao Pesquisar.

        #region Inicio - Metodo de Selecao do DataGrid.

        private void dtgrid_resultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            alunos.Aluno_Selecionado(
                                        Convert.ToInt32(dtgrid_resultado.SelectedRows[0].Cells[0].Value.ToString()),
                                        dtgrid_resultado.SelectedRows[0].Cells[1].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[2].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[3].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[4].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[5].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[6].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[7].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[8].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[9].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[10].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[11].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[12].Value.ToString(),
                                        dtgrid_resultado.SelectedRows[0].Cells[13].Value.ToString());

            frm_ficha_alunos frm_Ficha_Alunos = new frm_ficha_alunos(alunos);
            frm_Ficha_Alunos.Show();
            this.Close();
        }

        #endregion Fim - Metodo de Selecao do DataGrid.
    }
}
    #region Codigo comentado

//    DB_PA.tela_pesquisa_codigo_aluno = txtb_codigo.Text;
//    DB_PA.tela_pesquisa_nome_aluno = txtb_nome_aluno.Text;
//    DB_PA.tela_pesquisa_cpf_aluno = txtb_cpf.Text;
//    dB_PA.Verifica_Campos_Pesquisa_Aluno();
//    if (DB_PA.campos_validados == false)
//    {
//        return;
//    }
//    DB_PA.pesquisar_aluno = true;
//    DB_PA.campos_validados = false;
//    dB_PA.Transfere_Pesquisa_AlunosXTabela_Alunos_Cadastro();
//    if (DB_PA.tela_pesquisa_codigo_aluno == "" && DB_PA.tela_pesquisa_nome_aluno == "" && DB_PA.tela_pesquisa_cpf_aluno == "")
//    {
//        mensagens.Mensagem_01();

//    }
//    else if (DB_PA.tela_pesquisa_nome_aluno == "" && DB_PA.tela_pesquisa_cpf_aluno == "" && DB_PA.tela_pesquisa_codigo_aluno != "")
//    {
//        dB_PA.Pesquisar_pelo_Codigo_tbl_alunos_cadastro();
//    }
//    else if (DB_PA.tela_pesquisa_codigo_aluno == "" && DB_PA.tela_pesquisa_cpf_aluno == "" && DB_PA.tela_pesquisa_nome_aluno != "")
//    {
//        dB_PA.Pesquisar_Pelo_Nome_tbl_alunos_cadastro();
//    }
//    else if (DB_PA.tela_pesquisa_nome_aluno == "" && DB_PA.tela_pesquisa_codigo_aluno == "" && DB_PA.tela_pesquisa_cpf_aluno != "")
//    {
//        dB_PA.Pesquisar_pelo_CPF_tbl_alunos_cadastro();
//    }
//    else if (DB_PA.tela_pesquisa_nome_aluno != "" && DB_PA.tela_pesquisa_codigo_aluno != "" && DB_PA.tela_pesquisa_cpf_aluno != "")
//    {
//        mensagens.Mensagem_05();
//        dB_PA.Pesquisar_pelo_Nome_Codigo_CPF_tbl_alunos_cadastro();
//    }
//    else if (DB_PA.tela_pesquisa_nome_aluno != "" && DB_PA.tela_pesquisa_codigo_aluno != "" && DB_PA.tela_pesquisa_cpf_aluno == "")
//    {
//        mensagens.Mensagem_35();
//        dB_PA.Pesquisar_pelo_Nome_Codigo_tbl_alunos_cadastro();
//    }
//    else if (DB_PA.tela_pesquisa_nome_aluno == "" && DB_PA.tela_pesquisa_codigo_aluno != "" && DB_PA.tela_pesquisa_cpf_aluno != "")
//    {
//        mensagens.Mensagem_36();
//        dB_PA.Pesquisar_pelo_Codigo_CPF_tbl_alunos_cadastro();
//    }
//    else if (DB_PA.tela_pesquisa_nome_aluno != "" && DB_PA.tela_pesquisa_codigo_aluno == "" && DB_PA.tela_pesquisa_cpf_aluno != "")
//    {
//        mensagens.Mensagem_37();
//        dB_PA.Pesquisar_pelo_Nome_CPF_tbl_alunos_cadastro();
//    }
//    dB_PA.Executa_Pesquisa();
//    if (DB_PA.retornou_pesquisa == true)
//    {
//        chkbox_resultado.Items.Clear();
//        chkbox_resultado.Items.AddRange(dB_PA.lista.ToArray());
//        mensagens.Mensagem_03();
//        DB_PA.retornou_pesquisa = false;
//    }
//    else
//    {
//        btn_limpar.PerformClick();
//    }

//    dB_PA.Pesquisar_Tudo_tbl_alunos_cadastro();
//    dB_PA.Executa_Datagrid();
//    dtgrid_resultado.DataSource = tabelaAlunos.Datagrid;
//}

//#endregion Fim - Metodo do botao Pesquisar.



#endregion
