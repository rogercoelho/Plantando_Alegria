﻿using Microsoft.Win32;
using MySql.Data.MySqlClient;
using Plantando_Alegria.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Plantando_Alegria.MysqlDb
{
    public class DB_PA
    {
        #region Variaveis da tabela Alunos_Cadastro.

        public static string Alunos_Codigo;
        public static string Alunos_Nome;
        public static string Alunos_Endereco;
        public static string Alunos_Bairro;
        public static string Alunos_Cidade;
        public static string Alunos_CEP;
        public static string Alunos_Telefone;
        public static string Alunos_Email;
        public static string Alunos_Contato_Emergencia;
        public static string Alunos_Telefone_Emergencia_1;
        public static string Alunos_Telefone_Emergencia_2;
        public static string Criado_Em;
        public static string Atualizado_Em;

        #endregion

        #region Variaveis Operacionais

        public static string caminho_foto_aluno;
        public static bool e_cadastro;                                  // Variavel que identifica se é um novo cadastro ou atualizacao.
        public static bool dados_alterados;                             // variavel que identifica se tem alteracoes nos dados da ficha do aluno.
        public static bool foto_alterada;                               // variavel que identifica se tem alteracoes na foto do aluno.
        public static bool pesquisa_codigo;                             // variavel que identifica que a pesquisa foi feita pelo codigo para jogar direto para selecao2
        public static int contador;                                     // Variavel para mostrar mensagem mensagem 1 ou 2.
        public static string Cad_Ok;                                    // string para a limpeza do textbox e mostrar o checklistbox.
        public string query;                                            // variavel que recebe a query do banco.
        public static byte[] imagem_byte;                               // variavel que retorna em bytes a imagem.
        MySqlDataReader dataReader;                                     // variavel que armazena a leitura do banco.

        #endregion

        #region Instanciando Objetos.
        //comunica com o form cadastro de alunos e ficha de alunos
        Encerramento encerramento = new Encerramento();                 // instanciando objeto para a classe encerramento.
        public List<object> lista = new List<object>();                 // Instanciando objeto da classe List. Vai receber o datareader em uma lista
        Conexao_Banco_PA conexao_Banco_PA = new Conexao_Banco_PA();     // Instanciando objeto da classe conexao_banco_PA. Para conectar e desconectar do banco.
        MySqlCommand cmd = new MySqlCommand();                          // Instanciando objeto da classe MysqlCommand. Para executar comandos Mysql.
        #endregion

        #region Metodos de Query do banco.

        #region Metodo Query para Cadastrar Aluno.

        public void Query_Cadastrar_Aluno()
        {
            cmd.Parameters.Clear();             // faz a limpeza dos parametros antes de incluir novos.

            query = "INSERT INTO Alunos_Cadastro VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_Endereco, @Alunos_Bairro," +
                                                        "@Alunos_Cidade, @Alunos_CEP, @Alunos_Telefone, @Alunos_Email," +
                                                        "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                        "@Alunos_Telefone_Emergencia_2, @Criado_Em, @Atualizado_Em)";
            cmd.CommandText = query;
            e_cadastro = true;
            Cadastrar_Atualizar_Alunos_Cadastro();

        }
        #endregion

        #region Metodo Query para Atualizar Aluno.
        public void Query_Atualizar_Cadastro()
        {
            query = "UPDATE Alunos_Cadastro SET Alunos_Nome = @Alunos_Nome, Alunos_Endereco = @Alunos_Endereco, Alunos_Bairro = @Alunos_Bairro," +
                                                      " Alunos_Cidade = @Alunos_Cidade, Alunos_CEP = @Alunos_CEP, " +
                                                      " Alunos_Telefone = @Alunos_Telefone, Alunos_Email = Alunos_Email, " +
                                                      " Alunos_Contato_Emergencia = @Alunos_Contato_Emergencia, " +
                                                      " Alunos_Telefone_Emergencia_1 = @Alunos_Telefone_Emergencia_1," +
                                                      " Alunos_telefone_Emergencia_2 = @Alunos_Telefone_Emergencia_2, Atualizado_Em = @Atualizado_em" +
                                                      " WHERE Alunos_Codigo =" + Alunos_Codigo;
            cmd.CommandText = query;
            e_cadastro = false;
            Cadastrar_Atualizar_Alunos_Cadastro();

        }

        #endregion

        #region Metodo Query Para Inserir imagem_Aluno REVISADO.

        public void Query_Inserir_Imagem()
        {
            query = "INSERT INTO Alunos_Imagem VALUES (@Alunos_Codigo, @Imagem, @Criado_Em, @Atualizado_Em)";   // variavel recebe query do banco.      
            Processa_Imagem();      // chama o metodo Processa banco.

        }

        #endregion

        #region Metodo Query Para Alterar imagem_Aluno.

        public void Query_Alterar_Imagem()
        {
            cmd.Parameters.Clear();                
            query = "UPDATE Alunos_Imagem SET Imagem = @Imagem, Atualizado_Em = @Atualizado_Em WHERE Alunos_Codigo =" + Alunos_Codigo;  // variavel recebe query do banco.

            cmd.Parameters.Add("@Atualizado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;

            Processa_Imagem();  // chama o metodo processa banco.
        }

        #endregion

        #region Metodo Query para pesquisar tudo da tabela REVISADO.

        public void Pesquisar_Tudo_tbl_alunos_cadastro()
        {
            query = "SELECT * from Alunos_Cadastro";    // Consulta do banco de dados Mysql.         
            cmd.CommandText = query;                     // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco
        }

        #endregion
        
        #region Metodo Query para pesquisar pelo nome do aluno REVISADO.

        public void Pesquisar_Pelo_Nome_tbl_alunos_cadastro()
        {
            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Nome LIKE '" + Alunos_Nome + "'";    // query do mysql + o que esta escrito no label.       
            cmd.CommandText = query;                                                                // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco.
            cmd.Parameters.AddWithValue("@Alunos_Nome", Alunos_Nome);                                       // Adiciona um parametro para acrescentar os valores encontrados
        }

        #endregion

        #region Metodo Query para pesquisar pelo codigo do aluno REVISADO.

        public void Pesquisar_pelo_Codigo_tbl_alunos_cadastro()
        {
            pesquisa_codigo = true;
            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo =" + Alunos_Codigo;      // variavel que recebe o comando para executar no mysql + o que esta escrito no label.
            cmd.CommandText = query;                                                        // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco.
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;      // Adiciona um parametro para acrescentar os valores encontrados.

        }

        #endregion

        #region Metodo Query para pesquisar pelo nome ou pelo codigo REVISADO.

        public void Pesquisar_pelo_Nome_Codigo_tbl_alunos_cadastro()
        {

            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo="     // variavel que recebe o comando para executar no mysql + o que esta escrito em ambos os labels.
                     + Alunos_Codigo
                     + " OR Alunos_Nome LIKE" +
                     " '" + Alunos_Nome + "'";

            cmd.CommandText = query;                                        // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco.
            cmd.Parameters.AddWithValue("@Alunos_codigo", Alunos_Codigo);            // Adiciona um parametro para acrescentar os valores encontrados.
            cmd.Parameters.AddWithValue("@Alunos_Nome", Alunos_Nome);          // Adiciona um parametro para acrescentar os valores encontrados.
        }

        #endregion

        #region Metodo Query para pesquisar pela imagem na tabela Alunos_imagem.

        public void Pesquisar_Imagem()
        {
            cmd.Parameters.Clear(); // INSERIDO AGORA.
            cmd.Connection = conexao_Banco_PA.Conectar_DB();                                    // Conecta no banco
            query = "SELECT Imagem FROM Alunos_Imagem WHERE Alunos_Codigo =" + Alunos_Codigo;   // Query que sera executada no banco.
            cmd.CommandText = query;                                                            // Mysql Command recebe a query.
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;                       // recebe o parametro codigo do aluno.
            
            Executa_Pesquisa_Imagem();                                                          // Acessa o metodo Executa_pesquisa.
        }

        #endregion

        #endregion

        #region Metodo que cadastra ou atualiza o cadastro na tabela Alunos_Cadastro REVISADO    

        public void Cadastrar_Atualizar_Alunos_Cadastro()
        {
            cmd.Parameters.Clear();

            if (e_cadastro == true)
            {
                cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;
                cmd.Parameters.Add("@Criado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;
                cmd.Parameters.Add("Atualizado_Em", MySqlDbType.Timestamp).Value = null;
            }
            else
            {
                cmd.Parameters.Add("@Atualizado_em", MySqlDbType.Timestamp).Value = DateTime.Now;
            }
            cmd.Parameters.Add("Alunos_Nome", MySqlDbType.VarChar).Value = Alunos_Nome;                                 // Adiciona na coluna da query
            cmd.Parameters.Add("@Alunos_Telefone", MySqlDbType.VarChar).Value = Alunos_Telefone;                          // O tipo da coluna (Varchar)
            cmd.Parameters.Add("@Alunos_Email", MySqlDbType.VarChar).Value = Alunos_Email;                                // Recebe o valor de
            cmd.Parameters.Add("@Alunos_Endereco", MySqlDbType.VarChar).Value = Alunos_Endereco;                          // alunos_cadastro_mysql.
            cmd.Parameters.Add("@Alunos_Bairro", MySqlDbType.VarChar).Value = Alunos_Bairro;                              // Alunos_Bairro (nesse caso
            cmd.Parameters.Add("@Alunos_Cidade", MySqlDbType.VarChar).Value = Alunos_Cidade;
            cmd.Parameters.Add("@Alunos_CEP", MySqlDbType.VarChar).Value = Alunos_CEP;
            cmd.Parameters.Add("@Alunos_Contato_Emergencia", MySqlDbType.VarChar).Value = Alunos_Contato_Emergencia;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_1", MySqlDbType.VarChar).Value = Alunos_Telefone_Emergencia_1;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_2", MySqlDbType.VarChar).Value = Alunos_Telefone_Emergencia_2;


            Executa_Banco();
        }

        #endregion
        
        #region Metodo que cadastra ou atualiza a imagem na tabela Alunos_Imagem.
        public void Processa_Imagem()
        {  
            if (Cad_Ok == "OK")                                                     // Aqui pergunta se as informacoes do aluno foram cadastradas primeiro.
                                                                                    // Se a resposta for OK ai sim insere a imagem no banco.
            {
                    FileStream arquivo_imagem = new FileStream(caminho_foto_aluno, FileMode.Open, FileAccess.Read);     // Aqui utiliza o filestream para tratar a foto.
                    BinaryReader binary_reader = new BinaryReader(arquivo_imagem);                                                  // Como o banco nao recebe imagem e sim dados

                    imagem_byte = binary_reader.ReadBytes((int)arquivo_imagem.Length);  // variavel imagem_byte recebe o conteudo do arquivo_imagem depois de ser "lido"pelo binary reader.


                    cmd.Parameters.Add("@Imagem", MySqlDbType.LongBlob).Value = imagem_byte;                // O tipo da coluna (longblob) Recebe o valor de alunos_imagem_mysql.
                    cmd.CommandText = query;
                    Executa_Banco();
            }

        }
        #endregion

        #region Metodo de execucao de conexao e atualizacao do Banco REVISADO.

        public void Executa_Banco()
        {
            try
            {
                cmd.Connection = conexao_Banco_PA.Conectar_DB();        // Tenta fazer a conexao com o Banco chamando o metodo Conectar_DB da classe Conexao_Banco_PA
                cmd.ExecuteNonQuery();                                  // Comando que excuta a Query.
                conexao_Banco_PA.Desconectar_DB();

                Cad_Ok = "OK";                                    // Passa o valor OK para a variavel Cad_OK.
            }
            catch (MySqlException errodb)       // Caso dê erro, mostra o erro do banco de dados.
            {
                MessageBox.Show("Erro ao Efetuar Cadastro.\n" + errodb.Message, "Plantando Alegria - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DB_PA.Cad_Ok = "Erro";                                  // Passa o valor Erro para a variavel Cad_OK.    
            }

            conexao_Banco_PA.Desconectar_DB();  // Chama o metodo Desconectar_DB da classe Conexao_Banco_Pa. (Desconecta do banco

            if (DB_PA.e_cadastro == true)
            {
                DB_PA.e_cadastro = false;
                Query_Inserir_Imagem();
            }
        }

        #endregion

        #region Metodo que executa a pesquisa do cadastro na tabela Alunos_Cadastro.

        public void Executa_Pesquisa()
        {
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
                    encerramento.Mensagem_02();

                    DB_PA.Cad_Ok = "Erro";

                }
                #endregion

                #region Retorna a pesquisa com valores encontrados.

                else                                                // Caso possua dados na tabela do Banco faz a tratativa.
                {
                                                                    // Pega do datareader e tranfere para a lista


                    while (dataReader.Read())                       // Enquanto o datareader estiver recebendo dados.
                    {

                        lista.Add(string.Join(null, "Cod. | ", dataReader[0].ToString() + " | ",
                                                   "  Nome | ", dataReader[1].ToString() + " | ",
                                                   "  Endereço | ", dataReader[2].ToString() + " | ",
                                                   "  Bairro | ", dataReader[3].ToString() + " | ",
                                                   "  Cidade | ", dataReader[4].ToString() + " | ",
                                                   "  CEP | ", dataReader[5].ToString() + " | ",
                                                   "  Tel. | ", dataReader[6].ToString() + " | ",
                                                   "  Email | ", dataReader[7].ToString() + " | ",
                                                   "  Contato Emergencia | ", dataReader[8].ToString() + " | ",
                                                   "  Telefone Emergencia_1 | ", dataReader[9].ToString() + " | ",
                                                   "  Telefone Emergencia_2 | ", dataReader[10].ToString() + " | ",
                                                   "  Cadastro Criado Em | ", dataReader[11].ToString() + " | ",
                                                   "  Cadastro Atualizado Em | ", dataReader[12].ToString() + " | "));     // Acrescenta na variavel lista o valor do datareader.
                    }    
                
                    Cad_Ok = "OK";     // Variavel Cad_OK recebe ok para listar no checklistbox.

                    if (pesquisa_codigo == true)
                    {
                        frm_ficha_alunos.selecao = (string)lista[0];
                    }

                }
                #endregion

                #region  Encerra o datareader se estiver aberto ainda.
                if (!dataReader.IsClosed)
                {
                    dataReader.Close();
                }
                #endregion
            }
            catch (MySqlException erro_db)                          // Caso nao consiga executar os comandos do Try retorna o Catch com o erro do banco.
            {
                encerramento.Mensagem_04("-->" + erro_db.Message);
            }    
            conexao_Banco_PA.Desconectar_DB();
            
            #endregion
        }

        #endregion

        #region Metodo que executa a pesquisa da imagem na tabela Alunos_imagem.
        public void Executa_Pesquisa_Imagem()
        {
            try
            {
                dataReader = cmd.ExecuteReader();           // Executa o datareader

                if (dataReader.HasRows)                     // Se tiver retorno de resultado.
                {
                    dataReader.Read();                      // Faz a leitura do datareader.
                    imagem_byte = (byte[])dataReader[0];    // imagem byte recebe o array de bytes do datareader.

                }
            }

            catch (MySqlException erro_db)
            {
                encerramento.Mensagem_04("-->" + erro_db.Message);
            }
            if (!dataReader.IsClosed)                       // Se o datareader estiver aberto.
            {
                dataReader.Close();                         // Encerra o datareader.
                conexao_Banco_PA.Desconectar_DB();          // Desconecta do banco.

            }

        }
        #endregion


        public void Compara_Ficha()
        {
            dados_alterados = false;

            if ( caminho_foto_aluno == null )
            {
                foto_alterada = false;
            }


            if (frm_ficha_alunos.selecao2[3].ToString().Trim() == Alunos_Nome.ToString().Trim())
            {
                if (frm_ficha_alunos.selecao2[5].ToString().Trim() == Alunos_Endereco.ToString().Trim())
                {
                    if (frm_ficha_alunos.selecao2[7].ToString().Trim() == Alunos_Bairro.ToString().Trim())
                    {
                        if (frm_ficha_alunos.selecao2[9].ToString().Trim() == Alunos_Cidade.ToString().Trim())
                        {
                            if (frm_ficha_alunos.selecao2[11].ToString().Trim() == Alunos_CEP.ToString().Trim())
                            {
                                if (frm_ficha_alunos.selecao2[13].ToString().Trim() == Alunos_Telefone.ToString().Trim())
                                {
                                    if (frm_ficha_alunos.selecao2[15].ToString().Trim() == Alunos_Email.ToString().Trim())
                                    {
                                        if (frm_ficha_alunos.selecao2[17].ToString().Trim() == Alunos_Contato_Emergencia.ToString().Trim())
                                        {
                                            if (frm_ficha_alunos.selecao2[19].ToString().Trim() == Alunos_Telefone_Emergencia_1.ToString().Trim())
                                            {
                                                if (frm_ficha_alunos.selecao2[21].ToString().Trim() == Alunos_Telefone_Emergencia_2.ToString().Trim())
                                                {

                                                }
                                                else { dados_alterados = true; }
                                            }
                                            else { dados_alterados = true; }
                                        }
                                        else { dados_alterados = true; }
                                    }
                                    else { dados_alterados = true; }
                                }
                                else { dados_alterados = true; }
                            }
                            else { dados_alterados = true; }
                        }
                        else { dados_alterados = true; }
                    }
                    else { dados_alterados = true; }
                }
                else { dados_alterados = true; }
            }
            else { dados_alterados = true; }

            if (foto_alterada == true && dados_alterados == true)
            {
                Query_Alterar_Imagem();
                Query_Atualizar_Cadastro();
                encerramento.Mensagem_10();
            }
            else if (foto_alterada == false && dados_alterados == true)
            {
                Query_Atualizar_Cadastro();
                encerramento.Mensagem_08();
            }
            else if (foto_alterada == true && dados_alterados == false)
            {
                Query_Alterar_Imagem();
                encerramento.Mensagem_10();
            }
            else
            {
                encerramento.Mensagem_07();
            }
        }





        #region Classe de Mensagens de tela.
        public class Encerramento
        {
            public void Mensagem_01()
            {
                MessageBox.Show("*** ATENÇÃO *** \n" +
                                "A pesquisa dos campos em branco retorna todas as informações da tabela.\n" +
                                "Esta pesquisa pode demorar muito ou até travar, dependendo da quantidade de informações!",
                                "Plantando Alegria - *** ATENÇÃO ***", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            public void Mensagem_02()
            {
                MessageBox.Show("Não foi encontrado nenhum registro com os dados informados.\n",
                                "Plantando Alegria - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_03()
            {
                MessageBox.Show("Pesquisa realizada com sucesso!\n",
                                "Plantando Alegria - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_04(string erromsg)
            {
                MessageBox.Show("Ocorreu um erro ao tentar efetuar a pesquisa.\n" + erromsg,
                                "Plantando Alegria - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_05()
            {
                MessageBox.Show("A pesquisa irá efetuar a busca pelo código OU pelo nome do aluno.\n",
                                "Plantando Alegria - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_06()
            {
                MessageBox.Show("A imagem foi salva com sucesso.\n" +
                                "Cadastro do Aluno finalizado.\n", "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_07()
            {
                MessageBox.Show("Nao houve alterações na ficha do aluno.\n" +
                                "Não existe nada para salvar!.\n", "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_08()
            {
                MessageBox.Show("Os dados da ficha do aluno foram atualizados com sucesso.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_09()
            {
                MessageBox.Show("A foto do aluno foi atualizada com sucesso.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_10()
            {
                MessageBox.Show("Os dados e a foto do aluno foram atualizados com sucesso.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_11()
            {
                MessageBox.Show("Aluno cadastrado com sucesso..\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion








        #region Metodos comentados que serao usados depois.
        //public static void Atualizar_Cadastro (Alunos_Cadastro_mysql alunos_cadastro, string id)
        //{
        //    //string sql_sintaxe = "Insert into Cadastro_Alunos (Aluno_Codigo, Aluno_Nome, Aluno_Telefone, Aluno_Email," +    // Str_sql recebe a sintaxe do banco mysql.
        //    //                                       "Aluno_Endereco, Aluno_Bairro, Aluno_Cidade, Aluno_CEP," +               // Str_sql recebe a sintaxe do banco mysql.
        //    //                                       "Aluno_Contato_Emergencia, Aluno_Telefone_Emergencia_1," +               // Str_sql recebe a sintaxe do banco mysql.
        //    //                                       "Aluno_Telefone_Emergencia_2) Values(?,?,?,?,?,?,?,?,?,?,?)";            // Str_sql recebe a sintaxe do banco mysql.

        //string sql_sintaxe = "UPDATE Alunos_Cadastro SET Alunos_Nome = @Alunos_Nome, Alunos_Endereco =@Alunos_Endereco, Alunos_Bairro = @Alunos_Bairro," +
        //                                               " Alunos_Cidade = @Alunos_Cidade, Alunos_CEP = @Alunos_CEP, " +
        //                                               " Alunos_Contato_Emergencia = @Alunos_Contato_Emergencia, " +
        //                                               " Alunos_Telefone_Emergencia_1 = @Alunos_Telefone_Emergencia_1," +
        //                                               " Alunos_telefone_Emergencia_2 = @Alunos_Telefone_Emergencia_2" +
        //                                               " WHERE Alunos_Codigo = @Alunos_Codigo";

        //    MySqlConnection mysql_db = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql_sintaxe, mysql_db);
        //    cmd.CommandType = CommandType.Text;

        //    cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int64).Value = alunos_cadastro.Alunos_Codigo;
        //    cmd.Parameters.Add("@Alunos_Nome", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_Nome;
        //    cmd.Parameters.Add("@Alunos_Telefone", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_Telefone;
        //    cmd.Parameters.Add("@Alunos_Email", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_Email;
        //    cmd.Parameters.Add("@Alunos_Endereco", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_Endereco;
        //    cmd.Parameters.Add("@Alunos_Bairro", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_Bairro;
        //    cmd.Parameters.Add("@Alunos_Cidade", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_Cidade;
        //    cmd.Parameters.Add("@Alunos_CEP", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_CEP;
        //    cmd.Parameters.Add("@Alunos_Contato_Emergencia", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_Contato_Emergencia;
        //    cmd.Parameters.Add("@Alunos_Telefone_Emergencia_1", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_Telefone_Emergencia_1;
        //    cmd.Parameters.Add("@Alunos_Telefone_Emergencia_2", MySqlDbType.VarChar).Value = alunos_cadastro.Alunos_Telefone_Emergencia_2;

        //    try
        //    {
        //        cmd.ExecuteNonQuery();

        //        MessageBox.Show("Cadastro Atualizado com Sucesso\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //    catch (MySqlException errodb)
        //    {
        //        MessageBox.Show("Erro ao Atualizar Cadastro.\n" + errodb.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    mysql_db.Close();
        //}
        #endregion
    }
}