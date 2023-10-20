using MySql.Data.MySqlClient;
using Plantando_Alegria.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Plantando_Alegria.MysqlDb
{
    public class DB_PA
    {
        #region Variaveis da tabela Alunos_Cadastro.

        public static string Alunos_Codigo;                     // Variavel que comunica com o textbox.
        public static string Alunos_Nome;                       // Variavel que comunica com o textbox.
        public static string Alunos_Endereco;                   // Variavel que comunica com o textbox.
        public static string Alunos_Bairro;                     // Variavel que comunica com o textbox.
        public static string Alunos_Cidade;                     // Variavel que comunica com o textbox.
        public static string Alunos_CEP;                        // Variavel que comunica com o textbox.
        public static string Alunos_Telefone;                   // Variavel que comunica com o textbox.
        public static string Alunos_Email;                      // Variavel que comunica com o textbox.
        public static string Alunos_Contato_Emergencia;         // Variavel que comunica com o textbox.
        public static string Alunos_Telefone_Emergencia_1;      // Variavel que comunica com o textbox.
        public static string Alunos_Telefone_Emergencia_2;      // Variavel que comunica com o textbox.
        public static string Criado_Em;                         // Variavel que tecebe a data do cadastro.
        public static string Atualizado_Em;                     // Variavel que atualiza a data do cadastro.

        #endregion

        #region Variaveis da tabela Planos_Cadastro.

        public static string planos_codigo;                 // Variavel que comunica com o textbox.
        public static string planos_nome;                   // Variavel que comunica com o textbox.
        public static string planos_qtd_aulas_semana;       // Variavel que comunica com o textbox.
        public static string planos_qtd_aulas_total;        // Variavel que comunica com o textbox.
        public static string planos_valor_mensal;           // Variavel que comunica com o textbox.
        public static string planos_valor_total;            // Variavel que comunica com o textbox.

        #endregion

        #region Variaveis Operacionais

        public static string caminho_foto_aluno;                        // Variavel que armazena o caminho da foto do aluno.
        public static bool campos_validados;                            // Variavel que valida se os campos do cadastro do aluno estao certos.
        public static bool e_cadastro;                                  // Variavel que identifica se é um novo cadastro ou atualizacao.
        public static bool dados_alterados;                             // variavel que identifica se tem alteracoes nos dados da ficha do aluno.
        public static bool foto_alterada;                               // variavel que identifica se tem alteracoes na foto da ficha do aluno.
        public static bool pesquisa_codigo = false;                     // variavel que identifica que a pesquisa foi feita pelo codigo para jogar direto para selecao2.
        public static string Cad_Ok;                                    // Variavel para a limpeza do textbox e mostrar o checklistbox.
        public string query;                                            // variavel que recebe a query do banco.
        public static byte[] imagem_byte;                               // variavel que retorna em bytes a imagem.
        MySqlDataReader dataReader;                                     // variavel que armazena a leitura do banco.

        #endregion

        #region Instanciando Objetos.
                                                                        // Comunica com os forms.
        Encerramento encerramento = new Encerramento();                 // Instanciando objeto para a classe encerramento.
        public List<object> lista = new List<object>();                 // Instanciando objeto da classe List. Vai receber o datareader em uma lista
        Conexao_Banco_PA conexao_Banco_PA = new Conexao_Banco_PA();     // Instanciando objeto da classe conexao_banco_PA. Para conectar e desconectar do banco.
        MySqlCommand cmd = new MySqlCommand();                          // Instanciando objeto da classe MysqlCommand. Para executar comandos Mysql.
        #endregion

        #region Metodos de Query do banco.

        #region Tabela Alunos_Cadastro.

        #region Metodo Query para Cadastrar Aluno na tabela Alunos_Cadastro.

        public void Query_Cadastrar_Aluno()
        {
            cmd.Parameters.Clear();         // Faz a limpeza dos parametros antes de incluir novos.

            query = "INSERT INTO Alunos_Cadastro VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_Endereco, @Alunos_Bairro," +  // Variavel ira receber a query.
                                                        "@Alunos_Cidade, @Alunos_CEP, @Alunos_Telefone, @Alunos_Email," +
                                                        "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                        "@Alunos_Telefone_Emergencia_2, @Criado_Em, @Atualizado_Em)";
            cmd.CommandText = query;        // Repassa a variavel query para os comandos do mysql.
            e_cadastro = true;              // Atribui true para a variavel e_cadastro. Identifica que é cadastro e nao atualizacao.
        }
        #endregion

        #region Metodo Query para Atualizar Aluno na tabela Alunos_Cadastro.
        public void Query_Atualizar_Cadastro()
        {
            query = "UPDATE Alunos_Cadastro SET Alunos_Nome = @Alunos_Nome, Alunos_Endereco = @Alunos_Endereco, Alunos_Bairro = @Alunos_Bairro," +      // Variavel ira receber a query.
                                                      " Alunos_Cidade = @Alunos_Cidade, Alunos_CEP = @Alunos_CEP, " +
                                                      " Alunos_Telefone = @Alunos_Telefone, Alunos_Email = Alunos_Email, " +
                                                      " Alunos_Contato_Emergencia = @Alunos_Contato_Emergencia, " +
                                                      " Alunos_Telefone_Emergencia_1 = @Alunos_Telefone_Emergencia_1," +
                                                      " Alunos_telefone_Emergencia_2 = @Alunos_Telefone_Emergencia_2, Atualizado_Em = @Atualizado_em" +
                                                      " WHERE Alunos_Codigo =" + Alunos_Codigo;
            cmd.CommandText = query;    // Repassa a variavel query para os comandos do mysql.
            e_cadastro = false;         // Atribui true para a variavel e_cadastro. Identifica que é cadastro e nao atualizacao.

        }

        #endregion

        #region Metodo Query para pesquisar tudo da tabela Alunos_Cadastro.

        public void Pesquisar_Tudo_tbl_alunos_cadastro()
        {
            query = "SELECT * from Alunos_Cadastro";    // Variavel ira receber a query.         
            cmd.CommandText = query;                    // Repassa a variavel query para os comandos do mysql.
        }

        #endregion

        #region Metodo Query para pesquisar pelo nome do aluno na tabela Alunos_Cadastro.

        public void Pesquisar_Pelo_Nome_tbl_alunos_cadastro()
        {
            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Nome LIKE '" + Alunos_Nome + "'";   // Variavel ira receber a query. + o que esta na variavel.       
            cmd.CommandText = query;                                                                // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.AddWithValue("@Alunos_Nome", Alunos_Nome);                               // Adiciona um parametro para acrescentar os valores encontrados
        }

        #endregion

        #region Metodo Query para pesquisar pelo codigo do aluno na tabela Alunos_Cadastro.

        public void Pesquisar_pelo_Codigo_tbl_alunos_cadastro()
        {
            cmd.Parameters.Clear();                                                             // Faz a limpeza dos parametros antes de incluir novos.
            pesquisa_codigo = true;                                                             // Atribui true a variavel pesquisa pelo codigo.
            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo =" + Alunos_Codigo;      // variavel que recebe o comando para executar no mysql + o que esta na variavel.
            cmd.CommandText = query;                                                            // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;      // Adiciona um parametro para acrescentar os valores encontrados.

        }

        #endregion
        
        #region Metodo Query para pesquisar pelo nome ou pelo codigo na tabela Alunos_Cadastro.

        public void Pesquisar_pelo_Nome_Codigo_tbl_alunos_cadastro()
        {
            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo="    // variavel que recebe o comando para executar no mysql + o que esta na variavel.
                     + Alunos_Codigo
                     + " OR Alunos_Nome LIKE" +
                     " '" + Alunos_Nome + "'";

            cmd.CommandText = query;                                        // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.AddWithValue("@Alunos_codigo", Alunos_Codigo);   // Adiciona um parametro para acrescentar os valores encontrados.
            cmd.Parameters.AddWithValue("@Alunos_Nome", Alunos_Nome);       // Adiciona um parametro para acrescentar os valores encontrados.
        }

        #endregion

        #endregion

        #region Tabela Alunos_Imagem

        #region Metodo Query Para Inserir imagem_Aluno na tabela Alunos_Imagem.

        public void Query_Inserir_Imagem()
        {
            query = "INSERT INTO Alunos_Imagem VALUES (@Alunos_Codigo, @Imagem, @Criado_Em, @Atualizado_Em)";   // variavel que recebe o comando para executar no mysql.      
        }

        #endregion

        #region Metodo Query Para Alterar imagem_Aluno na tabela Alunos_Imagem.

        public void Query_Alterar_Imagem()
        {
            cmd.Parameters.Clear();                                                             // Faz a limpeza dos parametros antes de incluir novos.     
            query = "UPDATE Alunos_Imagem SET Imagem = @Imagem, " +
                    "Atualizado_Em = @Atualizado_Em WHERE Alunos_Codigo =" + Alunos_Codigo;     // variavel recebe query do banco.

            cmd.Parameters.Add("@Atualizado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;   // Adiciona um parametro para acrescentar os valores encontrados.

        }

        #endregion

        #region Metodo Query para pesquisar pela imagem na tabela Alunos_imagem.

        public void Pesquisar_Imagem()
        {
            cmd.Parameters.Clear();                                                             // Faz a limpeza dos parametros antes de incluir novos.
            query = "SELECT Imagem FROM Alunos_Imagem WHERE Alunos_Codigo =" + Alunos_Codigo;   // variavel recebe query do banco.
            cmd.CommandText = query;                                                            // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;      // Adiciona um parametro para acrescentar os valores encontrados.

            Executa_Pesquisa_Imagem();                                                          // Chama o metodo Executa_pesquisa.
        }

        #endregion

        #endregion

        #endregion

        
        #region Metodo que limpa as variaveis DB_PA da tabela Alunos_Cadastro.

        public void Limpar_Variaveis()
        {
            Alunos_Codigo = "";                     // Atribui vazio na variavel.
            Alunos_Nome = "";                       // Atribui vazio na variavel.
            Alunos_Endereco = "";                   // Atribui vazio na variavel.
            Alunos_Bairro = "";                     // Atribui vazio na variavel.
            Alunos_Cidade = "";                     // Atribui vazio na variavel.
            Alunos_CEP = "";                        // Atribui vazio na variavel.
            Alunos_Telefone = "";                   // Atribui vazio na variavel.
            Alunos_Email = "";                      // Atribui vazio na variavel.
            Alunos_Contato_Emergencia = "";         // Atribui vazio na variavel.
            Alunos_Telefone_Emergencia_1 = "";      // Atribui vazio na variavel.
            Alunos_Telefone_Emergencia_2 = "";      // Atribui vazio na variavel.
            Criado_Em = "";                         // Atribui vazio na variavel.
            Atualizado_Em = "";                     // Atribui vazio na variavel.
        }

        #endregion

        #region Metodo que cadastra ou atualiza o cadastro na tabela Alunos_Cadastro.    

        public void Cadastrar_Atualizar_Alunos_Cadastro()
        {
            cmd.Parameters.Clear();                                                                                         // Faz a limpeza dos parametros antes de receber novos.

            if (e_cadastro == true)                                                                                         // Se for cadastro e nao atualizacao.
            {
                cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;                              // Adiciona o parametro para o cadastro.
                cmd.Parameters.Add("@Criado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;                               // Adiciona o parametro para o cadastro.
                cmd.Parameters.Add("Atualizado_Em", MySqlDbType.Timestamp).Value = null;                                    // Adiciona o parametro para o cadastro.
            }
            else
            {
                cmd.Parameters.Add("@Atualizado_em", MySqlDbType.Timestamp).Value = DateTime.Now;                           // Adiciona o parametro para a atualizacao do cadastro.
            }
            cmd.Parameters.Add("Alunos_Nome", MySqlDbType.VarChar).Value = Alunos_Nome;                                     // Adiciona o parametro tando para cadastro como atualizacao.
            cmd.Parameters.Add("@Alunos_Telefone", MySqlDbType.VarChar).Value = Alunos_Telefone;                            // Adiciona o parametro tando para cadastro como atualizacao.
            cmd.Parameters.Add("@Alunos_Email", MySqlDbType.VarChar).Value = Alunos_Email;                                  // Adiciona o parametro tando para cadastro como atualizacao.
            cmd.Parameters.Add("@Alunos_Endereco", MySqlDbType.VarChar).Value = Alunos_Endereco;                            // Adiciona o parametro tando para cadastro como atualizacao.
            cmd.Parameters.Add("@Alunos_Bairro", MySqlDbType.VarChar).Value = Alunos_Bairro;                                // Adiciona o parametro tando para cadastro como atualizacao.
            cmd.Parameters.Add("@Alunos_Cidade", MySqlDbType.VarChar).Value = Alunos_Cidade;                                // Adiciona o parametro tando para cadastro como atualizacao.
            cmd.Parameters.Add("@Alunos_CEP", MySqlDbType.VarChar).Value = Alunos_CEP;                                      // Adiciona o parametro tando para cadastro como atualizacao.
            cmd.Parameters.Add("@Alunos_Contato_Emergencia", MySqlDbType.VarChar).Value = Alunos_Contato_Emergencia;        // Adiciona o parametro tando para cadastro como atualizacao.
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_1", MySqlDbType.VarChar).Value = Alunos_Telefone_Emergencia_1;  // Adiciona o parametro tando para cadastro como atualizacao.
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_2", MySqlDbType.VarChar).Value = Alunos_Telefone_Emergencia_2;  // Adiciona o parametro tando para cadastro como atualizacao.
        }

        #endregion
        
        #region Metodo que cadastra ou atualiza a imagem na tabela Alunos_Imagem.
        public void Processa_Imagem()
        {
            if (Cad_Ok == "OK")                                                                                     // Aqui pergunta se as informacoes do aluno foram cadastradas primeiro.
                                                                                                                    // Se a resposta for OK ai sim insere a imagem no banco.
            {
                FileStream arquivo_imagem = new FileStream(caminho_foto_aluno, FileMode.Open, FileAccess.Read);     // Aqui utiliza o filestream para tratar a foto.  
                BinaryReader binary_reader = new BinaryReader(arquivo_imagem);                                      // Como o banco nao recebe imagem e sim dados    
                imagem_byte = binary_reader.ReadBytes((int)arquivo_imagem.Length);                                  // variavel imagem_byte recebe o conteudo do arquivo_imagem depois de ser
                                                                                                                    // "lido"pelo binary reader.

                cmd.Parameters.Add("@Imagem", MySqlDbType.LongBlob).Value = imagem_byte;                            // O tipo da coluna (longblob) Recebe o valor de alunos_imagem_mysql.
                cmd.CommandText = query;                                                                            // Repassa a variavel query para os comandos do mysql.
            }

        }
        #endregion
        
        #region Metodo que compara a ficha do aluno com a tabela Alunos_Cadastro.
        public void Compara_Ficha()
        {
            dados_alterados = false;                                                                // Atribui falso a variavel dados alterados primeiro.

            if ( caminho_foto_aluno == null )                                                       // Pergunta se a variavel que recebe o caminho da foto esta vazia.
            {
                foto_alterada = false;                                                              // Se estiver vazia atribui false na variavel de foto alterada.
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
            } // Faz a validacao dos campos. Se forem iguais, segue.
            else { dados_alterados = true; }                                                        // Se tiver alguma alteracao atribui true a variavel de dados alterados.

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
    
                    lista.Clear();                                  // limpa a lista para nao ter sujeita de pesquisa anterior.
                    
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
            cmd.Connection = conexao_Banco_PA.Conectar_DB(); // Conecta no banco para realizar a pesquisa.

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

        #region Verifica os dados digitadao antes do cadastro do aluno na tabela Alunos_Cadastro.
        public void Verifica_Campos()
        {

            while (!int.TryParse(Alunos_Codigo, out int verifica))      // Enquanto o txtbox nao for apenas numeros retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_12();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Nome))                   // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_13();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Endereco))               // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_14();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Bairro))                 // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_15();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Cidade))                 // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_16();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_CEP))                    // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_17();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Telefone))               // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_18();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Email))                  // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_19();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Contato_Emergencia))     // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_20();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Telefone_Emergencia_1))  // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                encerramento.Mensagem_21();
                return;
            }
            if (Alunos_Telefone_Emergencia_2 == "")
            {
                Alunos_Telefone_Emergencia_2 = "NÃO INFORMADO";
            }

            campos_validados = true;                                    // se passou pela validacao recebe true.
        }

        #endregion

        #region Metodo de execucao de conexao e atualizacao do Banco.

        public void Executa_Banco()
        {
            try
            {
                cmd.Connection = conexao_Banco_PA.Conectar_DB();        // Tenta fazer a conexao com o Banco chamando o metodo Conectar_DB da classe Conexao_Banco_PA
                cmd.ExecuteNonQuery();                                  // Comando que excuta a Query.
                conexao_Banco_PA.Desconectar_DB();

                Cad_Ok = "OK";                                          // Passa o valor OK para a variavel Cad_OK.
            }
            catch (MySqlException errodb)                               // Caso dê erro, mostra o erro do banco de dados.
            {
                encerramento.Mensagem_22(errodb.Message);
                DB_PA.Cad_Ok = "Erro";                                  // Passa o valor Erro para a variavel Cad_OK.    
            }

            conexao_Banco_PA.Desconectar_DB();                          // Chama o metodo Desconectar_DB da classe Conexao_Banco_Pa. (Desconecta do banco

            
        }

        #endregion



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
            public void Mensagem_12()
            {
                MessageBox.Show("O campo de Código do Aluno aceita apenas numeros e não pode estar vazio.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_13()
            {
                MessageBox.Show("O campo Nome do Aluno não pode estar vazio.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_14()
            {
                MessageBox.Show("O Campo Endereco do Aluno não pode estar vazio.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_15()
            {
                MessageBox.Show("O Campo Bairro não pode estar vazio.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_16()
            {
                MessageBox.Show("O Campo Cidade não pode estar vazio.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_17()
            {
                MessageBox.Show("O Campo CEP não pode estar vazio.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_18()
            {
                MessageBox.Show("O campo Telefone do Aluno não pode estar vazio.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_19()
            {
                MessageBox.Show("O Campo Email do Aluno não pode estar vazio\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_20()
            {
                MessageBox.Show("O Campo Contado de Emergencia não pode estar vazio.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_21()
            {
                MessageBox.Show("O Campo Telefone do Contato de Emergencia não pode estar vazio.\n",
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public void Mensagem_22(string erromsg)
            {
                MessageBox.Show("Erro ao Efetuar Cadastro.\n" + erromsg,
                                "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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