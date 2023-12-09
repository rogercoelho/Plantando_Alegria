using MySql.Data.MySqlClient;
using Plantando_Alegria.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Plantando_Alegria.MysqlDb
{
    public class DB_PA
    {
        #region Variaveis Operacionais

        public static string caminho_foto_aluno;                        // Variavel que armazena o caminho da foto do aluno.
        public static bool campos_validados;                            // Variavel que valida se os campos do cadastro do aluno e do plano estao certos.
        public static bool e_cadastro;                                  // Variavel que identifica se é um novo cadastro ou atualizacao.
        public static bool e_log;                                       // Variavel que executa o cadastro na tabela de log do aluno.
        public static bool dados_alterados;                             // Variavel que identifica se tem alteracoes nos dados da ficha do aluno.
        public static bool foto_alterada;                               // Variavel que identifica se tem alteracoes na foto da ficha do aluno.
        public static bool pesquisa_codigo_aluno = false;               // Variavel que identifica que a pesquisa foi feita pelo codigo para jogar direto para selecao2.
        public static bool pesquisa_codigo_plano = false;               // Variavel que identifica que a pesquisa foi feita pelo codigo do plano para jogar direto para selecao2.
        public static bool pesquisar_planos = false;                    // Variavel que chama a parte de pesquisar planos do metodo executa_pesquisa.
        public static bool pesquisar_alunos = false;                    // Variavel que chama a parte de pesquisar alunos do metodo executa_pesquisa.
        public static string Cad_Ok;                                    // Variavel para a limpeza do textbox e mostrar o checklistbox.
        public string query;                                            // Variavel que recebe a query do banco.
        public static byte[] imagem_byte;                               // Variavel que retorna em bytes a imagem.
        public object log;                                              // Objeto que recebe o historico do plano ou do aluno.
        MySqlDataReader dataReader;                                     // Variavel que armazena a leitura do banco.
        #endregion

        #region Instanciando Objetos.
                                                                        // Comunica com os forms.
        DataTable dataTable = new DataTable();                          // Instanciando objeto datatable que recebe a tabela do banco.
        Mensagens mensagens = new Mensagens();                          // Instanciando objeto para a classe mensagens.
        public List<object> lista = new List<object>();                 // Instanciando objeto da classe List. Vai receber o datareader em uma lista
        Conexao_Banco_PA conexao_Banco_PA = new Conexao_Banco_PA();     // Instanciando objeto da classe conexao_banco_PA. Para conectar e desconectar do banco.
        MySqlCommand cmd = new MySqlCommand();                          // Instanciando objeto da classe MysqlCommand. Para executar comandos Mysql.
        #endregion
        
        #region Tabela Alunos_Cadastro

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

        #endregion

        #region Metodo que limpa as variaveis DB_PA da tabela Alunos_Cadastro.

        public void Limpar_Variaveis_Alunos()
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
        }

        #endregion
        
        #region Metodos de Query do Banco de Dados.

        #region Metodo Query para Cadastrar Aluno na tabela Alunos_Cadastro.

        public void Query_Cadastrar_Aluno()
        {
            cmd.Parameters.Clear();         // Faz a limpeza dos parametros antes de incluir novos.

            query = "INSERT INTO Alunos_Cadastro VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_Endereco, @Alunos_Bairro," +  // Variavel ira receber a query.
                                                        "@Alunos_Cidade, @Alunos_CEP, @Alunos_Telefone, @Alunos_Email," +
                                                        "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                        "@Alunos_Telefone_Emergencia_2)";
            cmd.CommandText = query;        // Repassa a variavel query para os comandos do mysql.
            e_cadastro = true;              // Atribui true para a variavel e_cadastro. Identifica que é cadastro e nao atualizacao.
        }
        #endregion
        
        #region Metodo Query para Atualizar Aluno na tabela Alunos_Cadastro.
        public void Query_Atualizar_Cadastro_Aluno()
        {
            query = "UPDATE Alunos_Cadastro SET Alunos_Nome = @Alunos_Nome, Alunos_Endereco = @Alunos_Endereco, Alunos_Bairro = @Alunos_Bairro," +      // Variavel ira receber a query.
                                                      " Alunos_Cidade = @Alunos_Cidade, Alunos_CEP = @Alunos_CEP, " +
                                                      " Alunos_Telefone = @Alunos_Telefone, Alunos_Email = Alunos_Email, " +
                                                      " Alunos_Contato_Emergencia = @Alunos_Contato_Emergencia, " +
                                                      " Alunos_Telefone_Emergencia_1 = @Alunos_Telefone_Emergencia_1," +
                                                      " Alunos_telefone_Emergencia_2 = @Alunos_Telefone_Emergencia_2" +
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
                
        #region Metodo Query para pesquisar pelo codigo do aluno na tabela Alunos_Cadastro.

        public void Pesquisar_pelo_Codigo_tbl_alunos_cadastro()
        {
            cmd.Parameters.Clear();                                                             // Faz a limpeza dos parametros antes de incluir novos.
            pesquisa_codigo_aluno = true;                                                             // Atribui true a variavel pesquisa pelo codigo.
            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo =" + Alunos_Codigo;      // variavel que recebe o comando para executar no mysql + o que esta na variavel.
            cmd.CommandText = query;                                                            // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;      // Adiciona um parametro para acrescentar os valores encontrados.

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

        #region Metodo Query para pesquisar pelo codigo ou pelo nome na tabela Alunos_Cadastro.
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

        #region Metodo que compara a ficha do aluno com a tabela Alunos_Cadastro.
        public void Compara_Ficha_Aluno()
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
                                    if (frm_ficha_alunos.selecao2[15].ToString() == Alunos_Email.ToString())
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
            }                                                                                       // Faz a validacao dos campos. Se forem iguais, segue.
            else { dados_alterados = true; }                                                        // Se tiver alguma alteracao atribui true a variavel de dados alterados.

        }
        #endregion
        
        #region Verifica os dados digitados antes do cadastro do aluno na tabela Alunos_Cadastro.
        public void Verifica_Campos()
        {

            while (!int.TryParse(Alunos_Codigo, out int verifica))      // Enquanto o txtbox nao for apenas numeros retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_12();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Nome))                   // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_13();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Endereco))               // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_14();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Bairro))                 // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_15();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Cidade))                 // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_16();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_CEP))                    // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_17();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Telefone))               // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_18();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Email))                  // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_19();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Contato_Emergencia))     // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_20();
                return;
            }
            while (string.IsNullOrEmpty(Alunos_Telefone_Emergencia_1))  // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                campos_validados = false;
                mensagens.Mensagem_21();
                return;
            }
            if (Alunos_Telefone_Emergencia_2 == "")
            {
                Alunos_Telefone_Emergencia_2 = "NÃO INFORMADO";
            }

            campos_validados = true;                                    // se passou pela validacao recebe true.
        }

        #endregion
        
        #region Metodo que cadastra ou atualiza o cadastro na tabela Alunos_Cadastro.    

        public void Cadastrar_Atualizar_Alunos_Cadastro()
        {
            cmd.Parameters.Clear();                                                                                             // Faz a limpeza dos parametros antes de receber novos.

            #region Parametros para cadastro / atualizacao na Tabela Alunos_Cadastro.

            if (e_cadastro == true)                                                                                             // Se for cadastro e nao atualizacao.
            {
                cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;                                  // Adiciona o parametro para o cadastro.
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

            #region Paramentros para Cadstro do LOG na tabela Alunos_Cadastro_Log.
            if (e_log == true)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;                                  // Adiciona o parametro para o cadastro.
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
                cmd.Parameters.Add("@Atualizado_em", MySqlDbType.Timestamp).Value = DateTime.Now;                               // Adiciona o parametro para a atualizacao do cadastro.

                e_log = false;
            }
            #endregion

        }

        #endregion

        #endregion

        #region Tabela Alunos_Imagem

        #region Metodos de Query do banco.

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

        #region Metodo que cadastra ou atualiza a imagem na tabela Alunos_Imagem.
        public void Processa_Imagem()
        {
            if (Cad_Ok == "OK")                                                                                     // Aqui pergunta se as informacoes do aluno foram cadastradas primeiro.
                                                                                                                    // Se a resposta for OK ai sim insere a imagem no banco.
            {
                cmd.Parameters.Clear();                                                                             // Limpa os parametros do cmd.

                FileStream arquivo_imagem = new FileStream(caminho_foto_aluno, FileMode.Open, FileAccess.Read);     // Aqui utiliza o filestream para tratar a foto.  
                BinaryReader binary_reader = new BinaryReader(arquivo_imagem);                                      // Como o banco nao recebe imagem e sim dados    
                imagem_byte = binary_reader.ReadBytes((int)arquivo_imagem.Length);                                  // variavel imagem_byte recebe o conteudo do arquivo_imagem depois de ser
                                                                                                                    // "lido"pelo binary reader.
                #region Parametros do banco de imagem
                cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = Alunos_Codigo;
                cmd.Parameters.Add("@Imagem", MySqlDbType.LongBlob).Value = imagem_byte;                            // O tipo da coluna (longblob) Recebe o valor de alunos_imagem_mysql.
                cmd.Parameters.Add("@Criado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;                       // Define a data de insercao da imagem.
                cmd.Parameters.Add("@Atualizado_Em", MySqlDbType.Timestamp).Value = null;                           // define a data de atualizacao da imagem.
                cmd.CommandText = query;                                                                            // Repassa a variavel query para os comandos do mysql.
                #endregion
            }

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
                mensagens.Mensagem_04("-->" + erro_db.Message);
            }
            if (!dataReader.IsClosed)                       // Se o datareader estiver aberto.
            {
                dataReader.Close();                         // Encerra o datareader.
                conexao_Banco_PA.Desconectar_DB();          // Desconecta do banco.

            }

        }
        #endregion

        #endregion
        

        #region Tabela Planos_Cadastro

        #region Variaveis da tabela Planos_Cadastro.

        public static string planos_codigo;                 // Variavel que comunica com o textbox.
        public static string planos_nome;                   // Variavel que comunica com o textbox.
        public static string planos_qtd_aulas_semana;       // Variavel que comunica com o textbox.
        public static string planos_qtd_aulas_total;        // Variavel que comunica com o textbox.
        public static string planos_valor_mensal;           // Variavel que comunica com o textbox.
        public static string planos_valor_total;            // Variavel que comunica com o textbox.
        public static string planos_situacao;               // Variavel que comunica com o combobox.
        #endregion

        #region Metodo que limpa as variaveis DP_PA da tabela Planos_Cadastro.
        public void Limpa_Variaveis_Planos()
        {
            planos_codigo = "";
            planos_nome = "";
            planos_qtd_aulas_semana = "";
            planos_qtd_aulas_total = "";
            planos_valor_mensal = "";
            planos_valor_total = "";
        }

        #endregion

        #region Metodo que compara a ficha do Plano com a tabela Planos_Cadastro.
        public void Compara_Ficha_Planos()
        {
            dados_alterados = false;                                                                // Atribui falso a variavel dados alterados primeiro.

            if (frm_ficha_planos.selecao2[3].ToString().Trim() == planos_nome.ToString().Trim())
            {
                if (frm_ficha_planos.selecao2[5].ToString().Trim() == planos_qtd_aulas_semana.ToString().Trim())
                {
                    if (frm_ficha_planos.selecao2[7].ToString().Trim() == planos_qtd_aulas_total.ToString().Trim())
                    {
                        if (frm_ficha_planos.selecao2[9].ToString().Trim() == planos_valor_mensal.ToString().Trim())
                        {
                            if (frm_ficha_planos.selecao2[11].ToString().Trim() == planos_valor_total.ToString().Trim())
                            {
                                if (frm_ficha_planos.selecao2[13].ToString().Trim() == planos_situacao.ToString().Trim())
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
            } // Faz a validacao dos campos. Se forem iguais, segue.
            else { dados_alterados = true; }                                                        // Se tiver alguma alteracao atribui true a variavel de dados alterados.

        }
        #endregion
        
        #region Metodos de Query do Banco

        #region Metodo Query para cadastrar plano na tabela Planos_Cadastro.
        public void Query_Cadastrar_Plano()
        {
            cmd.Parameters.Clear();                                                     // Limpa os parametros para receber novos.
            
            query = "Insert into Planos_Cadastro (Planos_Codigo, Planos_Nome," +
                    "Planos_Qtd_Aulas_Semana,Planos_Qtd_Aulas_Total," +
                    "Planos_Valor_Mensal, Planos_Valor_Total, Planos_Ativo)" +
                    "Values (?,?,?,?,?,?,?)";                                           // sintaxe de insercao do banco.
            
        }
        #endregion

        #region Metodo Query para atualizar planos na tabela Plano_Cadastro.

        public void Query_Atualizar_Cadastro_Plano()
        {
            query = "UPDATE Planos_Cadastro SET Planos_Nome = @planos_nome, Planos_Qtd_Aulas_Semana = @qtd_aulas_semana, " +                 // Variavel ira receber a query.
                                              " Planos_Qtd_Aulas_Total = @qtd_aulas_total, Planos_Valor_Mensal = @valor_mensal," +
                                              " Planos_Valor_Total = @valor_total, Planos_Ativo = @ativo_plano " +
                                              " WHERE Planos_Codigo LIKE" + "'" + planos_codigo+"'";

            e_cadastro = false;         // Atribui false para a variavel e_cadastro para entender que é atualizacao.

        }

        #endregion

        #region Metodo Query para pesquisar tudo da tabela Planos_Cadastro.

        public void Pesquisar_Tudo_tbl_planos_cadastro()
        {
            query = "SELECT * from Planos_Cadastro";    // Variavel ira receber a query.         
            cmd.CommandText = query;                    // Repassa a variavel query para os comandos do mysql.
        }

        #endregion
        
        #region Metodo Query para pesquisar pelo codigo do plano na tabela Planos_Cadastro.

        public void Pesquisar_pelo_Codigo_tbl_planos_cadastro()
        {
            cmd.Parameters.Clear();                                                             // Faz a limpeza dos parametros antes de incluir novos.
            pesquisa_codigo_aluno = true;                                                             // Atribui true a variavel pesquisa pelo codigo.
            query = "SELECT * from Planos_Cadastro WHERE Planos_Codigo LIKE " + 
                    "'" + planos_codigo + "'";                                                  // variavel que recebe o comando para executar no mysql + o que esta na variavel.
            cmd.CommandText = query;                                                            // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.Add("@Planos_Codigo", MySqlDbType.VarChar).Value = planos_codigo;    // Adiciona um parametro para acrescentar os valores encontrados.

        }

        #endregion
        
        #region Metodo Query para pesquisar pelo nome do plano na tabela Planos_Cadastro.

        public void Pesquisar_Pelo_Nome_tbl_planos_cadastro()
        {
            cmd.Parameters.Clear();

            query = "SELECT * from Planos_Cadastro WHERE Planos_Nome LIKE" + 
                    "'" + planos_nome + "'";                                                        // Variavel ira receber a query. + o que esta na variavel.       
            cmd.CommandText = query;                                                                // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.AddWithValue("@Planos_Nome", planos_nome);                               // Adiciona um parametro para acrescentar os valores encontrados
        }

        #endregion

        #region Metodo Query para pesquisar pelo codigo ou pelo nome na tabela Planos_Cadastro.

        public void Pesquisar_pelo_Nome_Codigo_tbl_planos_cadastro()
        {
            query = "SELECT * from Planos_Cadastro WHERE Planos_Codigo LIKE" +    // variavel que recebe o comando para executar no mysql + o que esta na variavel.
                    "'" + planos_codigo + "'" + " OR Planos_Nome LIKE" +
                    "'" + planos_nome + "'";

            cmd.CommandText = query;                                        // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.AddWithValue("@Planos_codigo", Alunos_Codigo);   // Adiciona um parametro para acrescentar os valores encontrados.
            cmd.Parameters.AddWithValue("@Planos_Nome", Alunos_Nome);       // Adiciona um parametro para acrescentar os valores encontrados.
        }

        #endregion
        
        #endregion
        
        #region Metodo que valida os dados da tabela Planos_Cadastro.

        public void Verifica_Campos_Plano()
        {
            frm_cadastro_planos frm_Cadastro_Planos = new frm_cadastro_planos();
            campos_validados = true;

            while (string.IsNullOrEmpty (planos_codigo))
            {
                mensagens.Mensagem_23();
                campos_validados = false;
                return;
            }
            while (string.IsNullOrEmpty (planos_nome))
            {
                mensagens.Mensagem_24();
                campos_validados = false;
                return;
            }
            while (!int.TryParse(planos_qtd_aulas_semana, out int verifica))
            {
                mensagens.Mensagem_25();
                campos_validados = false;
                return;
            }
            while (!int.TryParse(planos_qtd_aulas_total, out int verifica))
            {
                mensagens.Mensagem_26();
                campos_validados = false;
                return;
            }
            while (!double.TryParse(planos_valor_mensal, out double verifica))
            {
                mensagens.Mensagem_27();
                campos_validados = false;
                return;
            }
            while (!double.TryParse(planos_valor_total, out double verifica))
            {
                mensagens.Mensagem_28();
                campos_validados = false;
                return;
            }
        }

        #endregion
        
        #region Metodo que cadastra ou atualiza o cadastro na tabela Planos_Cadastro.

        public void Cadastrar_Atualizar_Planos_Cadastro()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = query;    // Repassa a variavel query para os comandos do mysql.

            #region Parametros para cadastro / atualizacao da tabela Planos_Cadastro

            if (e_cadastro == true)
            {
                cmd.Parameters.Add("@Planos_Codigo", MySqlDbType.VarChar).Value = planos_codigo;
                cmd.Parameters.Add("@Planos_Nome", MySqlDbType.VarChar).Value = planos_nome;
                cmd.Parameters.Add("@Planos_Qtd_Aulas_Semana", MySqlDbType.Int32).Value = planos_qtd_aulas_semana;
                cmd.Parameters.Add("@Planos_Qtd_Aulas_Total", MySqlDbType.Int32).Value = planos_qtd_aulas_total;
                cmd.Parameters.Add("@Planos_Valor_Mensal", MySqlDbType.Double).Value = planos_valor_mensal;
                cmd.Parameters.Add("@Planos_Valor_Total", MySqlDbType.Double).Value = planos_valor_total;
                cmd.Parameters.Add("@Planos_Ativo", MySqlDbType.VarChar).Value = planos_situacao;

            }
            #endregion

            #region Parametros para cadastro do LOG na tabela Planos_Cadastro_log.
            if (e_log == true)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Planos_Codigo", MySqlDbType.VarChar).Value = planos_codigo;
                cmd.Parameters.Add("@Planos_Nome", MySqlDbType.VarChar).Value = planos_nome;
                cmd.Parameters.Add("@Planos_Qtd_Aulas_Semana", MySqlDbType.Int32).Value = planos_qtd_aulas_semana;
                cmd.Parameters.Add("@Planos_Qtd_Aulas_Total", MySqlDbType.Int32).Value = planos_qtd_aulas_total;
                cmd.Parameters.Add("@Planos_Valor_Mensal", MySqlDbType.Double).Value = planos_valor_mensal;
                cmd.Parameters.Add("@Planos_Valor_Total", MySqlDbType.Double).Value = planos_valor_total;
                cmd.Parameters.Add("@Planos_Ativo", MySqlDbType.VarChar).Value = planos_situacao;
                cmd.Parameters.Add("@Atualizado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;   // Adiciona um parametro para inserir os valores encontrados.
                e_log = false;
            }
            #endregion
        }

        #endregion


        #endregion

        #region Metodo que executa a pesquisa na tabela Alunos_Cadastro ou Planos_Cadastro.

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
                    mensagens.Mensagem_02();

                    DB_PA.Cad_Ok = "Erro";

                }
                #endregion

                #region Retorna a pesquisa com valores encontrados.

                else                                                // Caso possua dados na tabela do Banco faz a tratativa.
                {
                                                                    // Pega do datareader e tranfere para a lista

                    lista.Clear();                                  // limpa a lista para nao ter sujeita de pesquisa anterior.

                    #region Parte que pesquisa Planos.

                    if (pesquisar_planos == true)
                    {
                        while (dataReader.Read())                       // Enquanto o datareader estiver recebendo dados.
                        {

                            lista.Add(string.Join(null, "Cod_Plano. | ", dataReader[0].ToString() + " | ",
                                                       "  Nome_Plano | ", dataReader[1].ToString() + " | ",
                                                       "  Qtd_Aulas_Semana| ", dataReader[2].ToString() + " | ",
                                                       "  Qtd_Aulas_Total | ", dataReader[3].ToString() + " | ",
                                                       "  Valor_Mensal_Plano | ", dataReader[4].ToString().Replace("." ,",") + " | ",
                                                       "  Valor_Anual_Plano | ", dataReader[5].ToString().Replace(".",",") + " | ",
                                                       "  Situação_Plano | ", dataReader[6].ToString() + " | "));
                        }
                        Cad_Ok = "OK";     // Variavel Cad_OK recebe ok para listar no checklistbox.
                    }
                    pesquisar_planos = false;

                    if (pesquisa_codigo_plano == true)
                    {
                        frm_ficha_planos.selecao = (string)lista[0];
                        pesquisa_codigo_plano = false;
                    }

                    #endregion

                    #region Parte que pesquisa Alunos.

                    if (pesquisar_alunos == true)
                    {
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
                                                       "  Telefone Emergencia_2 | ", dataReader[10].ToString() + " | "));     // Acrescenta na variavel lista o valor do datareader.
                        }

                        Cad_Ok = "OK";     // Variavel Cad_OK recebe ok para listar no checklistbox.

                        if (pesquisa_codigo_aluno == true)
                        {
                            frm_ficha_alunos.selecao = (string)lista[0];
                            pesquisa_codigo_aluno = false;
                        }
                        pesquisar_alunos = false;
                    }

                    #endregion

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
                mensagens.Mensagem_04("-->" + erro_db.Message);
            }    
            conexao_Banco_PA.Desconectar_DB();

            #endregion

        }

        #endregion

        #region Tabela Alunos_Cadastro_Log.

        #region Metodo Query para inserir Log na Tabela Alunos_Cadastro_Log.
        public void Log_Query_Cadastrar_Aluno()
        {
            cmd.Parameters.Clear();         // Faz a limpeza dos parametros antes de incluir novos.

            query = "INSERT INTO Alunos_Cadastro_log VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_Endereco, @Alunos_Bairro," +  // Variavel ira receber a query.
                                                        "@Alunos_Cidade, @Alunos_CEP, @Alunos_Telefone, @Alunos_Email," +
                                                        "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                        "@Alunos_Telefone_Emergencia_2, @Atualizado_Em)";
            cmd.CommandText = query;        // Repassa a variavel query para os comandos do mysql.
        }
        #endregion


        #endregion

        #region Tabela Planos_Cadastro_Log.

        #region Metodo Query Inserir Log na tabela Planos_Cadastro_Log.
        public void Log_Query_Cadastrar_Plano()
        {
            cmd.Parameters.Clear();                                                             // Limpa os parametros para receber novos.

            query = "Insert into Planos_Cadastro_log (Planos_Codigo, Planos_Nome, " +
                    "Planos_Qtd_Aulas_Semana,Planos_Qtd_Aulas_Total, " +
                    "Planos_Valor_Mensal, Planos_Valor_Total, Planos_Ativo," +
                    " Atualizado_Em) Values (?,?,?,?,?,?,?,?)";                                   // sintaxe de insercao do banco.
            
            cmd.CommandText = query;
        }

        #endregion

        #endregion

        #region Metodo que executa pesquisa do log na tabela Alunos_Cadastro_Log ou Planos_Cadastro_Log (HISTORICO).
        public void Executa_Pesquisa_Log()
        {
            if (frm_historico.volta_ficha_aluno == true)
            {
                query = "SELECT * from Alunos_Cadastro_log WHERE Alunos_Codigo =" + DB_PA.Alunos_Codigo.Trim();      // variavel que recebe o comando para executar no mysql + o que esta na variavel.

            }
            else if (frm_historico.volta_ficha_plano == true)
            {
                query = "SELECT * from Planos_Cadastro_log WHERE Planos_Codigo LIKE" + "'" + DB_PA.planos_codigo.Trim() + "'";      // variavel que recebe o comando para executar no mysql + o que esta na variavel.
            }
            
            
            frm_historico frm_Historico = new frm_historico();          // Instanciando objeto para a classe frm_historico.
            cmd.Connection = conexao_Banco_PA.Conectar_DB();            // Conecta no banco de dados da PA.
            cmd.CommandText = query;                                    // Repassa a query para o mysqlcommand.
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);   // Instanciando objeto dataadapter que faz a consulta no mysql.
            dataAdapter.Fill(dataTable);                                // dataadapter preenche o datatable.
            log = dataTable;                                            // objeto log recebe o datatable.
            cmd.Connection.Close();                                     // Encerra a conexao.
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
                mensagens.Mensagem_22(errodb.Message);
                DB_PA.Cad_Ok = "Erro";                                  // Passa o valor Erro para a variavel Cad_OK.    
            }

            conexao_Banco_PA.Desconectar_DB();                          // Chama o metodo Desconectar_DB da classe Conexao_Banco_Pa. (Desconecta do banco

            
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