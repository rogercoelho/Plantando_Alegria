using MySql.Data.MySqlClient;
using Plantando_Alegria.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace Plantando_Alegria.MysqlDb
{
    public class DB_PA
    {

        #region Declaracao de objetos e variaveis para comunicar forms.
        //comunica com o form cadastro de alunos e ficha de alunos
        public static string Cad_Ok;                                    // string para a limpeza do textbox e mostrar o checklistbox.
        public string query;                                            // variavel que recebe a query do banco.
        public static string Cod_Aluno;                                 // variavel que recebe o codigo do aluno do textbox.
        public static string Nome_Aluno;                                // variavel que recebe o nome do aluno do textbox.
        public List<object> lista = new List<object>();                 // Instanciando objeto da classe List. Vai receber o datareader em uma lista
        Conexao_Banco_PA conexao_Banco_PA = new Conexao_Banco_PA();     // Instanciando objeto da classe conexao_banco_PA. Para conectar e desconectar do banco.
        MySqlCommand cmd = new MySqlCommand();                          // Instanciando objeto da classe MysqlCommand. Para executar comandos Mysql.
        MySqlDataReader dataReader;                                     // variavel que armazena a leitura do banco.
        public static byte[] imagem_byte;                               // variavel que retorna em bytes a imagem.
        #endregion

        
        #region Metodos de query do banco.
       
        #region metodo para cadastrar Aluno

        public void Cadastrar_Aluno()
        {
            query = "INSERT INTO Alunos_Cadastro VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_Telefone, @Alunos_Email," +
                                                                    "@Alunos_Endereco, @Alunos_Bairro, @Alunos_Cidade, @Alunos_CEP," +
                                                                    "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                                    "@Alunos_Telefone_Emergencia_2, @Criado_Em, Atualizado_Em)";
            cmd.CommandText = query;

            

        }
        #endregion

        #region Metodo para atualizar o cadastro do aluno.

        public void Atualizar_Cadastro()
        {
            query = "UPDATE Alunos_Cadastro SET Alunos_Nome = @Alunos_Nome, Alunos_Endereco =@Alunos_Endereco, Alunos_Bairro = @Alunos_Bairro," +
                                                       " Alunos_Cidade = @Alunos_Cidade, Alunos_CEP = @Alunos_CEP, " +
                                                       " Alunos_Contato_Emergencia = @Alunos_Contato_Emergencia, " +
                                                       " Alunos_Telefone_Emergencia_1 = @Alunos_Telefone_Emergencia_1," +
                                                       " Alunos_telefone_Emergencia_2 = @Alunos_Telefone_Emergencia_2, Atualizado_Em = @Atualizado_em" +
                                                       " WHERE Alunos_Codigo =" + Cod_Aluno;
            cmd.CommandText = query;
        }

        #endregion

        #region Metodo de pesquisar tudo da tabela.

        public void Pesquisar_Tudo_tbl_alunos_cadastro()
        {    
            query = "SELECT * from Alunos_Cadastro";    // Consulta do banco de dados Mysql.         
            cmd.CommandText = query;                     // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco
        }

        #endregion

        #region Metodo de pesquisar pelo nome do aluno.

        public void Pesquisar_Pelo_Nome_tbl_alunos_cadastro()
        {
            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Nome LIKE '" + Nome_Aluno + "'";    // query do mysql + o que esta escrito no label.       
            cmd.CommandText = query;                                                                // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco.
            cmd.Parameters.AddWithValue("@Alunos_Nome", Nome_Aluno);                                       // Adiciona um parametro para acrescentar os valores encontrados
        }

        #endregion

        #region Metodo de pesquisar pelo codigo do aluno.

        public void Pesquisar_pelo_Codigo_tbl_alunos_cadastro()
        {    
            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo =" + Cod_Aluno;      // variavel que recebe o comando para executar no mysql + o que esta escrito no label.
            cmd.CommandText = query;                                                        // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco.
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Cod_Aluno;      // Adiciona um parametro para acrescentar os valores encontrados.

        }

        #endregion

        #region Metodo de pesquisar pelo nome ou pelo codigo.

        public void Pesquisar_pelo_Nome_Codigo_tbl_alunos_cadastro()
        {
               
            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo="     // variavel que recebe o comando para executar no mysql + o que esta escrito em ambos os labels.
                     + Cod_Aluno 
                     + " OR Alunos_Nome LIKE" +
                     " '" + Nome_Aluno + "'";

                cmd.CommandText = query;                                        // Sintaxe do CommandText recebe a variavel str_sql que recebe a informacao de consulta no banco.
                cmd.Parameters.AddWithValue("@Alunos_codigo", Cod_Aluno);            // Adiciona um parametro para acrescentar os valores encontrados.
                cmd.Parameters.AddWithValue("@Alunos_Nome", Nome_Aluno);          // Adiciona um parametro para acrescentar os valores encontrados.
        }

        #endregion

        #region Metodo de pesquisa na tabela Alunos_imagem.

        public void Pesquisar_Imagem()
        {
            cmd.Connection = conexao_Banco_PA.Conectar_DB();                                // Conecta no banco
            query = "select Imagem from Alunos_Imagem where Alunos_Codigo =" + Cod_Aluno;   // Query que sera executada no banco.
            cmd.CommandText = query;                                                        // Mysql Command recebe a query.
            cmd.Parameters.AddWithValue("@Alunos_Codigo", Cod_Aluno);                       // recebe o parametro codigo do aluno.
            Executa_Pesquisa_Imagem();                                                              // Acessa o metodo Executa_pesquisa.
        }

        #endregion

        #endregion

        #region Metodo de execucao da pesquisa do cadastro.

        public void Executa_Pesquisa()
        {
            Encerramento encerramento = new Encerramento();         // instanciando objeto para a classe encerramento.

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
                
                    DB_PA.Cad_Ok = "Erro";
                    
                }
                #endregion

                #region Retorna a pesquisa com valores encontrados.

                else                                                // Caso possua dados na tabela do Banco faz a tratativa.
                {
                    #region Pega do datareader e tranfere para a lista


                    while (dataReader.Read())                       // Enquanto o datareader estiver recebendo dados.
                    {    

                    lista.Add(string.Join(null , "Cod. | ", dataReader[0].ToString() + " | ",
                                               "  Nome | ", dataReader[1].ToString() + " | ",
                                               "  Tel. | ", dataReader[2].ToString() + " | ",
                                               "  Email | ",  dataReader[3].ToString() + " | ",
                                               "  Endereço | ", dataReader[4].ToString() + " | ",
                                               "  Bairro | ", dataReader[5].ToString() + " | ",
                                               "  Cidade | ", dataReader[6].ToString() + " | ",
                                               "  CEP | ", dataReader[7].ToString() + " | ",
                                               "  Contato Emergencia | ", dataReader[8].ToString() + " | ",
                                               "  Telefone Emergencia_1 | ", dataReader[9].ToString() + " | ",
                                               "  Telefone Emergencia_2 | ",  dataReader[10].ToString() + " | ",
                                               "  Cadastro Criado Em | ", dataReader[11].ToString() + " | ",
                                               "  Cadastro Atualizado Em | ", dataReader[12].ToString() + " | "));     // Acrescenta na variavel lista o valor do datareader.
                    }
                    #endregion
                    
                    Cad_Ok = "OK";     // Variavel Cad_OK recebe ok para listar no checklistbox.

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

        #region Metodo de execucao da pesquisa da imagem.
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

            catch (MySqlException errodb)
            {
                MessageBox.Show("Erro no banco de dados" + errodb);
            }
            if (!dataReader.IsClosed)                       // Se o datareader estiver aberto.
            {
                dataReader.Close();                         // Encerra o datareader.
                conexao_Banco_PA.Desconectar_DB();          // Desconecta do banco.
                  
            }

        }
        #endregion

        #region Metodo de execucao de Cadastro de Alunos.
        public void Cadastra_Atualiza_Aluno(Alunos_Cadastro_mysql alunos_cadastro_mysql)   // Metodo que recebe 2 valores.
        {            
                        

            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value =  alunos_cadastro_mysql.Alunos_Codigo;                               // Parametros do Banco que
            cmd.Parameters.Add("@Alunos_Nome", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_Nome;                                  // Adiciona na coluna da query
            cmd.Parameters.Add("@Alunos_Telefone", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_Telefone;                          // O tipo da coluna (Varchar)
            cmd.Parameters.Add("@Alunos_Email", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_Email;                                // Recebe o valor de
            cmd.Parameters.Add("@Alunos_Endereco", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_Endereco;                          // alunos_cadastro_mysql.
            cmd.Parameters.Add("@Alunos_Bairro", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_Bairro;                              // Alunos_Bairro (nesse caso
            cmd.Parameters.Add("@Alunos_Cidade", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_Cidade;
            cmd.Parameters.Add("@Alunos_CEP", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_CEP;
            cmd.Parameters.Add("@Alunos_Contato_Emergencia", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_Contato_Emergencia;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_1", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_Telefone_Emergencia_1;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_2", MySqlDbType.VarChar).Value = alunos_cadastro_mysql.Alunos_Telefone_Emergencia_2;
            cmd.Parameters.Add("@Criado_Em",MySqlDbType.Timestamp).Value = DateTime.Now;
            cmd.Parameters.Add("@Atualizado_em", MySqlDbType.Timestamp).Value = DateTime.Now;

            try
            {
                cmd.Connection = conexao_Banco_PA.Conectar_DB();        // Tenta fazer a conexao com o Banco chamando o metodo Conectar_DB da classe Conexao_Banco_PA
                cmd.ExecuteNonQuery();                                  // Comando que excuta a Query.
                conexao_Banco_PA.Desconectar_DB();
                
                DB_PA.Cad_Ok = "OK";                                    // Passa o valor OK para a variavel Cad_OK.
                                
            }
            catch (MySqlException errodb)       // Caso dê erro, mostra o erro do banco de dados.
            {
                MessageBox.Show("Erro ao Efetuar Cadastro.\n" + errodb.Message, "Plantando Alegria - Erro",  MessageBoxButtons.OK, MessageBoxIcon.Error);

                DB_PA.Cad_Ok = "Erro";                                  // Passa o valor Erro para a variavel Cad_OK.
            }

            conexao_Banco_PA.Desconectar_DB();  // Chama o metodo Desconectar_DB da classe Conexao_Banco_Pa. (Desconecta do banco).

        }

        #endregion

        #region Metodo de inserir imagem do aluno

        public static void Inserir_Imagem(Alunos_Imagem_mysql alunos_Imagem_Mysql)  // Metdodo que recebe 2 valores.
        {

            if (Cad_Ok == "OK")                                                     // Aqui pergunta se as informacoes do aluno foram cadastradas primeiro.
                                                                                    // Se a resposta for OK ai sim insere a imagem no banco.
            {
                byte[] imagem_byte = null;                                          // Crio um array de byte e inicio como nulo.
                FileStream arquivo_imagem = new FileStream(frm_cadastro_alunos.foto_aluno, FileMode.Open, FileAccess.Read);     // Aqui utiliza o filestream para tratar a foto.
                BinaryReader binary_reader = new BinaryReader(arquivo_imagem);                                                  // Como o banco nao recebe imagem e sim dados
                                                                                                                                // Incanciando o objeto para a classe Binary reader 
                                                                                                                                // parecido com o datareader.

                imagem_byte = binary_reader.ReadBytes((int)arquivo_imagem.Length);  // variavel imagem_byte recebe o conteudo do arquivo_imagem depois de ser "lido"pelo binary reader.


                string query = "INSERT INTO Alunos_Imagem VALUES (@Alunos_Codigo, @Imagem, @Criado_Em)";  // variavel que recebe a query do banco.


                Conexao_Banco_PA Conexao_Banco_PA = new Conexao_Banco_PA();     // Instanciando objeto para a classe Conexao_Banco_PA.
                MySqlCommand cmd = new MySqlCommand();                          // Instanciando objeto para a classe MysqlCommand.
                cmd.CommandText = query;                                        // variavel com a query sendo repassada para dentro do MysqlCommand.

                cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = alunos_Imagem_Mysql.Alunos_Codigo;          // Parametros do Banco que Adiciona na coluna da query
                cmd.Parameters.Add("@Imagem", MySqlDbType.LongBlob).Value = imagem_byte;                 // O tipo da coluna (longblob) Recebe o valor de alunos_imagem_mysql.
                cmd.Parameters.Add("@Criado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;

                try
                {
                    cmd.Connection = Conexao_Banco_PA.Conectar_DB();    // Conecta no banco de dados
                    cmd.ExecuteNonQuery();                              // Executa query.
                    Conexao_Banco_PA.Desconectar_DB();                  // Desconecta do banco de dados.

                    MessageBox.Show("Cadastro Realizado com Sucesso\n", "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (MySqlException errodb)       // Caso de erro de conexao com o banco, retorna a mesaggem de erro.
                {
                    MessageBox.Show("Erro ao Inserir Imagem no Banco de Dados.\n" + errodb.Message, "Plantando Alegria - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Conexao_Banco_PA.Desconectar_DB();
            }
        }
        #endregion










        #region Metodos coentados que serao usados depois.
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
