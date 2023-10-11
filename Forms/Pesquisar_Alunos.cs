using MySql.Data.MySqlClient;
using Plantando_Alegria.MysqlDb;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_pesquisar_alunos : Form
    {
        public static string codigo_aluno;

        public frm_pesquisar_alunos()
        {
            InitializeComponent();
        }

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
            #region Criando e Instanciando variaveis classes e objetos.

            Conexao_Banco_PA conexao_Banco_PA = new Conexao_Banco_PA();     // Instanciando objeto da classe conexao_banco_PA. Para conectar e desconectar do banco.
            MySqlCommand cmd = new MySqlCommand();                          // Instanciando objeto da classe MysqlCommand. Para executar comandos Mysql.
            MySqlDataReader dataReader;                                     // variavel que armazena a leitura do banco.
            string query;                                                   // Variavel que vai receber a query para executar no banco.
            List<object> lista = new List<object>();                       // Instanciando objeto da classe List. Vai receber o datareader em uma lista.
            Encerramento encerramento = new Encerramento();                 // Classe que concentra todas as mensagens na tela e encerramento dos leitores.

            #endregion

            #region Retorna todas as informacoes da tabela.

            if (txtb_codigo.Text == "" && txtb_nome_aluno.Text == "")       // Pesquisa com os campos em branco.
            {
                encerramento.Mensagem1();                                   // Da um aviso que retorna tudo da tabela.
                query = "SELECT * from Alunos_Cadastro";                  // Consulta do banco de dados Mysql.
                cmd.CommandText = query;                                  // Sintaxe do CommandText recebe a query de consulta no banco.
            }

            #endregion

            #region Retorna a pesquisa pelo nome.

            else if (txtb_codigo.Text == "" && txtb_nome_aluno.Text != "")                                        // Faz a busca pelo label Nome Aluno
            {
                query = "SELECT * from Alunos_Cadastro WHERE Alunos_Nome LIKE '" + txtb_nome_aluno.Text + "'";     // query do mysql + o que esta escrito no label.
                cmd.CommandText = query;                                                                          // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco.
                cmd.Parameters.AddWithValue("@nome", txtb_nome_aluno);                                            // Adiciona um parametro para acrescentar os valores encontrados.
            }

            #endregion

            #region Retorna a pesquisa pelo codigo.

            else if (txtb_nome_aluno.Text == "" && txtb_codigo.Text != "")                                 // Faz a busca pelo Codigo_Aluno.
            {
                query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo =" + txtb_codigo.Text;         // variavel que recebe o comando para executar no mysql + o que esta escrito no label.
                cmd.CommandText = query;                                                                 // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco.
                cmd.Parameters.AddWithValue("@codigo", txtb_codigo);                                       // Adiciona um parametro para acrescentar os valores encontrados.
            }

            #endregion

            #region Retorna a pesquisa pelo nome ou pelo codigo.

            else if (txtb_nome_aluno.Text != "" && txtb_codigo.Text != "")      // Se a pesquisa tiver dados em ambos os campos.
            {
                encerramento.Mensagem5();                                       // Informa que a pesquisa vai retornar valores de ambos os campos.
                query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo="     // variavel que recebe o comando para executar no mysql + o que esta escrito em ambos os labels.
                        + txtb_codigo.Text +
                        " OR Alunos_Nome LIKE '"
                        + txtb_nome_aluno.Text + "'";

                cmd.CommandText = query;                                        // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco.
                cmd.Parameters.AddWithValue("@codigo", txtb_codigo);            // Adiciona um parametro para acrescentar os valores encontrados.
                cmd.Parameters.AddWithValue("@nome", txtb_nome_aluno);          // Adiciona um parametro para acrescentar os valores encontrados.
            }

            #endregion

            #region Inicia a execucao da pesquisa.

            try                                                     // Tenta executar o comando.
            {
                cmd.Connection = conexao_Banco_PA.Conectar_DB();    // Abre a conexao com o banco. 
                dataReader = cmd.ExecuteReader();                   // Abre a execucao do datareader.

                #region Retorna a pesquisa nula.

                if (!dataReader.HasRows)                            // Se o datareader nao possuir dados retornados do banco. 
                {
                    if (!dataReader.IsClosed)                       // Se o datareader nao estiver fechado.
                    {
                        dataReader.Close();                         // Encerra o data_reader.
                        conexao_Banco_PA.Desconectar_DB();           // Encerra a conexao com o banco.
                    }
                    encerramento.Mensagem2();
                }

                #endregion

                #region Retorna a pesquisa com valores encontrados.

                #region Pega do datareader e tranfere para a lista
                else                                                // Caso possua dados na tabela do Banco faz a tratativa.
                {
                    while (dataReader.Read())                       // Enquanto o datareader estiver recebendo dados.
                    {
                        lista.Add(string.Join(null, "Cod ", dataReader[0].ToString(),
                                                      " --- Nome  ", dataReader[1].ToString(),
                                                      " --- Tel.  ", dataReader[2].ToString(),
                                                      " --- Email  ", dataReader[3].ToString(),
                                                      " --- End.  ", dataReader[4].ToString(),
                                                      " --- Bairro  ", dataReader[5].ToString(),
                                                      " --- Cidade  ", dataReader[6].ToString(),
                                                      " --- CEP  ", dataReader[7].ToString(),
                                                      " --- Contato Emergencia  ", dataReader[8].ToString(),
                                                      " --- Tel. Emergencia 1  ", dataReader[9].ToString(),
                                                      " --- Tel. Emergencia 2 ", dataReader[10].ToString()));     // Acrescenta na variavel lista o valor do datareader.
                    }

                    #endregion

                    #region Tranfere as informacoes para a tela (checklistbox).

                    chkbox_resultado.Items.Clear();                         // Limpa o checklistbox para incluir valores novos.
                    chkbox_resultado.Items.AddRange(lista.ToArray());       // Passa os itens da variavel resultado para um array e depois adiciona do checklistbox.
                    encerramento.Mensagem3();

                    #endregion

                }
                #endregion

                #region Encerra o datareader se estiver aberto ainda.
                if (!dataReader.IsClosed)
                {
                    dataReader.Close();
                }

                #endregion
            }


            #region Caso dê algum erro retorna a mensagem.
            catch (MySqlException erro_db)                          // Caso nao consiga executar os comandos do Try retorna o Catch com o erro do banco.
            {
                encerramento.Mensagem4("-->" + erro_db.Message);
            }
            #endregion

            #region Encerra a conexao com o banco.
            conexao_Banco_PA.Desconectar_DB();
            #endregion

            #endregion
        }
        #endregion

        private void chkbox_resultado_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selecao, cod_aluno;                              // criando variaveis

            selecao = chkbox_resultado.SelectedItem.ToString();     // variavel selecao recebe o item selecionado do checkbox

            string[] selecao2 = selecao.Split(' ');                 // cria um array tipo string para separar o conteudo da variavel selecao.
                                                                    // O delimitador é " " (espaco).

            cod_aluno = selecao2[1];                                // A variavel cod_aluno recebe o 2 array da variavel selecao.
            codigo_aluno = cod_aluno.ToString();
            
            
        }
    }


    #region Classe de Mensagens de tela e conexao com o banco.
    public class Encerramento
    {
        Conexao_Banco_PA Conexao_Banco_PA = new Conexao_Banco_PA();    // Intanciando objeto de conexao com o banco.

        public void Encerra_Banco()
        {
            Conexao_Banco_PA.Desconectar_DB();
        }

        public void Mensagem1()
        {
            MessageBox.Show("A pesquisa dos campos em branco retorna todas as informacoes da tabela\n");
        }
        public void Mensagem2()
        {
            MessageBox.Show("Nao foi encontrado nenhum registro com os dados informados.\n");
        }
        public void Mensagem3()
        {
            MessageBox.Show("Pesquisa realizada com sucesso!\n");
        }
        public void Mensagem4(string erromsg)
        {
            MessageBox.Show("Ocorreu um erro ao tentar efetuar a pesquisa\n\n" + erromsg);
        }
        public void Mensagem5()
        {
            MessageBox.Show("A pesquisa irá efetuar a busca pelo código OU pelo nome.\n");
        }
    }
    #endregion

}