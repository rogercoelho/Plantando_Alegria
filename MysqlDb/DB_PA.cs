using MySql.Data.MySqlClient;
using Plantando_Alegria.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Plantando_Alegria.MysqlDb
{
    public class DB_PA
    {
        #region VALIDADO
        #region Inicio - Instanciando Objetos.
        // Comunica com os forms.
        DataTable dataTable = new DataTable();                          // Instanciando objeto datatable que recebe a tabela do banco.
        Mensagens mensagens = new Mensagens();                          // Instanciando objeto para a classe mensagens.
        public List<object> lista = new List<object>();                 // Instanciando objeto da classe List. Vai receber o datareader em uma lista
        Conexao_Banco_PA conexao_Banco_PA = new Conexao_Banco_PA();     // Instanciando objeto da classe conexao_banco_PA. Para conectar e desconectar do banco.
        MySqlCommand cmd = new MySqlCommand();                          // Instanciando objeto da classe MysqlCommand. Para executar comandos Mysql.

        #endregion Fim - Instanciando Objetos.

        #region Inicio - Variaveis DB_PA.

        public static bool campos_validados,           // Variavel que valida se os campos do cadastro do aluno e do plano estao certos.
                             e_cadastro,                 // Variavel que identifica se é um novo cadastro ou atualizacao.
                             e_log,                      // Variavel que executa o cadastro na tabela de log do aluno.
                             dados_alterados,            // Variavel que identifica se tem alteracoes nos dados da ficha do aluno.
                             pesquisa_codigo_plano,      // Variavel que identifica que a pesquisa foi feita pelo codigo do plano para jogar direto para selecao2.
                             pesquisar_codigos_planos,   // Variavel que chama a parte de pesquisar a lista de codigos dos planos no metodo executa_perquisa
                             pesquisar_planos,           // Variavel que ativa a parte de pesquisa de planos.
                             pesquisar_aluno,            // Variavel que ativa a parte de pesquisa de aluno.
                             pesquisar_situacao_aluno,   // Variavel que ativa a parte de pesquisa da situacao do aluno
                             situacao_aluno_alterada,    // Variavel que identifica se a situacao do aluno alterou
                             retornou_pesquisa = false;
        public static string Cad_Ok,                     // Variavel para a limpeza do textbox e mostrar o checklistbox.
                             planos_selecao;             // variavel que recebe a selecao do checklistbox planos.

        public string query;                      // Variavel que recebe a query do banco.
        public object log;                        // Objeto que recebe o historico do plano ou do aluno.
        MySqlDataReader dataReader;                      // Variavel que armazena a leitura do banco.

        #endregion Fim - Variaveis DB_PA.

        #region Inicio - Criando variaveis das tabelas do banco.

        #region Inicio - Tabela Alunos Cadastro e Alunos Cadastro Log.

        public static int tbl_alunos_cadastro_codigo;
        public static string tbl_alunos_cadastro_cpf,
                                tbl_alunos_cadastro_nome,
                                tbl_alunos_cadastro_nome_responsavel,
                                tbl_alunos_cadastro_endereco,
                                tbl_alunos_cadastro_bairro,
                                tbl_alunos_cadastro_cidade,
                                tbl_alunos_cadastro_cep,
                                tbl_alunos_cadastro_telefone,
                                tbl_alunos_cadastro_email,
                                tbl_alunos_cadastro_nome_contato_emergencia,
                                tbl_alunos_cadastro_tel_contato_emergencia_1,
                                tbl_alunos_cadastro_tel_contato_emergencia_2,
                                tbl_alunos_cadastro_log_atualizado_em;
        public static bool tbl_alunos_cadastro_pesquisa_codigo_aluno = false;  // Variavel que identifica que a pesquisa foi feita pelo codigo para jogar direto para selecao2.

        #endregion Fim - Tabela Alunos Cadastro e Alunos Cadastro Log.

        #region Inicio - Tabela Planos Cadastro e Planos Cadastro Log.

        public static int tbl_planos_cadastro_qtd_meses,
                                tbl_planos_cadastro_qtd_aulas_semana,
                                tbl_planos_cadastro_qtd_aulas_total;
        public static double tbl_planos_cadastro_valor_mensal,
                                tbl_planos_cadastro_valor_total;
        public static string tbl_planos_cadastro_codigo,
                                tbl_planos_cadastro_nome,
                                tbl_planos_cadastro_situacao,
                                tbl_planos_cadastro_log_atualizado_em;
        public static string[] tbl_pesquisa_planos_separa_selecao;              // Array de variavel que pega a variavel selecao e separa os dados dentro do array.



        #endregion Fim - Tabela Planos Cadastro e Planos Cadastro Log.

        #region Inicio - Tabela Alunos Imagem.

        public static string tbl_alunos_imagem_caminho_foto_aluno;                        // Variavel que armazena o caminho da foto do aluno.
        public static byte[] tbl_alunos_imagem_imagem_byte;                               // Variavel que retorna em bytes a imagem.
        public static bool tbl_alunos_imagem_foto_alterada = false;                     // Variavel que identifica se tem alteracoes na foto da ficha do aluno.


        #endregion Fim - Tabela Alunos Imagem.



        #endregion Fim - Criando variaveis das tabelas do banco.

        #region Inicio - Criando variaveis das telas.

        #region Inicio - Tela Cadastro de alunos.        
        /* Variaveis que recebem as informacoes da tela de cadastro de alunos */

        public static string    tela_cadastro_aluno_situacao,
                                tela_cadastro_aluno_codigo,
                                tela_cadastro_cpf,
                                tela_cadastro_aluno_nome,
                                tela_cadastro_nome_responsavel,
                                tela_cadastro_endereco,
                                tela_cadastro_bairro,
                                tela_cadastro_cidade,
                                tela_cadastro_cep,
                                tela_cadastro_telefone,
                                tela_cadastro_email,
                                tela_cadastro_nome_contato_emergencia,
                                tela_cadastro_tel_contato_emergencia_1,
                                tela_cadastro_tel_contato_emergencia_2;

        #endregion Fim - Tela Cadastro de alunos.

        #region Inicio - Tela Pesquisa de alunos.

        public static string[] tela_pesquisa_aluno_separa_selecao;              // Array de variavel que pega a variavel selecao e separa os dados dentro do array.
        public static string tela_pesquisa_aluno_selecao,                       // Variavel que recebe o item selecionado no checklistbox da tela de pesquisa de alunos.
                               tela_pesquisa_codigo_aluno,
                               tela_pesquisa_nome_aluno,
                               tela_pesquisa_cpf_aluno;

        #endregion Fim - Tela Pesquisa de alunos.

        #region Inicio - Tela Ficha de aluno.

        public static string   tela_ficha_aluno_situacao,
                               tela_ficha_aluno_codigo,
                               tela_ficha_aluno_cpf,
                               tela_ficha_aluno_nome,
                               tela_ficha_aluno_nome_responsavel,
                               tela_ficha_aluno_endereco,
                               tela_ficha_aluno_bairro,
                               tela_ficha_aluno_cidade,
                               tela_ficha_aluno_cep,
                               tela_ficha_aluno_telefone,
                               tela_ficha_aluno_email,
                               tela_ficha_aluno_contato_emergencia,
                               tela_ficha_aluno_telefone_emergencia_1,
                               tela_ficha_aluno_telefone_emergencia_2;

        #endregion Fim - Tela Ficha de aluno.

        #region Inicio - Tela Cadastro de Planos.

        public static string tela_cadastro_planos_codigo,
                             tela_cadastro_planos_nome,
                             tela_cadastro_planos_qtd_meses,
                             tela_cadastro_planos_qtd_aulas_semana,
                             tela_cadastro_planos_qtd_aulas_total,
                             tela_cadastro_planos_valor_mensal,
                             tela_cadastro_planos_valor_total;

        #endregion Fim - Tela Cadastro de Planos 

        #region Inicio - Tela Pesquisa de Planos.
        public static string tela_pesquisa_codigo_plano,
                                tela_pesquisa_nome_plano;

        #endregion Fim - Tela Pesquisa de Planos.

        #region Inicio - Tela Ficha de Planos.

        public static string tela_ficha_planos_codigo,                 // Variavel que comunica com o textbox.
                             tela_ficha_planos_nome,                   // Variavel que comunica com o textbox.
                             tela_ficha_planos_qtd_meses,              // Variavel que comunica com o textbox.
                             tela_ficha_planos_qtd_aulas_semana,       // Variavel que comunica com o textbox.
                             tela_ficha_planos_qtd_aulas_total,        // Variavel que comunica com o textbox.
                             tela_ficha_planos_valor_mensal,           // Variavel que recebe o valor do plano tipo double.
                             tela_ficha_planos_valor_total,            // Variavel que recebe o valor do plano tipo double.
                             tela_ficha_planos_situacao;               // Variavel que comunica com o combobox.

        #endregion Fim - Tela Ficha de Planos.


        #endregion Fim - Criando variaveis das telas.

        #region Inicio - Metodos de Query.

        #region Inicio - Metodo Query Cadastrar aluno tbl Alunos_Cadastro.
        public void Query_Cadastrar_Aluno()
        {
            /*   Funcao -> Query que insere os dados da tela de cadastro de alunos na tabela Alunos_Cadastro
             * - Atribui na variavel a sintaxe da query a ser executada.
             * - Repassa as informacoes da variavel para o mysqlcommand para ser executado. */

            query = "INSERT INTO Alunos_Cadastro VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_Nome_Responsavel, @Alunos_CPF, " +
                                                        "@Alunos_Endereco, @Alunos_Bairro," +
                                                        "@Alunos_Cidade, @Alunos_CEP, @Alunos_Telefone, @Alunos_Email," +
                                                        "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                        "@Alunos_Telefone_Emergencia_2)";
            cmd.CommandText = query;
        }

        #endregion Fim - Metodo Query Cadastrar aluno tbl Alunos_Cadastro.
        


        #region Inicio - Atualizar aluno tbl Alunos_Cadastro.
        public void Query_Atualizar_Cadastro_Aluno()
        {
            /*   Funcao -> Query que atualiza os dados da tela de ficha de alunos na tabela Alunos_Cadastro.
             * - Atribui na variavel a sintaxe da query a ser executada usando o codigo do aluno como filtro.
             * - Repassa as informacoes da variavel para o mysqlcommand para ser executado. */

            query = "UPDATE Alunos_Cadastro SET Alunos_Nome = @Alunos_Nome, Alunos_Nome_Responsavel = @Alunos_Nome_Responsavel, " +
                                                      "Alunos_Endereco = @Alunos_Endereco, Alunos_Bairro = @Alunos_Bairro," +
                                                      " Alunos_Cidade = @Alunos_Cidade, Alunos_CEP = @Alunos_CEP, " +
                                                      " Alunos_Telefone = @Alunos_Telefone, Alunos_Email = Alunos_Email, " +
                                                      " Alunos_Contato_Emergencia = @Alunos_Contato_Emergencia, " +
                                                      " Alunos_Telefone_Emergencia_1 = @Alunos_Telefone_Emergencia_1," +
                                                      " Alunos_telefone_Emergencia_2 = @Alunos_Telefone_Emergencia_2" +
                                                      " WHERE Alunos_Codigo =" + tbl_alunos_cadastro_codigo;
            cmd.CommandText = query;
            // e_cadastro = false; VER SE REALMENTE PRECISA.     
        }

        #endregion Fim - Atualizar aluno tbl Alunos_Cadastro.

        #region Inicio - Pesquisar aluno tbl Alunos_Cadastro.

        public void Pesquisar_Tudo_tbl_alunos_cadastro()
        {
            /*   Funcao -> Metodo que pesquisa todos os alunos da tabela Alunos_Cadastro e mostra na tela.
             *   - Atribui na variavel a sintaxe da query a ser executada sem qualquer filtro.
             *   - Repassa as informacoes da variavel para o mysqlcommand para ser executado.  */


            query = "SELECT * from Alunos_Cadastro";
            cmd.CommandText = query;
        }
        public void Pesquisar_pelo_Codigo_tbl_alunos_cadastro()
        {
            /*   Funcao -> Metodo que pesquisa na tabela Alunos_Cadastro e mostra na tela.
             *   - Atribui na variavel a sintaxe da query a ser executada utilizando o codigo do aluno como filtro.
             *   - Repassa as informacoes da variavel para o mysqlcommand para ser executado.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados. 
             *   - Inclui o parametro do codigo do aluno para ser locallizado. */

            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo =" + tbl_alunos_cadastro_codigo;
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = tbl_alunos_cadastro_codigo;
            // tbl_alunos_cadastro_pesquisa_codigo_aluno = true;  // ESSA VARIAVEL NAO FOI USADA PARA PESSQUISAR PELO CODIGO DO ALUNO.
        }
        public void Pesquisar_Pelo_Nome_tbl_alunos_cadastro()
        {
            /*   Funcao -> Metodo que pesquisa na tabela Alunos_Cadastro e mostra na tela.
             *   - Atribui na variavel a sintaxe da query a ser executada utilizando o nome do aluno como filtro.
             *   - Repassa as informacoes da variavel para o mysqlcommand para ser executado.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados. 
             *   - Inclui o parametro do nome do aluno para ser locallizado. */

            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Nome LIKE '" + tbl_alunos_cadastro_nome + "'";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Alunos_Nome", tbl_alunos_cadastro_nome);
        }
        public void Pesquisar_pelo_CPF_tbl_alunos_cadastro()
        {
            /*   Funcao -> Metodo que pesquisa na tabela Alunos_Cadastro e mostra na tela.
             *   - Atribui na variavel a sintaxe da query a ser executada utilizando o cpf do aluno como filtro.
             *   - Repassa as informacoes da variavel para o mysqlcommand para ser executado.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados. 
             *   - Inclui o parametro do cpf do aluno para ser locallizado. */

            query = "SELECT * from Alunos_Cadastro WHERE Alunos_CPF =" + tbl_alunos_cadastro_cpf;
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_CPF", MySqlDbType.Int32).Value = tbl_alunos_cadastro_cpf;
        }
        public void Pesquisar_pelo_Nome_Codigo_CPF_tbl_alunos_cadastro()
        {
            /*   Funcao -> Metodo que pesquisa na tabela Alunos_Cadastro e mostra na tela.
             *   - Atribui na variavel a sintaxe da query a ser executada utilizando o codigo, nome ou cpf do aluno como filtro.
             *   - Repassa as informacoes da variavel para o mysqlcommand para ser executado.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados. 
             *   - Inclui o parametro do codigo, nome e cpf do aluno para ser locallizado. */

            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo="
                     + tbl_alunos_cadastro_codigo
                     + " OR Alunos_Nome LIKE" +
                     " '" + tbl_alunos_cadastro_nome + "'" +
                     " OR Alunos_CPF =" + tbl_alunos_cadastro_cpf;
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Alunos_codigo", tbl_alunos_cadastro_codigo);
            cmd.Parameters.AddWithValue("@Alunos_Nome", tbl_alunos_cadastro_nome);
            cmd.Parameters.AddWithValue("@Alunos_CPF", tbl_alunos_cadastro_cpf);
        }
        public void Pesquisar_pelo_Nome_Codigo_tbl_alunos_cadastro()
        {
            /*   Funcao -> Metodo que pesquisa na tabela Alunos_Cadastro e mostra na tela.
             *   - Atribui na variavel a sintaxe da query a ser executada utilizando o codigo ou nome do aluno como filtro.
             *   - Repassa as informacoes da variavel para o mysqlcommand para ser executado.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados. 
             *   - Inclui o parametro do codigo e do nome do aluno para ser locallizado. */

            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo="
                     + tbl_alunos_cadastro_codigo
                     + " OR Alunos_Nome LIKE" +
                     " '" + tbl_alunos_cadastro_nome + "'";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Alunos_codigo", tbl_alunos_cadastro_codigo);
            cmd.Parameters.AddWithValue("@Alunos_Nome", tbl_alunos_cadastro_nome);
        }
        public void Pesquisar_pelo_Codigo_CPF_tbl_alunos_cadastro()
        {
            /*   Funcao -> Metodo que pesquisa na tabela Alunos_Cadastro e mostra na tela.
             *   - Atribui na variavel a sintaxe da query a ser executada utilizando o codigo ou cpf do aluno como filtro.
             *   - Repassa as informacoes da variavel para o mysqlcommand para ser executado.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados. 
             *   - Inclui o parametro do codigo e do cpf do aluno para ser locallizado. */

            query = "SELECT * from Alunos_Cadastro WHERE Alunos_Codigo="
                     + tbl_alunos_cadastro_codigo
                     + " OR Alunos_CPF ="
                     + tbl_alunos_cadastro_cpf;
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Alunos_codigo", tbl_alunos_cadastro_codigo);
            cmd.Parameters.AddWithValue("@Alunos_CPF", tbl_alunos_cadastro_cpf);
        }
        public void Pesquisar_pelo_Nome_CPF_tbl_alunos_cadastro()
        {
            /*   Funcao -> Metodo que pesquisa na tabela Alunos_Cadastro e mostra na tela.
             *   - Atribui na variavel a sintaxe da query a ser executada utilizando o cpf ou nome do aluno como filtro.
             *   - Repassa as informacoes da variavel para o mysqlcommand para ser executado.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados. 
             *   - Inclui o parametro do cpf e do nome do aluno para ser locallizado. */

            query = "SELECT * from Alunos_Cadastro WHERE Alunos_CPF="
                     + tbl_alunos_cadastro_cpf
                     + " OR Alunos_Nome LIKE" +
                     " '" + tbl_alunos_cadastro_nome + "'";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Alunos_CPF", tbl_alunos_cadastro_cpf);
            cmd.Parameters.AddWithValue("@Alunos_Nome", tbl_alunos_cadastro_nome);
        }

        #endregion Fim - Pesquisar aluno tbl Alunos_Cadastro.

        #region Inicio - Cadastrar log tbl Alunos_Cadastro_log.
        public void Log_Query_Cadastrar_Aluno()
        {
            /*   Funcao -> Query que cadastra o log de mudancas feitas na tabela Alunos_Cadastro_Log.
             * - Atribui na variavel a sintaxe da query a ser executada.
             * - Repassa as informacoes da variavel para o mysqlcommand para ser executado. */

            query = "INSERT INTO Alunos_Cadastro_log VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_Nome_Responsavel, " +
                                                        "@Alunos_CPF, @Alunos_Endereco, @Alunos_Bairro," +
                                                        "@Alunos_Cidade, @Alunos_CEP, @Alunos_Telefone, @Alunos_Email," +
                                                        "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                        "@Alunos_Telefone_Emergencia_2, @Atualizado_Em)";
            cmd.CommandText = query;
        }
        public void Cadastrar_Log()
        {
            /*   Funcao -> Metodo que faz a verificacao se os parametros do Mysqlcommand
             *   sao para o cadastro de log.
             * - Primeiro verifica se está gravando log através da variavel e_log. Se ela
             *   receber o valor true inicia os parametros para a gravacao de log.
             * - Se for para gravar log, chama o metodo dos parametros do cadastro de alunos.
             * - Acrecenta o parametro de registro de data e hora da gravacao do log.  */

            if (e_log == true)
            {
                Parametros_Cadastro_Alunos();
                cmd.Parameters.Add("@Atualizado_em", MySqlDbType.Timestamp).Value = DateTime.Now;
            }
        }

        #endregion Fim - Cadastrar log tbl Alunos_Cadastro_log.

        #region Inicio - Cadastrar imagem tbl Alunos_Imagem.
        public void Query_Inserir_Imagem()
        {
            /*   Funcao -> Query que insere a imagem do aluno da tela de cadastro de alunos na tabela Alunos_Imagem.
             * - Atribui na variavel a sintaxe da query a ser executada.
             * - Repassa as informacoes da variavel para o mysqlcommand para ser executado. */

            query = "INSERT INTO Alunos_Imagem VALUES (@Alunos_Codigo, @Imagem, @Criado_Em, @Atualizado_Em)";
            cmd.CommandText = query;
        }

        #endregion Fim - Cadastrar imagem tbl Alunos_Imagem.

        #region Inicio - Atualizar imagem tbl Alunos_Imagem.
        public void Query_Alterar_Imagem()
        {
            /*   Funcao -> Query que atualiza a imagem do aluno da tela de ficha de alunos na tabela Alunos_Imagem.
             * - Atribui na variavel a sintaxe da query a ser executada usando o codigo do aluno como filtro.
             * - Repassa as informacoes da variavel para o mysqlcommand para ser executado. */

            query = "UPDATE Alunos_Imagem SET Imagem = @Imagem, " +
                    "Atualizado_Em = @Atualizado_Em WHERE Alunos_Codigo =" + tbl_alunos_cadastro_codigo;
            cmd.CommandText = query;
        }

        #endregion Fim - Atualizar imagem tbl Alunos_Imagem.

        #region Inicio - Pesquisar Imagem tbl Alunos_Imagem.
        public void Pesquisar_Imagem()
        {
            /*   Funcao -> Metodo que pesquisa na tabela Alunos_Imagem e mostra a foto do aluno na tela.
             *   - Atribui na variavel a sintaxe da query a ser executada utilizando o codigo do aluno como filtro.
             *   - Repassa as informacoes da variavel para o mysqlcommand para ser executado.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados. 
             *   - Inclui o parametro do codigo do aluno para ser locallizado.
             *   - Chama o metodo que executa a pesquisa da imagem do aluno. */

            query = "SELECT Imagem FROM Alunos_Imagem WHERE Alunos_Codigo =" + tbl_alunos_cadastro_codigo;
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = tbl_alunos_cadastro_codigo;
            Executa_Pesquisa_Imagem();
        }

        #endregion Fim - Pesquisar Imagem tbl Alunos_Imagem.

        #region Inicio - Metodo Query para cadastrar plano na tabela Planos_Cadastro.
        public void Query_Cadastrar_Plano()
        {
            cmd.Parameters.Clear();                                                 // Limpa os parametros para receber novos.

            query = "Insert into Planos_Cadastro (Planos_Codigo, Planos_Nome," +
                    "Planos_Qtd_Meses, Planos_Qtd_Aulas_Semana,Planos_Qtd_Aulas_Total," +
                    "Planos_Valor_Mensal, Planos_Valor_Total, Planos_Ativo)" +
                    "Values (?,?,?,?,?,?,?,?)";                                       // sintaxe de insercao do banco.

            cmd.CommandText = query;                                                // Repassa a variavel query para os comandos do mysql.   
        }
        #endregion Fim - Metodo Query para cadastrar plano na tabela Planos_Cadastro.

        #region Inicio - Metodo Query Inserir Log na tabela Planos_Cadastro_Log.
        public void Log_Query_Cadastrar_Plano()
        {
            cmd.Parameters.Clear();                                                             // Limpa os parametros para receber novos.

            query = "Insert into Planos_Cadastro_log (Planos_Codigo, Planos_Nome, " +
                    "Planos_Qtd_Meses,Planos_Qtd_Aulas_Semana,Planos_Qtd_Aulas_Total, " +
                    "Planos_Valor_Mensal, Planos_Valor_Total, Planos_Ativo," +
                    " Atualizado_Em) Values (?,?,?,?,?,?,?,?,?)";                                   // sintaxe de insercao do banco.

            cmd.CommandText = query;
        }

        #endregion Fim - Metodo Query Inserir Log na tabela Planos_Cadastro_Log.

        #region Inicio - Metodo Query para pesquisar tudo da tabela Planos_Cadastro.
        public void Pesquisar_Tudo_tbl_planos_cadastro()
        {
            query = "SELECT * from Planos_Cadastro";    // Variavel ira receber a query.         
            cmd.CommandText = query;                    // Repassa a variavel query para os comandos do mysql.
        }

        #endregion Fim - Metodo Query para pesquisar tudo da tabela Planos_Cadastro.

        #region Inicio - Metodo Query para pesquisar pelo codigo do plano na tabela Planos_Cadastro.
        public void Pesquisar_pelo_Codigo_tbl_planos_cadastro()
        {
            cmd.Parameters.Clear();                                                                         // Faz a limpeza dos parametros antes de incluir novos.
            query = "SELECT * from Planos_Cadastro WHERE Planos_Codigo LIKE " +
                    "'" + tbl_planos_cadastro_codigo + "'";                                                 // variavel que recebe o comando para executar no mysql + o que esta na variavel.
            cmd.CommandText = query;                                                                        // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.Add("@Planos_Codigo", MySqlDbType.VarChar).Value = tbl_planos_cadastro_codigo;   // Adiciona um parametro para acrescentar os valores encontrados.
        }

        #endregion Fim - Metodo Query para pesquisar pelo codigo do plano na tabela Planos_Cadastro.

        #region Inicio - Metodo Query para pesquisar pelo nome do plano na tabela Planos_Cadastro.
        public void Pesquisar_Pelo_Nome_tbl_planos_cadastro()
        {
            cmd.Parameters.Clear();

            query = "SELECT * from Planos_Cadastro WHERE Planos_Nome LIKE" +
                    "'" + tela_pesquisa_nome_plano + "'";                           // Variavel ira receber a query. + o que esta na variavel.       
            cmd.CommandText = query;                                                // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.AddWithValue("@Planos_Nome", tela_pesquisa_nome_plano);  // Adiciona um parametro para acrescentar os valores encontrados
        }

        #endregion Fim - Metodo Query para pesquisar pelo nome do plano na tabela Planos_Cadastro.

        #region Inicio - Metodo Query para pesquisar pelo codigo ou pelo nome na tabela Planos_Cadastro.
        public void Pesquisar_pelo_Nome_Codigo_tbl_planos_cadastro()
        {
            cmd.Parameters.Clear();                                                     // Limpa os paramentros.

            query = "SELECT * from Planos_Cadastro WHERE Planos_Codigo LIKE" +          // variavel que recebe o comando para executar no mysql + o que esta na variavel.
                    "'" + tela_pesquisa_codigo_plano + "'" + " OR Planos_Nome LIKE" +
                    "'" + tela_pesquisa_nome_plano + "'";

            cmd.CommandText = query;                                                    // Repassa a variavel query para os comandos do mysql.
            cmd.Parameters.AddWithValue("@Planos_codigo", tela_pesquisa_codigo_plano);  // Adiciona um parametro para acrescentar os valores encontrados.
            cmd.Parameters.AddWithValue("@Planos_Nome", tela_pesquisa_nome_plano);      // Adiciona um parametro para acrescentar os valores encontrados.
        }

        #endregion Fim - Metodo Query para pesquisar pelo codigo ou pelo nome na tabela Planos_Cadastro.

        #region Inicio - Metodo Query para atualizar planos na tabela Plano_Cadastro.        
        public void Query_Atualizar_Cadastro_Plano()
        {
            query = "UPDATE Planos_Cadastro SET Planos_Nome = @Planos_Nome, Planos_Qtd_Meses = @Planos_Qtd_Meses, Planos_Qtd_Aulas_Semana = @Planos_Qtd_Aulas_Semana, " +                 // Variavel ira receber a query.
                                              " Planos_Qtd_Aulas_Total = @Planos_Qtd_Aulas_Total, Planos_Valor_Mensal = @Planos_Valor_Mensal," +
                                              " Planos_Valor_Total = @Planos_Valor_Total, Planos_Situacao = @Planos_Situacao " +
                                              " WHERE Planos_Codigo LIKE" + "'" + tbl_planos_cadastro_codigo + "'";

            cmd.CommandText = query;
            e_cadastro = false;         // Atribui false para a variavel e_cadastro para entender que é atualizacao.
        }

        #endregion Fim - Metodo Query para atualizar planos na tabela Plano_Cadastro.

        #endregion Fim - Metodos de Query.

        #region Inicio - Metodos que transfere dados entre variaveis.      

        #region Inicio - Variaveis Tela Cadastro Alunos para Tabela Alunos_Cadastro.

        public void Transfere_Cadastro_AlunosXTabela_Alunos_Cadastro()
        {
            Limpar_Variaveis_Tbl_Alunos_Cadastro();
            tbl_alunos_cadastro_codigo = Convert.ToInt32(tela_cadastro_aluno_codigo);
            tbl_alunos_cadastro_nome = tela_cadastro_aluno_nome;
            tbl_alunos_cadastro_nome_responsavel = tela_cadastro_nome_responsavel;
            tbl_alunos_cadastro_cpf = tela_cadastro_cpf;
            tbl_alunos_cadastro_endereco = tela_cadastro_endereco;
            tbl_alunos_cadastro_bairro = tela_cadastro_bairro;
            tbl_alunos_cadastro_cidade = tela_cadastro_cidade;
            tbl_alunos_cadastro_cep = tela_cadastro_cep;
            tbl_alunos_cadastro_telefone = tela_cadastro_telefone;
            tbl_alunos_cadastro_email = tela_cadastro_email;
            tbl_alunos_cadastro_nome_contato_emergencia = tela_cadastro_nome_contato_emergencia;
            tbl_alunos_cadastro_tel_contato_emergencia_1 = tela_cadastro_tel_contato_emergencia_1;
            tbl_alunos_cadastro_tel_contato_emergencia_2 = tela_cadastro_tel_contato_emergencia_2;

        }

        #endregion Fim - Variaveis Tela Cadastro Alunos para Tabela Alunos_Cadastro.



        #region Inicio - Variaveis Tela Pesquisa de Alunos para Tabela Alunos_Cadastro.
        public void Transfere_Pesquisa_AlunosXTabela_Alunos_Cadastro()
        {
            Limpar_Variaveis_Tbl_Alunos_Cadastro();

            if (tela_pesquisa_codigo_aluno != "")
            {
                int positivo = Convert.ToInt32(tela_pesquisa_codigo_aluno);
                if (positivo >= 0)
                {
                    tbl_alunos_cadastro_codigo = positivo;
                }
            }
            tbl_alunos_cadastro_nome = tela_pesquisa_nome_aluno;
            tbl_alunos_cadastro_cpf = tela_pesquisa_cpf_aluno;
        }

        #endregion Fim - Variaveis Tela Pesquisa de Alunos para Tabela Alunos_Cadastro.

        #region Inicio - Variaveis Tela Ficha de Alunos Tabela Alunos_Cadastro.
        public void Transfere_Ficha_AlunoXTabela_Alunos_Cadastro()
        {
            Limpar_Variaveis_Tbl_Alunos_Cadastro();
            tbl_alunos_cadastro_codigo = Convert.ToInt32(tela_ficha_aluno_codigo);
            tbl_alunos_cadastro_cpf = tela_ficha_aluno_cpf;
            tbl_alunos_cadastro_nome = tela_ficha_aluno_nome;
            tbl_alunos_cadastro_nome_responsavel = tela_ficha_aluno_nome_responsavel;
            tbl_alunos_cadastro_endereco = tela_ficha_aluno_endereco;
            tbl_alunos_cadastro_bairro = tela_ficha_aluno_bairro;
            tbl_alunos_cadastro_cidade = tela_ficha_aluno_cidade;
            tbl_alunos_cadastro_cep = tela_ficha_aluno_cep;
            tbl_alunos_cadastro_telefone = tela_ficha_aluno_telefone;
            tbl_alunos_cadastro_email = tela_ficha_aluno_email;
            tbl_alunos_cadastro_nome_contato_emergencia = tela_ficha_aluno_contato_emergencia;
            tbl_alunos_cadastro_tel_contato_emergencia_1 = tela_ficha_aluno_telefone_emergencia_1;
            tbl_alunos_cadastro_tel_contato_emergencia_2 = tela_ficha_aluno_telefone_emergencia_2;
        }
        #endregion Fim - Variaveis Tela Ficha de Alunos Tabela Alunos_Cadastro.

        #region Inicio - Variaveis Tela Cadastro de Planos para Tabela Planos_Cadastro

        public void Transfere_Cadastro_PlanosXTabela_Planos_Cadastro()
        {
            tbl_planos_cadastro_codigo = tela_cadastro_planos_codigo;
            tbl_planos_cadastro_nome = tela_cadastro_planos_nome;
            tbl_planos_cadastro_qtd_meses = Convert.ToInt32(tela_cadastro_planos_qtd_meses);
            tbl_planos_cadastro_qtd_aulas_semana = Convert.ToInt32(tela_cadastro_planos_qtd_aulas_semana);
            tbl_planos_cadastro_qtd_aulas_total = Convert.ToInt32(tela_cadastro_planos_qtd_aulas_total);
            tbl_planos_cadastro_valor_mensal = Convert.ToDouble(tela_cadastro_planos_valor_mensal);
            tbl_planos_cadastro_valor_total = Convert.ToDouble(tela_cadastro_planos_valor_total);
        }

        #endregion Fim - Variaveis Tela Cadastro de Planos para Tabela Planos_Cadastro

        #region Inicio - Variaveis Tela Pesquisa de Planos para Tabela Planos_Cadastro.
        public void Transfere_Pesquisa_PlanosXTabela_Planos_Cadastro()
        {
            tbl_planos_cadastro_codigo = tela_pesquisa_codigo_plano;
            tbl_planos_cadastro_nome = tela_pesquisa_nome_plano;
        }

        #endregion Fim - Variaveis Tela Pesquisa de Planos para Tabela Planos_Cadastro.

        #region Inicio - Variaveis Tela Ficha de Planos para Tabela Planos_Cadastro

        public void Transfere_Ficha_PlanoXTabela_Planos_Cadastro()
        {
            tbl_planos_cadastro_codigo = tela_ficha_planos_codigo;
            tbl_planos_cadastro_nome = tela_ficha_planos_nome;
            tbl_planos_cadastro_qtd_meses = Convert.ToInt32(tela_ficha_planos_qtd_meses);
            tbl_planos_cadastro_qtd_aulas_semana = Convert.ToInt32(tela_ficha_planos_qtd_aulas_semana);
            tbl_planos_cadastro_qtd_aulas_total = Convert.ToInt32(tela_ficha_planos_qtd_aulas_total);
            tbl_planos_cadastro_valor_mensal = Convert.ToDouble(tela_ficha_planos_valor_mensal);
            tbl_planos_cadastro_valor_total = Convert.ToDouble(tela_ficha_planos_valor_total);
            tbl_planos_cadastro_situacao = tela_ficha_planos_situacao;
        }

        #endregion Fim - Variaveis Tela Ficha de Planos para Tabela Planos_Cadastro

        #endregion Fim - Metodos que transfere dados entre variaveis.      

        #region Inicio - Metodo que valida os campos da Tela Cadastro de Aluno.
        public void Verifica_Campos_Tela_Cadastro_Aluno()
        {
            /*  Funcao -> Faz a validacao de o que foi digitado nos campos da ficha do aluno se esta de acordo com os
             *  parametros de gravacao no banco de dados.
             */

            while (string.IsNullOrEmpty(tela_cadastro_aluno_codigo))
            {
                mensagens.Mensagem_12();
                return;
            }
            while (!int.TryParse(tela_cadastro_aluno_codigo, out int verifica))
            {
                mensagens.Mensagem_12();
                return;
            }
            int positivo = Convert.ToInt32(tela_cadastro_aluno_codigo);
            if (positivo <= 0)
            {
                mensagens.Mensagem_12();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_cpf))
            {
                mensagens.Mensagem_34();
                return;
            }
            while (!int.TryParse(tela_cadastro_cpf, out int verifica))
            {
                mensagens.Mensagem_34();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_aluno_nome))
            {
                mensagens.Mensagem_13();
                return;
            }
            if (tela_cadastro_nome_responsavel == "")
            {
                tela_cadastro_nome_responsavel = "ALUNO MAIOR DE IDADE";
            }
            while (string.IsNullOrEmpty(tela_cadastro_endereco))
            {
                mensagens.Mensagem_14();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_bairro))
            {
                mensagens.Mensagem_15();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_cidade))
            {
                mensagens.Mensagem_16();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_cep))
            {
                mensagens.Mensagem_17();
                return;
            }
            while (!int.TryParse(tela_cadastro_cep, out int verifica))
            {
                mensagens.Mensagem_17();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_telefone))
            {
                mensagens.Mensagem_18();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_email))
            {
                mensagens.Mensagem_19();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_nome_contato_emergencia))
            {
                mensagens.Mensagem_20();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_tel_contato_emergencia_1))
            {
                mensagens.Mensagem_21();
                return;
            }
            if (tela_cadastro_tel_contato_emergencia_2 == "")
            {
                tela_cadastro_tel_contato_emergencia_2 = "NÃO INFORMADO";
            }
            campos_validados = true;
        }

        #endregion Fim - Metodo que valida os campos da Tela Cadastro de Aluno.

        #region Inicio - Metodo que cadastra ou atualiza os dados do aluno.    

        public void Cadastrar_Atualizar_Alunos_Cadastro()
        {
            /*   Funcao -> Metodo que cadastra ou atualiza os dados do aluno na tabela Alunos_Cadastro
             * - Primeiro valida se é um cadastro novo ou se algum cadastro foi alterado. Se a variavel
             *   Recebeu true, chama o metodo dos parametros da tabela Alunos_Cadastro.
             * - Se apos a criacao/alteracao do cadastro do aluno a variavel log for true, acrescenta 
             *   nos parametros a data de atualizacao e grava o log na tabela Alunos_Cadastro_Log. */

            if (e_cadastro == true || dados_alterados == true)
            {
                Parametros_Cadastro_Alunos();
            }
            if (e_log == true)
            {
                cmd.Parameters.Add("@Atualizado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;
            }
        }

        #endregion Fim - Metodo que cadastra ou atualiza os dados do aluno.    

        #region Inicio - Metodo que conecta e grava no banco.
        public void Executa_Banco()
        {
            /*   Funcao -> Metodo que faz a conexao com o banco e executa a gravacao/atualizacao dos dados.
             * - Faz o mysqlcommand receber a conexao do banco de dados chamando o metodo conectar_db.
             * - Após a conexao feita, executa a query com todos os parametros e dados repassados pelo sistema
             * - Depois de executado a query desconecta do banco de dados.
             * - Atribui na variavel Cad_ok o OK para identificar que os dados foram gravados com sucesso.
             * - Se o processo retornar algum erro, mostra a mensagem na tela e informa o erro.
             * - Se o processo retornou erro atribui tambem na variavel Cad_Ok o "Erro" para nao continuar com
             *   o processo de execucao. */

            try
            {
                cmd.Connection = conexao_Banco_PA.Conectar_DB();
                cmd.ExecuteNonQuery();
                conexao_Banco_PA.Desconectar_DB();

                Cad_Ok = "OK";
            }
            catch (MySqlException errodb)
            {
                mensagens.Mensagem_22(errodb.Message);
                DB_PA.Cad_Ok = "Erro";
            }
            conexao_Banco_PA.Desconectar_DB();
        }

        #endregion Fim - Metodo que conecta e grava no banco

        #region Inicio - Metodo que trata a imagem tbl Alunos_Imagem.
        public void Processa_Imagem()
        {
            /*   Funcao -> Recebe a imagem da tela de cadastro ou da tela de ficha de aluno atraves 
             *   do botao inserir imagem, faz o tratamento reduzindo o tamanho da imagem e incluindo
             *   o parametro para gravar na tabela Alunos_Imagem.
             *   - Executa o metodo se a variavel que controla o cadastro do aluno retornar OK ou se
             *     a variavel de atualizacao da imagem na tela de ficha de alunos for true.
             *   - Instancia o objeto para a classe de memoria FileStream de nome arquivo_imagem, 
             *     indica a variavel que contem o caminho da imagem do aluno, abre pelo filemode e 
             *     informa o tipo de acesso ao arquivo (apenas leitura).
             *   - A variavel imagem recebe da memoria a foto do aluno convertida em system/drawing para
             *     fazer o reducao.
             *   - Instancia o objeto para a classe MemoryStream (stream_imagem_menor) para receber a 
             *     imagem reduzida do aluno e guardar na memoria.
             *   - No try, usa a imagem no formato system/drawing (bitmap) para tentar fazer a reducao.
             *   - Usamos uma variavel para chamar o metodo ResizeImage que vai fazer a reducao e receber a imagem.
             *   - Apos reduzida pega a imagem salva no formato .png na variavel imagem_menor e tranfere para a
             *     a variavel da memoria (stream_imagem_menor). 
             *   - Como foi usado uma posicao na memoria, devemos voltar para a posicao 0 da memoria para poder fazer
             *     a leitura dessa posicao. 
             *   - Instanciamos um objeto para o BinaryReader para poder ler a imagem da memoria e tranformar em binario.
             *   - Apos transformado em binario, transferimos a imagem para o array de variavel, convertido em INT para que
             *     essa variavel possa ser utilizada para gravar na tabela Alunos_Imagem.
             *   - Caso esse processo falhe, chama o Catch mostrando a mensagem com o erro retornado.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados.
             *   - Se a variavel que identifica que é cadastro novo estiver como true, chama o metodo
             *     dos parametros de cadastro de imagem, acrescentando mais 2 parametros (criado em e
             *     atualizdo em) para informar a data de registro da imagem.
             *   - Se for atualizacao da imagem de um aluno que ja existe no cadastro, chama o metodo
             *     dos parametros de cadastro da imagem, acrescentando apenas o parametro atualizado em,
             *     para registrar a data de atualizacao da imagem. */

            if (Cad_Ok == "OK" || tbl_alunos_imagem_foto_alterada == true)
            {
                FileStream arquivo_imagem = new FileStream(tbl_alunos_imagem_caminho_foto_aluno, FileMode.Open, FileAccess.Read);
                var imagem = Image.FromStream(arquivo_imagem);
                MemoryStream stream_imagem_menor = new MemoryStream();
                try
                {
                    using (imagem)
                    {
                        var imagem_menor = ResizeImage(imagem, 145, 145);
                        imagem_menor.Save(stream_imagem_menor, ImageFormat.Png);
                        stream_imagem_menor.Position = 0;
                        BinaryReader binaryReader = new BinaryReader(stream_imagem_menor);
                        tbl_alunos_imagem_imagem_byte = binaryReader.ReadBytes((int)stream_imagem_menor.Length);
                    }
                }
                catch (Exception erro)
                {
                    mensagens.Mensagem_38("-->" + erro.Message);
                    Cad_Ok = "Erro";
                }
                //cmd.Parameters.Clear();
                if (e_cadastro == true)
                {
                    Parametros_Cadastro_Imagem_Alunos();
                    cmd.Parameters.Add("@Criado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;
                    cmd.Parameters.Add("@Atualizado_Em", MySqlDbType.Timestamp).Value = null;
                }
                else
                {
                    Parametros_Cadastro_Imagem_Alunos();
                    cmd.Parameters.Add("@Atualizado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;               // define a data de atualizacao da imagem.
                }
            }
        }
        #endregion Fim - Metodo que trata a imagem tbl Alunos_Imagem.


        #region Inicio - Metodo que valida os campos da Pesquisa do aluno.
        public void Verifica_Campos_Pesquisa_Aluno()
        {
            /*   Funcao -> Faz a validacao dos dados das variaveis da tela de pesquisa para
             *   para que nao contenha erros na busca.
             *   - As variaveis codigo do aluno e cpf so aceitam numeros ou em brando para
             *     que possa pesquisar tudo na tabela.
             */

            if (tela_pesquisa_codigo_aluno != "")
            {
                while (!int.TryParse(tela_pesquisa_codigo_aluno, out int verifica))
                {
                    mensagens.Mensagem_12();
                    return;
                }
            }
            if (tela_pesquisa_cpf_aluno != "")
            {
                while (!int.TryParse(tela_pesquisa_cpf_aluno, out int verifica))
                {
                    mensagens.Mensagem_34();
                    return;
                }
            }
            campos_validados = true;
        }

        #endregion Fim - Metodo que valida os campos da Pesquisa do aluno.

        #region Inicio - Metodo que executa a pesquisa nas tabelas.
        public void Executa_Pesquisa()
        {
            /*    Funcao -> Metodo que faz a conexao com o banco e executa a pesquisa de acordo com os
             *    parametros repassados pela tela de pesquisa de alunos ou pela tela de pesquisa de planos.
             *  - Chama o metodo de conexao com o banco.
             *  - Chama o metodo que executa o conteudo do Datareader de acordo com os parametros passados.
             *  - Se o datareader nao retornar dados pesquisados, encerra ele se ainda estiver aberto, encerra
             *    a conexao com o banco de dados e mostra a messagem na tela.
             *  - Caso tenha dados a retornar, primeiro limpa a variavel lista para nao ter informações anteriores.
             *  - Verifica se a variavel de pesquisar alunos esta como true para acessar o processo 
             *    de pesquisa de alunos.
             *  - Dentro de pesquisa de alunos, enquanto o datareader chamar o metodo de leitura e encontrar dados
             *    para ler, fica no looping adicionando na variavel lista, conforme os parametros definidos,
             *    os dados que foram encontrados.
             *  - No final atribui true na variavel retornou pesquisa para indicar que possui dados a serem mostrados.
             *  - E atribui falso na variavel da tela de pesquisar alunos para indicar que a pesquisa dessa tela finalizou.
             *  - Se a variavel de pesquisar planos estiver como true comeca o processo de pesquisa de planos.
             *  - Dentro de pesquisa de planos, enquanto o datareader chamar o metodo de leitura e encontrar dados
             *    para ler, fica no looping adicionando na variavel lista, conforme os parametros definidos,
             *    os dados que foram encontrados.
             *  - No final atribui true na variavel retornou pesquisa para indicar que possui dados a serem mostrados.
             *  - E atribui falso na variavel da tela de pesquisar planos para indicar que a pesquisa dessa tela finalizou.
             *  
             *    ACRESCENTAR PESQUISAR CODIGO DOS PLANOS.
             *    
             *  - Verifica de o datareader esta fechado. Se nao estiver chama o metodo de encerrar o datareader.
             *  - Caso o processo de pesquisar alunos ou de pesquisar planos falhe, mostra na tela a mensagem de erro.
             *  - No final encerra a conexao com o banco de dados.
             */

            try
            {
                cmd.Connection = conexao_Banco_PA.Conectar_DB();
                dataReader = cmd.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    if (!dataReader.IsClosed)
                    {
                        dataReader.Close();
                        conexao_Banco_PA.Desconectar_DB();
                    }
                    mensagens.Mensagem_02();
                }
                else
                {
                    lista.Clear();
                    if (pesquisar_aluno == true)
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(string.Join(null, "  Cod. | ", dataReader[0].ToString() + " | ",
                                                       "  Nome | ", dataReader[1].ToString() + " | ",
                                                       "  Nome do Responsável | ", dataReader[2].ToString() + " | ",
                                                       "  CPF | ", dataReader[3].ToString() + " | ",
                                                       "  Endereço | ", dataReader[4].ToString() + " | ",
                                                       "  Bairro | ", dataReader[5].ToString() + " | ",
                                                       "  Cidade | ", dataReader[6].ToString() + " | ",
                                                       "  CEP | ", dataReader[7].ToString() + " | ",
                                                       "  Telefone | ", dataReader[8].ToString() + " | ",
                                                       "  Email | ", dataReader[9].ToString() + " | ",
                                                       "  Nome do Contato de Emergencia | ", dataReader[10].ToString() + " | ",
                                                       "  Telefone de Emergencia 1 | ", dataReader[11].ToString() + " | ",
                                                       "  Telefone de Emergencia 2 | ", dataReader[12].ToString() + " | "));
                        }
                        retornou_pesquisa = true;
                        pesquisar_aluno = false;
                    }
                    if (pesquisar_planos == true)
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(string.Join(null, "  Cod_Plano | ", dataReader[0].ToString() + " | ",
                                                       "  Nome_Plano | ", dataReader[1].ToString() + " | ",
                                                       "  Qtd_Meses | ", dataReader[2].ToString() + " | ",
                                                       "  Qtd_Aulas_Semana| ", dataReader[3].ToString() + " | ",
                                                       "  Qtd_Aulas_Total | ", dataReader[4].ToString() + " | ",
                                                       "  Valor_Mensal_Plano | ", dataReader[5].ToString().Replace(".", ",") + " | ",
                                                       "  Valor_Anual_Plano | ", dataReader[6].ToString().Replace(".", ",") + " | ",
                                                       "  Situação_Plano | ", dataReader[7].ToString() + " | "));
                        }
                        retornou_pesquisa = true;
                        pesquisar_planos = false;
                    }
                    if (tela_financas_pesquisar_plano == true) // traz os codigos dos planos ou parcelas pendentes para a tela de financas.
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(string.Join(null, dataReader[0].ToString()));
                        }
                        tela_financas_pesquisar_plano = false;
                    }

                    if (pesquisar_situacao_aluno == true)
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(string.Join(null, dataReader[0].ToString()));
                            lista.Add(string.Join(null, dataReader[1].ToString()));
                        }
                        tbl_alunos_situacao_alunos_situacao = lista[0].ToString();
                        tbl_alunos_situacao_alunos_data_situacao = lista[1].ToString();
                        pesquisar_situacao_aluno = false;
                    }


                    //if (tela_financas_pesquisar_parcelas == true)
                    //{


                    //    int i = 0;
                    //    int z = 0;
                    //    string[,] parcelas = new string[i, z];

                    //    while (dataReader.Read())
                    //    {
                    //        i = 0;
                    //        parcelas[i, z] = dataReader[0].ToString();
                    //        parcelas[i, z] = dataReader[1].ToString(); i++;
                    //        parcelas[i, z] = dataReader[2].ToString(); i++;
                    //        parcelas[i, z] = dataReader[3].ToString(); i++;
                    //        parcelas[i, z] = dataReader[4].ToString(); i++;
                    //        z++;

                    //    }

                    //    tela_financas_pesquisar_parcelas = false;
                    //}

                }
                if (!dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            catch (MySqlException erro_db)
            {
                mensagens.Mensagem_04("-->" + erro_db.Message);
            }
            conexao_Banco_PA.Desconectar_DB();
        }
        #endregion Fim - Metodo que executa a pesquisa nas tabelas.


        #region Inicio - Metodo que trata selecao Ficha do Aluno.
        public void Alunos_Trata_Selecao()
        {
            /*    Funcao -> Metodo que é utilizado para separar o conteudo da variavel selecao, que é
             *    a variavel que contem as informacoes do aluno selecionado no checklistbox da tela de
             *    pesquisa de alunos e atribui nas variaveis da ficha do aluno.
             *  - Foi criado um array do tipo char chamado remove para retirar os caracteres indesejados.
             *  - Atribui no array separa_selecao os dados da variavel selecao, depois de removido os
             *    caracteres indesejados e também as entradas vazias.
             *  - Depois de separado, atribui nas variaveis da tela de ficha do aluno o conteudo da posicao
             *    do array correspondente a informacao que a variavel deve mostrar.
             */

            //Limpar_Variaveis_Ficha_Aluno();
            //char[] remove = new char[] { '|' };
            //tela_pesquisa_aluno_separa_selecao = tela_pesquisa_aluno_selecao.Split(remove, StringSplitOptions.RemoveEmptyEntries);
            //tela_ficha_aluno_codigo = tela_pesquisa_aluno_separa_selecao[1].ToString().Trim();
            //tela_ficha_aluno_nome = tela_pesquisa_aluno_separa_selecao[3].ToString().Trim();
            //tela_ficha_aluno_nome_responsavel = tela_pesquisa_aluno_separa_selecao[5].ToString().Trim();
            //tela_ficha_aluno_cpf = tela_pesquisa_aluno_separa_selecao[7].ToString().Trim();
            //tela_ficha_aluno_endereco = tela_pesquisa_aluno_separa_selecao[9].ToString().Trim();
            //tela_ficha_aluno_bairro = tela_pesquisa_aluno_separa_selecao[11].ToString().Trim();
            //tela_ficha_aluno_cidade = tela_pesquisa_aluno_separa_selecao[13].ToString().Trim();
            //tela_ficha_aluno_cep = tela_pesquisa_aluno_separa_selecao[15].ToString().Trim();
            //tela_ficha_aluno_telefone = tela_pesquisa_aluno_separa_selecao[17].ToString().Trim();
            //tela_ficha_aluno_email = tela_pesquisa_aluno_separa_selecao[19].ToString().Trim();
            //tela_ficha_aluno_contato_emergencia = tela_pesquisa_aluno_separa_selecao[21].ToString().Trim();
            //tela_ficha_aluno_telefone_emergencia_1 = tela_pesquisa_aluno_separa_selecao[23].ToString().Trim();
            //tela_ficha_aluno_telefone_emergencia_2 = tela_pesquisa_aluno_separa_selecao[25].ToString().Trim();
        }
        #endregion Fim - Metodo que trata selecao Ficha do Aluno.

        #region Inicio - Metodo que executa pesquisa imagem tbl Alunos_Imagem.
        public void Executa_Pesquisa_Imagem()
        {
            /*   Funcao -> Metodo que faz a execucao da pesquisa no banco, na tabela Alunos_Imagem e busca a foto do aluno.
             *   - Conecta no banco chamando o metodo de conexao do banco PA.
             *   - No try, o datareader faz a execucao da query e dos parametros recebidos.
             *   - Se o datareader encontrar dados (HasRows) de acordo com os parametros da pesquisa feita. 
             *   - Chama o metodo do datareader que faz a leitura dos dados encontrados.
             *   - Apos feita a leitura, transfere para o array de variavel o que foi lido pelo datareader, fazendo a 
             *     conversao em byte para depois ser tratado e mostrado na tela de ficha de aluno.
             *   - Se toda essa operacao retornou erro, faz o catch e mostra a mensagem de erro na tela.
             *   - No final se o Datareader ainda estiver aberto, chama o metodo que fecha o datareade e o metodo que
             *     desconecta o banco de dados PA.   
             */

            cmd.Connection = conexao_Banco_PA.Conectar_DB();
            try
            {
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    tbl_alunos_imagem_imagem_byte = (byte[])dataReader[0];
                }
            }
            catch (MySqlException erro_db)
            {
                mensagens.Mensagem_04("-->" + erro_db.Message);
            }
            if (!dataReader.IsClosed)
            {
                dataReader.Close();
                conexao_Banco_PA.Desconectar_DB();
            }
        }
        #endregion Fim - Metodo que executa pesquisa imagem tbl Alunos_Imagem.

        #region Inicio - Metodo dos parametros tbl Alunos_Imagem.
        public void Parametros_Cadastro_Imagem_Alunos()
        {
            /*   Funcao -> Define os parametros gerais para gravar na tabela Alunos_Imagem.
             *   - Limpa os parametros do Mysqlcomamand primeiro antes de atribuir novos dados.
             *   - Define o parametro do código do aluno pela variavel do codigo do cadastro do aluno.
             *   - Define o parametro da imagem do aluno pelo array de variavel pronta para gravar no banco. */

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = tbl_alunos_cadastro_codigo;
            cmd.Parameters.Add("@Imagem", MySqlDbType.LongBlob).Value = tbl_alunos_imagem_imagem_byte;
        }
        #endregion Fim - Metodo dos parametros tbl Alunos_Imagem.

        #region Inicio - Metodo que verifica alteracoes na ficha do aluno.
        public void Compara_Ficha_Aluno()
        {
            /*     Funcao -> Metodo que faz a verificacao se houve alteracoes na ficha do aluno
             *     comparando com as informaçoes que recebe do banco.
             *   - Primeiro verifica se houve alteracao na foto do aluno. Se houve alteração
             *     atribui true na variavel que valida se teve alteração.
             *   - Depois valida se o conteudo das variaveis da tela da ficha do aluno é igual ao
             *     conteudo das variaveis que recebe a consulta da tabela Alunos_Cadastro.
             *   - Se for igual atribui false na variavel que valida se teve alteração no dados do
             *     aluno, caso contrario, atribui true se houve alteracao.
             */

            if (tbl_alunos_imagem_caminho_foto_aluno != null)
            {
                tbl_alunos_imagem_foto_alterada = true;
            }

            // O CODIGO E CPF DA FICHA DO ALUNO NAO ESTAO HABILITADOS PARA EDICAO.
            //if (tela_ficha_aluno_codigo.ToString().Trim() == tbl_alunos_cadastro_codigo.ToString().Trim())
            //{ 

            if (tela_ficha_aluno_situacao == tbl_alunos_situacao_alunos_situacao.ToString().Trim())
            {
            }
            else { situacao_aluno_alterada = true; }

            if (tela_ficha_aluno_nome.ToString().Trim() == tbl_alunos_cadastro_nome.ToString().Trim())
            {
                if (tela_ficha_aluno_nome_responsavel.ToString().Trim() == tbl_alunos_cadastro_nome_responsavel.ToString().Trim())
                {
                    if (tela_ficha_aluno_endereco.ToString().Trim() == tbl_alunos_cadastro_endereco.ToString().Trim())
                    {
                        if (tela_ficha_aluno_bairro.ToString().Trim() == tbl_alunos_cadastro_bairro.ToString().Trim())
                        {
                            if (tela_ficha_aluno_cidade.ToString().Trim() == tbl_alunos_cadastro_cidade.ToString().Trim())
                            {
                                if (tela_ficha_aluno_cep.ToString().Trim() == tbl_alunos_cadastro_cep.ToString().Trim())
                                {
                                    if (tela_ficha_aluno_telefone.ToString() == tbl_alunos_cadastro_telefone.ToString())
                                    {
                                        if (tela_ficha_aluno_email.ToString().Trim() == tbl_alunos_cadastro_email.ToString().Trim())
                                        {
                                            if (tela_ficha_aluno_contato_emergencia.ToString().Trim() == tbl_alunos_cadastro_nome_contato_emergencia.ToString().Trim())
                                            {
                                                if (tela_ficha_aluno_telefone_emergencia_1.ToString().Trim() == tbl_alunos_cadastro_tel_contato_emergencia_1.ToString().Trim())
                                                {
                                                    if (tela_ficha_aluno_telefone_emergencia_2.ToString().Trim() == tbl_alunos_cadastro_tel_contato_emergencia_2.ToString().Trim())
                                                    {
                                                        dados_alterados = false;
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
            }
            else { dados_alterados = true; }

           //}
            //else { dados_alterados = true; }
        }

        #endregion Fim - Metodo que verifica alteracoes na ficha do aluno.

        #region Inicio - Metodo que valida os campos da Tela Ficha de Aluno.
        public void Verifica_Campos_Tela_Ficha_Aluno()
        {
            /*  Funcao -> Faz a validacao de o que foi digitado nos campos da ficha do aluno se esta de acordo com os
             *  parametros de gravacao no banco de dados.
             */

            /* O CAMPO DE CODIGO E CPF DO ALUNO NA FICHA DO ALUNO NAO ESTAO HABILITADOS PARA EDICAO.
            if (tela_ficha_aluno_codigo == null)
            {
                mensagens.Mensagem_12();
                return;
            }

            if (tela_ficha_aluno_cpf == null)
            {
                mensagens.Mensagem_34();
                return;
            }
            */
            while (string.IsNullOrEmpty(tela_ficha_aluno_nome))
            {
                mensagens.Mensagem_13();
                return;
            }
            if (tela_ficha_aluno_nome_responsavel == "")
            {
                tela_ficha_aluno_nome_responsavel = "ALUNO MAIOR DE IDADE";
            }
            while (string.IsNullOrEmpty(tela_ficha_aluno_endereco))
            {
                mensagens.Mensagem_14();
                return;
            }
            while (string.IsNullOrEmpty(tela_ficha_aluno_bairro))
            {
                mensagens.Mensagem_15();
                return;
            }
            while (string.IsNullOrEmpty(tela_ficha_aluno_cidade))
            {
                mensagens.Mensagem_16();
                return;
            }
            while (string.IsNullOrEmpty(tela_ficha_aluno_cep))
            {
                mensagens.Mensagem_17();
                return;
            }
            while (string.IsNullOrEmpty(tela_ficha_aluno_telefone))
            {
                mensagens.Mensagem_18();
                return;
            }
            while (string.IsNullOrEmpty(tela_ficha_aluno_email))
            {
                mensagens.Mensagem_19();
                return;
            }
            while (string.IsNullOrEmpty(tela_ficha_aluno_contato_emergencia))
            {
                mensagens.Mensagem_20();
                return;
            }
            while (string.IsNullOrEmpty(tela_ficha_aluno_telefone_emergencia_1))
            {
                mensagens.Mensagem_21();
                return;
            }
            if (tela_ficha_aluno_telefone_emergencia_2 == "")
            {
                tela_ficha_aluno_telefone_emergencia_2 = "NÃO INFORMADO";
            }
            campos_validados = true;
        }

        #endregion Fim - Metodo que valida os campos da Tela Ficha de Aluno.

        #region Inicio - Metodo Redimensiona Imagem.
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            /* Funcao -> Metodo que faz o redimensionamento da imagem e converte em png. O metodo faz
             * o processamento da imagem retornando para a variavel image (System/Drawing) no tamanho 
             * de largura e altura (Int)  */

            var destRect = new Rectangle(0, 0, width, height);
            var destImagem = new Bitmap(width, height);
            destImagem.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (var graphics = Graphics.FromImage(destImagem))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImagem;
        }

        #endregion Fim - Metodo Redimensiona Imagem.

        #region Inicio - Metodo Carrega Imagem do Aluno.

        public void Carrega_Imagem_Aluno()
        {
            /*  Funcao -> Metodo que carrega a imagem do aluno que foi selecionado na tela de
             *  pesquisa de aluno.
             *  - Cria um array de byte para receber o conteudo da variavel de imagem do banco.
             *  - Instancia o objeto do MemoryStream e envia para a memoria o array de byte.
             *  - A picturebox da tela de ficha do aluno recebe a imagem da memoria ja decodificada.
             *  - Chama o metodo de refresh da picturebox para atualizar e mostras a imagem do aluno.
             */

            byte[] imagem_byte = DB_PA.tbl_alunos_imagem_imagem_byte;
            MemoryStream memoryStream = new MemoryStream(imagem_byte);
            imagem_aluno = Image.FromStream(memoryStream);
        }

        #endregion Fim - Metodo Carrega Imagem do Aluno.

        #region Inicio - Metodo parametros tbl Aluno_Cadastro.
        public void Parametros_Cadastro_Alunos()
        {
            /* Funcao -> Atribui os dados recebidos das variaveis nos parametros do Mysqlcommand para depois
             * ser gravado no banco de daodos.
             * - Primeiro chama o metodo que faz a limpeza dos parametros que podem existir antes. 
             * - Atribui os parametros da variavel, informando o tipo da coluna no banco no Mysqlcommand. */

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = tbl_alunos_cadastro_codigo;
            cmd.Parameters.Add("@Alunos_CPF", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_cpf;
            cmd.Parameters.Add("@Alunos_Nome", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_nome;
            cmd.Parameters.Add("@Alunos_Nome_Responsavel", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_nome_responsavel;
            cmd.Parameters.Add("@Alunos_Endereco", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_endereco;
            cmd.Parameters.Add("@Alunos_Bairro", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_bairro;
            cmd.Parameters.Add("@Alunos_Cidade", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_cidade;
            cmd.Parameters.Add("@Alunos_CEP", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_cep;
            cmd.Parameters.Add("@Alunos_Telefone", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_telefone;
            cmd.Parameters.Add("@Alunos_Email", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_email;
            cmd.Parameters.Add("@Alunos_Contato_Emergencia", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_nome_contato_emergencia;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_1", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_tel_contato_emergencia_1;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_2", MySqlDbType.VarChar).Value = tbl_alunos_cadastro_tel_contato_emergencia_2;
        }
        #endregion - Fim - Metodo parametros tbl Aluno_Cadastro.


        #region Inicio - Metodo que valida os dados da tabela Planos_Cadastro.
        public void Verifica_Campos_Tela_Cadastro_Plano()
        {

            while (string.IsNullOrEmpty(tela_cadastro_planos_codigo))
            {
                mensagens.Mensagem_23();
                return;
            }
            while (string.IsNullOrEmpty(tela_cadastro_planos_nome))
            {
                mensagens.Mensagem_24();
                return;
            }
            while (!int.TryParse(tela_cadastro_planos_qtd_aulas_semana, out int verifica))
            {
                mensagens.Mensagem_25();
                return;
            }
            while (!int.TryParse(tela_cadastro_planos_qtd_aulas_total, out int verifica))
            {
                mensagens.Mensagem_26();
                return;
            }
            while (!double.TryParse(tela_cadastro_planos_valor_mensal, out double verifica))
            {
                mensagens.Mensagem_27();
                return;
            }
            while (!double.TryParse(tela_cadastro_planos_valor_total, out double verifica))
            {
                mensagens.Mensagem_28();
                return;
            }
            campos_validados = true;
        }

        #endregion Fim - Metodo que valida os dados da tabela Planos_Cadastro.

        #region Inicio - Metodo que cadastra ou atualiza os dados na tabela Planos_Cadastro.
        public void Cadastrar_Atualizar_Planos_Cadastro()
        {
            if (e_cadastro == true || dados_alterados == true)
            {
                Parametros_Cadastro_Plano();
            }
            if (e_log == true)
            {
                Parametros_Cadastro_Plano();
                cmd.Parameters.Add("@Atualizado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;   // Adiciona um parametro para inserir os valores encontrados.
                e_log = false;
            }
        }

        #endregion Fim - Metodo que cadastra ou atualiza os dados na tabela Planos_Cadastro.

        #region Inicio - Metodo dos parametros do plano.
        public void Parametros_Cadastro_Plano()
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Planos_Codigo", MySqlDbType.VarChar).Value = tbl_planos_cadastro_codigo;
            cmd.Parameters.Add("@Planos_Nome", MySqlDbType.VarChar).Value = tbl_planos_cadastro_nome;
            cmd.Parameters.Add("@Planos_Qtd_Meses", MySqlDbType.Int32).Value = tbl_planos_cadastro_qtd_meses;
            cmd.Parameters.Add("@Planos_Qtd_Aulas_Semana", MySqlDbType.Int32).Value = tbl_planos_cadastro_qtd_aulas_semana;
            cmd.Parameters.Add("@Planos_Qtd_Aulas_Total", MySqlDbType.Int32).Value = tbl_planos_cadastro_qtd_aulas_total;
            cmd.Parameters.Add("@Planos_Valor_Mensal", MySqlDbType.Double).Value = tbl_planos_cadastro_valor_mensal;
            cmd.Parameters.Add("@Planos_Valor_Total", MySqlDbType.Double).Value = tbl_planos_cadastro_valor_total;
            cmd.Parameters.Add("@Planos_Situacao", MySqlDbType.VarChar).Value = tbl_planos_cadastro_situacao;
        }

        #endregion Fim - Metodo dos parametros do plano.



        #region Inicio - Metodo que trata a variavel tela_pesquisa_planos_selecao e atribui nas variaves da ficha do plano.
        public void Tela_Planos_Trata_Selecao()
        {
            char[] remove = new char[] { '|' };                                                                         // Criando um array de variaveis com caracteres que serao removidos da selecao.
            tbl_pesquisa_planos_separa_selecao = planos_selecao.Split(remove, StringSplitOptions.RemoveEmptyEntries);    // Selecao2 recebe de selecao com os caracteres removidos.
            tela_ficha_planos_codigo = tbl_pesquisa_planos_separa_selecao[1].ToString().Trim();                                     // Textbox recebe o valor da variavel selecao na posicao 1.
            tela_ficha_planos_nome = tbl_pesquisa_planos_separa_selecao[3].ToString().Trim();                                       // Textbox recebe o valor da variavel selecao na posicao 3.
            tela_ficha_planos_qtd_meses = tbl_pesquisa_planos_separa_selecao[5].ToString().Trim();
            tela_ficha_planos_qtd_aulas_semana = tbl_pesquisa_planos_separa_selecao[7].ToString().Trim();                           // Textbox recebe o valor da variavel selecao na posicao 5.
            tela_ficha_planos_qtd_aulas_total = tbl_pesquisa_planos_separa_selecao[9].ToString().Trim();                            // Textbox recebe o valor da variavel selecao na posicao 7.
            tela_ficha_planos_valor_mensal = tbl_pesquisa_planos_separa_selecao[11].ToString().Trim();                             // Textbox recebe o valor da variavel selecao na posicao 9.
            tela_ficha_planos_valor_total = tbl_pesquisa_planos_separa_selecao[13].ToString().Trim();                             // Textbox recebe o valor da variavel selecao na posicao 11.
            tela_ficha_planos_situacao = tbl_pesquisa_planos_separa_selecao[15].ToString().Trim();                                  // Textbox recebe o valor da variavel selecao na posicao 13.
        }

        #endregion Fim - Metodo que trata a variavel tela_pesquisa_planos_selecao e atribui nas variaves da ficha do plano.

        #region Inicio - Metodo que valida os dados da Tela Ficha Plano.
        public void Verifica_Campos_Tela_Ficha_Plano()
        {
            campos_validados = false;

            while (string.IsNullOrEmpty(tela_ficha_planos_codigo))
            {
                mensagens.Mensagem_23();
                return;
            }
            while (string.IsNullOrEmpty(tela_ficha_planos_nome))
            {
                mensagens.Mensagem_24();
                return;
            }
            while (!int.TryParse(tela_ficha_planos_qtd_aulas_semana, out int verifica))
            {
                mensagens.Mensagem_25();
                return;
            }
            while (!int.TryParse(tela_ficha_planos_qtd_aulas_total, out int verifica))
            {
                mensagens.Mensagem_26();
                return;
            }
            while (!double.TryParse(tela_ficha_planos_valor_mensal, out double verifica))
            {
                mensagens.Mensagem_27();
                return;
            }
            while (!double.TryParse(tela_ficha_planos_valor_total, out double verifica))
            {
                mensagens.Mensagem_28();
                return;
            }
            campos_validados = true;
        }

        #endregion Fim - Metodo que valida os dados da Tela Ficha Plano.

        #region Inicio - Metodo que compara a ficha do Plano com a tabela Planos_Cadastro.
        public void Compara_Ficha_Planos()
        {
            dados_alterados = false;                                                                // Atribui falso a variavel dados alterados primeiro.

            if (tela_ficha_planos_codigo.ToString().Trim() == tbl_planos_cadastro_codigo.ToString().Trim())
            {
                if (tela_ficha_planos_nome.ToString().Trim() == tbl_planos_cadastro_nome.ToString().Trim())
                {
                    if (tela_ficha_planos_qtd_meses.ToString().Trim() == tbl_planos_cadastro_qtd_meses.ToString().Trim())
                    {
                        if (tela_ficha_planos_qtd_aulas_semana.ToString().Trim() == tbl_planos_cadastro_qtd_aulas_semana.ToString().Trim())
                        {
                            if (tela_ficha_planos_qtd_aulas_total.ToString().Trim() == tbl_planos_cadastro_qtd_aulas_total.ToString().Trim())
                            {
                                if (tela_ficha_planos_valor_mensal.ToString().Trim() == tbl_planos_cadastro_valor_mensal.ToString().Trim())
                                {
                                    if (tela_ficha_planos_valor_total.ToString().Trim() == tbl_planos_cadastro_valor_total.ToString().Trim())
                                    {
                                        if (tela_ficha_planos_situacao.ToString().Trim() == tbl_planos_cadastro_situacao.ToString().Trim())
                                        {
                                            dados_alterados = false;
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

        #endregion Fim - Metodo que compara a ficha do Plano com a tabela Planos_Cadastro.

        #region Inicio - Metodo que executa pesquisa do log na tabela Alunos_Cadastro_Log ou Planos_Cadastro_Log (HISTORICO).

        public void Executa_Pesquisa_Log()
        {
            //if (frm_historico.volta_ficha_aluno == true)
            //{
            //    query = "SELECT * from Alunos_Cadastro_log WHERE Alunos_Codigo =" + tbl_alunos_cadastro_codigo;      // variavel que recebe o comando para executar no mysql + o que esta na variavel.

            //}
            //else if (frm_historico.volta_ficha_plano == true)
            //{
            //    query = "SELECT * from Planos_Cadastro_log WHERE Planos_Codigo LIKE" + "'" + DB_PA.tbl_planos_cadastro_codigo.Trim() + "'";      // variavel que recebe o comando para executar no mysql + o que esta na variavel.
            //}

            Executa_Datagrid();


            //cmd.Connection = conexao_Banco_PA.Conectar_DB();            // Conecta no banco de dados da PA.
            //cmd.CommandText = query;                                    // Repassa a query para o mysqlcommand.
            //MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);   // Instanciando objeto dataadapter que faz a consulta no mysql.
            //dataAdapter.Fill(dataTable);                                // dataadapter preenche o datatable.
            //log = dataTable;                                            // objeto log recebe o datatable.
            //cmd.Connection.Close();                                     // Encerra a conexao.
        }

        #endregion Fim - Metodo que executa pesquisa do log na tabela Alunos_Cadastro_Log ou Planos_Cadastro_Log (HISTORICO).

        #region Inicio - Metodos de Limpeza de Variaveis.

        #region Inicio - Metodo que limpa variaveis tbl Alunos_Cadastro e tlb Alunos_Cadastro_Log.
        public void Limpar_Variaveis_Tbl_Alunos_Cadastro()
        {
            /* Funcao -> Faz a limpeza das variaveis antes de receber novos valores. */

            tbl_alunos_cadastro_codigo = 0;
            tbl_alunos_cadastro_cpf =
            tbl_alunos_cadastro_nome =
            tbl_alunos_cadastro_nome_responsavel =
            tbl_alunos_cadastro_endereco =
            tbl_alunos_cadastro_bairro =
            tbl_alunos_cadastro_cidade =
            tbl_alunos_cadastro_cep =
            tbl_alunos_cadastro_telefone =
            tbl_alunos_cadastro_email =
            tbl_alunos_cadastro_nome_contato_emergencia =
            tbl_alunos_cadastro_tel_contato_emergencia_1 =
            tbl_alunos_cadastro_tel_contato_emergencia_2 =
            tbl_alunos_cadastro_log_atualizado_em = null;
        }

        #endregion Fim - Metodo que limpa variaveis tbl Alunos_Cadastro e tlb Alunos_Cadastro_Log.

        #region Inicio - Metodo que limpa variaveis tbl Planos_Cadastro e tbl Planos_Cadastro_Log.

        public void Limpar_Variaveis_Tbl_Planos_Cadastro()
        {
            tbl_planos_cadastro_codigo = "";
            tbl_planos_cadastro_nome = "";
            tbl_planos_cadastro_qtd_meses = 0;
            tbl_planos_cadastro_qtd_aulas_semana = 0;
            tbl_planos_cadastro_qtd_aulas_total = 0;
            tbl_planos_cadastro_valor_mensal = 0;
            tbl_planos_cadastro_valor_total = 0;
            tbl_planos_cadastro_situacao = "";
            tbl_planos_cadastro_log_atualizado_em = null;
        }

        #endregion Fim - Metodo que limpa variaveis tbl Planos_Cadastro e tbl Planos_Cadastro_Log.

        #region Inicio - Metodo que limpa variaveis tbl_Alunos_Situacao.

        public void Limpar_Variaveis_Tbl_Alunos_Situacao()
        {
            tbl_alunos_situacao_alunos_codigo = 0;
            tbl_alunos_situacao_alunos_situacao = null;
        }


        #endregion Fim - Metodo que limpa variaveis tbl_Alunos_Situacao.

        #region Inicio - Metodo Limpa variaveis tela Cadastro de Alunos.
        public void Limpar_Variaveis_Cadastro_Aluno()
        {
            tela_cadastro_aluno_situacao =
            tela_cadastro_aluno_codigo =
            tela_cadastro_cpf =
            tela_cadastro_aluno_nome =
            tela_cadastro_nome_responsavel =
            tela_cadastro_endereco =
            tela_cadastro_bairro =
            tela_cadastro_cidade =
            tela_cadastro_cep =
            tela_cadastro_telefone =
            tela_cadastro_email =
            tela_cadastro_nome_contato_emergencia =
            tela_cadastro_tel_contato_emergencia_1 =
            tela_cadastro_tel_contato_emergencia_2 = null;
        }
        
        #endregion Fim - Metodo Limpa variaveis tela Cadastro de Alunos.

        #region Inicio - Metodo Limpa variaveis tela Ficha do Aluno.
        public void Limpar_Variaveis_Ficha_Aluno()
        {
            /*    Funcao -> Metodo que faz a limpeza das variaveis da tela de ficha do aluno.
             *  - Se o array de variavel que separa os dados da variavel selecao estiver com conteudo,
             *    executa o metodo de limpeza de array para a separa_selecao desde a posicao 0.
             *  - Atribui -1 nas variaveis de codigo e cpf porque nao da para declarar como null.
             *  - Atribui null para todas as outras variaveis da tela de ficha do aluno.
             */

            if (tela_pesquisa_aluno_separa_selecao != null)
            {
                Array.Clear(tela_pesquisa_aluno_separa_selecao, 0, tela_pesquisa_aluno_separa_selecao.Length);
            }
            tela_ficha_aluno_situacao =
            tela_ficha_aluno_codigo =
            tela_ficha_aluno_cpf =
            tela_ficha_aluno_nome =
            tela_ficha_aluno_nome_responsavel =
            tela_ficha_aluno_endereco =
            tela_ficha_aluno_bairro =
            tela_ficha_aluno_cidade =
            tela_ficha_aluno_cep =
            tela_ficha_aluno_telefone =
            tela_ficha_aluno_email =
            tela_ficha_aluno_contato_emergencia =
            tela_ficha_aluno_telefone_emergencia_1 =
            tela_ficha_aluno_telefone_emergencia_2 = null;
        }

        #endregion Fim - Metodo Limpa variaveis tela Ficha do Aluno.

        #region Inicio - Metodo Limpa variaveis tela Ficha de Planos.

        public void Limpar_Variaveis_Ficha_Plano()
        {
            if (tbl_pesquisa_planos_separa_selecao != null)
            {
                Array.Clear(tbl_pesquisa_planos_separa_selecao, 0, tbl_pesquisa_planos_separa_selecao.Length);
            }

            tela_ficha_planos_codigo =
            tela_ficha_planos_nome =
            tela_ficha_planos_qtd_meses =
            tela_ficha_planos_qtd_aulas_semana =
            tela_ficha_planos_qtd_aulas_total =
            tela_ficha_planos_valor_mensal =
            tela_ficha_planos_valor_total =
            tela_ficha_planos_situacao = null;
        }

        #endregion Fim - Metodo Limpa variaveis tela Ficha de Planos.


        #endregion Fim - Metodos de Limpeza de Variaveis.


        #endregion VALIDADO


        public void Executa_Datagrid()
        {
            cmd.Connection = conexao_Banco_PA.Conectar_DB();            // Conecta no banco de dados da PA.
            cmd.CommandText = query;                                    // Repassa a query para o mysqlcommand.
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);   // Instanciando objeto dataadapter que faz a consulta no mysql.
            dataAdapter.Fill(dataTable);                                // dataadapter preenche o datatable.
            log = dataTable;                                            // objeto log recebe o datatable.
            cmd.Connection.Close();                                     // Encerra a conexao.
        }

        #region Inicio - Metodo Atualizar Foto e Dados do Aluno.

        public void Atualizar_Foto_e_Dados_do_Aluno()
        {
            Query_Atualizar_Cadastro_Aluno();
            Cadastrar_Atualizar_Alunos_Cadastro();
            Executa_Banco();
            Query_Alterar_Imagem();
            Processa_Imagem();
            Executa_Banco();
            e_log = true;
            Log_Query_Cadastrar_Aluno();
            Cadastrar_Atualizar_Alunos_Cadastro();
            Executa_Banco();
            dados_alterados = false;
            campos_validados = false;
        }

        #endregion Fim - Metodo Atualizar Foto e Dados do Aluno.

        #region Inicio - Metodo Atualizar Dados do Aluno.
        public void Atualizar_Dados_do_Aluno()
        {
            Query_Atualizar_Cadastro_Aluno();
            Cadastrar_Atualizar_Alunos_Cadastro();
            Executa_Banco();
            e_log = true;
            Log_Query_Cadastrar_Aluno();
            Cadastrar_Atualizar_Alunos_Cadastro();
            Executa_Banco();
            dados_alterados = false;
            campos_validados = false;
        }

        #endregion Fim - Metodo Atualizar Dados do Aluno.

        #region Inicio - Metodo Atualizar Foto do Aluno.
        public void Atualizar_Foto_do_Aluno()
        {
            Query_Alterar_Imagem();
            Processa_Imagem();
            Executa_Banco();
        }

        #endregion Fim - Metodo Atualizar Foto do Aluno.

        #region Inicio - Metodo Atualizar Situacao do Aluno.

        public void Atualizar_Situacao_do_Aluno()
        {
            Query_Inserir_Situacao_Aluno();
            Parametros_Inserir_Situacao_Alunos();
            Executa_Banco();
            situacao_aluno_alterada = false;
        }

        #endregion Fim - Metodo Atualizar Situacao do Aluno.

        #region Inicio - Metodo Transfere Ficha do Aluno para Tabela Situacao_Aluno.

        public void Transfere_Ficha_AlunoXTabela_Alunos_Situacao()
        {
            Limpar_Variaveis_Tbl_Alunos_Situacao();
            tbl_alunos_situacao_alunos_codigo = Convert.ToInt32(tela_ficha_aluno_codigo);
        }


        #endregion Fim - Metodo Transfere Ficha do Aluno para Tabela Situacao_Aluno.


        #region Inicio - Metodo Query Inserir Situacao Aluno tbl Alunos_Situacao.

        public void Query_Inserir_Situacao_Aluno()
        {
            query = "INSERT INTO Alunos_Situacao VALUES (@Alunos_Codigo, @Alunos_Situacao, @Alunos_Data_Situacao_Alterada)";

            cmd.CommandText = query;
        }

        #endregion Fim - Metodo Query Inserir Situacao Aluno tbl Alunos_Situacao.



        #region Inicio - Tabela Alunos Situacao.

        public static int    tbl_alunos_situacao_alunos_codigo;
        public static string tbl_alunos_situacao_alunos_situacao,
                             tbl_alunos_situacao_alunos_data_situacao;

        #endregion Fim - Tabela Alunos Situacao.


        #region Inicio - Query Pesquisar Situacao Aluno tbl Alunos_Situacao.

        public void Query_Pesquisar_Situacao_Aluno()
        {
            query = "SELECT Alunos_Situacao, DATE_FORMAT(Alunos_Data_Situacao_Alterada,'%d') FROM Alunos_Situacao ORDER BY Alunos_Data_Situacao_Alterada DESC LIMIT 1";
            cmd.CommandText = query;
            pesquisar_situacao_aluno = true;
        }
        
        #endregion Fim - Query Pesquisar Situacao Aluno tbl Alunos_Situacao.


        #region Inicio - Metodo paramentros tbl Alunos_Situacao.

        public void Parametros_Inserir_Situacao_Alunos()
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = tbl_alunos_situacao_alunos_codigo;
            cmd.Parameters.Add("@Alunos_Situacao", MySqlDbType.VarChar).Value = tbl_alunos_situacao_alunos_situacao;
            cmd.Parameters.Add("@Alunos_Data_Situacao_Alterada", MySqlDbType.Timestamp).Value = DateTime.Now;
        }

        #endregion Fim - Metodo parametros tbl Alunos_Situacao.

        #region Inicio - Variaveis Tela Cadastro Alunos para Tabela Alunos_Situacao.

        public void Transfere_Situacao_AlunoXTabela_Alunos_Situacao()
        {
            Limpar_Variaveis_Tbl_Alunos_Situacao();
            tbl_alunos_situacao_alunos_situacao = tela_cadastro_aluno_situacao;
            tbl_alunos_situacao_alunos_codigo = Convert.ToInt32(tela_cadastro_aluno_codigo);
        }

        #endregion Fim - Variaveis Tela Cadastro Alunos para Tabela Alunos_Situacao.

        #region Inicio - Variaveis da tela de Financas do Aluno.

        public object tela_financas_parcelas;
        public static int tela_financas_numero_parcela = 1;
        public static int tela_financas_codigo_aluno,
                                tela_financas_dia_plano,
                                tela_financas_mes_plano,
                                tela_financas_ano_plano;
        public static string tela_financas_data_parcelas,
                                tela_financas_Label_Parcela_Pendente,
                                tela_financas_nome_aluno,
                                tela_financas_codigo_plano,
                                tela_financas_nome_plano,
                                tela_financas_data_pagamento,
                                tela_financas_qtd_meses_parcelas;
        public static double tela_financas_valor_mensal,
                                tela_financas_valor_total;
        public static bool tela_financas_pesquisar_plano;
        public static Image imagem_aluno;

        #endregion Fim - Variaveis da tela de Financas do Aluno.

        #region Inicio - Metodo Transfere Informacoes para Tela Financas do Aluno.

        public void Transfere_Informacoes_TBLXInicio_Financas_Aluno()
        {
            tela_financas_codigo_aluno = tbl_alunos_cadastro_codigo;
            tela_financas_nome_aluno = tbl_alunos_cadastro_nome;
        }

        #endregion Fim - Metodo Transfere Informacoes para Tela Financas do Aluno.



        #region Inicio - Tela Financas do Aluno.

        #region Inicio - Metodo Query buscar plano tela Financas do Aluno.

        public void Tela_Financas_Busca_Codigo_Plano()
        {
            cmd.Parameters.Clear();                                                             // Faz a limpeza dos parametros antes de incluir novos.
            query = "SELECT Planos_Codigo from Planos_Cadastro WHERE Planos_Situacao = 'ATIVO' ";
            cmd.CommandText = query;                                                            // Repassa a variavel query para os comandos do mysql.
        }

        #endregion Fim - Metodo Query buscar plano tela Financas do Aluno.

        #region Inicio - Metodo Trata Selecao Tela Financas do Aluno.

        public void Tela_Financas_Trata_Selecao_Plano()
        {
            char[] remove = new char[] { '|' };                                                                         // Criando um array de variaveis com caracteres que serao removidos da selecao.
            tbl_pesquisa_planos_separa_selecao = planos_selecao.Split(remove, StringSplitOptions.RemoveEmptyEntries);    // Selecao2 recebe de selecao com os caracteres removidos.
            tela_financas_codigo_plano = tbl_pesquisa_planos_separa_selecao[1].ToString().Trim();                                     // Textbox recebe o valor da variavel selecao na posicao 1.
            tela_financas_nome_plano = tbl_pesquisa_planos_separa_selecao[3].ToString().Trim();                                       // Textbox recebe o valor da variavel selecao na posicao 3.
            tela_financas_qtd_meses_parcelas = tbl_pesquisa_planos_separa_selecao[5].ToString().Trim();
            tela_financas_valor_mensal = Convert.ToDouble(tbl_pesquisa_planos_separa_selecao[11].ToString().Trim());
            tela_financas_valor_total = Convert.ToDouble(tbl_pesquisa_planos_separa_selecao[13].ToString().Trim());
        }

        #endregion Fim - Metodo Trata Selecao Tela Financas do Aluno.

        #region Inicio - Metodo Query Incluir Plano para Aluno.

        public void Incluir_Plano_Base_Aluno()
        {
            query = "INSERT INTO Alunos_Pagamentos (Alunos_Codigo, Planos_Codigo, Data_Plano_Contratado, Numero_Parcela," +
                                                    "Valor_Parcela, Data_Vencimento, Data_Pagamento, Valor_Pago, Situacao_Pagamento, Observacoes) " +
                                                    "VALUES (@Aluno_Codigo, @Plano_Codigo, @Data_Plano_Contratado, @Numero_Parcela," +
                                                    "@Valor_Parcela, @Data_Vencimento, @Data_Pagamento, @Valor_Pago, @Situacao_Pagamento, @Observacoes)";
            cmd.CommandText = query;
            Parametros_Incluir_Plano_Aluno();
        }

        #endregion Fim - Metodo Query Incluir Plano para Aluno.

        #region Inicio - Metodo Query Consulta Parcelas pendentes Aluno.

        public void Consultar_Parcelas_Pendentes()
        {
            query = "SELECT Planos_Codigo, Numero_Parcela, Valor_Parcela, Data_Vencimento, Situacao_Pagamento " +
                    "FROM `Alunos_Pagamentos` WHERE Situacao_Pagamento = 'Pendente'";
            cmd.CommandText = query;

            cmd.Connection = conexao_Banco_PA.Conectar_DB();            // Conecta no banco de dados da PA.
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);   // Instanciando objeto dataadapter que faz a consulta no mysql.
            dataAdapter.Fill(dataTable);                                // dataadapter preenche o datatable.
            tela_financas_parcelas = dataTable;                         // objeto log recebe o datatable.
            cmd.Connection.Close();                                     // Encerra a conexao.

        }

        #endregion Fim - Metodo Query Consulta Parcelas pendentes Aluno.


        #region Inicio - Parametros para Incluir Plano para Aluno.

        public void Parametros_Incluir_Plano_Aluno()
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Aluno_Codigo", MySqlDbType.Int32).Value = tela_financas_codigo_aluno;
            cmd.Parameters.Add("@Plano_Codigo", MySqlDbType.VarChar).Value = tela_financas_codigo_plano;
            cmd.Parameters.Add("@Data_Plano_Contratado", MySqlDbType.DateTime).Value = Convert.ToDateTime(frm_financas_aluno.tela_financas_data_plano_contratado);
            cmd.Parameters.Add("@Numero_parcela", MySqlDbType.VarChar).Value = tela_financas_numero_parcela;
            cmd.Parameters.Add("@valor_Parcela", MySqlDbType.VarChar).Value = tela_financas_valor_mensal;
            cmd.Parameters.Add("@Data_Vencimento", MySqlDbType.DateTime).Value = Convert.ToDateTime(tela_financas_data_parcelas);
            cmd.Parameters.Add("@data_Pagamento", MySqlDbType.DateTime).Value = null;
            cmd.Parameters.Add("@Valor_Pago", MySqlDbType.Double).Value = null;
            cmd.Parameters.Add("@Situacao_Pagamento", MySqlDbType.VarChar).Value = "Pendente";
            cmd.Parameters.Add("@Observacoes", MySqlDbType.String).Value = null;
        }

        #endregion Fim -  Parametros para Incluir Plano para Aluno.

        #endregion Fim - Tela Financas do Aluno.



        #region Metodos comentados que serao usados depois.

        //if (pesquisa_codigo_plano == true)
        //{
        //    frm_ficha_planos.selecao = (string)lista[0];
        //    pesquisa_codigo_plano = false;
        //}


        #region VERIFICAR ESTA PARTE DE FICHA DO ALUNO.
        //if (pesquisa_codigo_aluno == true)
        //{
        //    frm_ficha_alunos.selecao = (string)lista[0];
        //    pesquisa_codigo_aluno = false;
        //}
        //pesquisar_alunos = false;

        #endregion


        #region Carrega a alteracao na ficha do aluno.

        //DB_PA.pesquisar_alunos = true;
        //dB_PA.Limpar_Variaveis_Alunos();
        //DB_PA.Alunos_Codigo = txtb_codigo.Text.Trim();
        //btn_limpar.PerformClick();

        //if (DB_PA.dados_alterados == true || DB_PA.foto_alterada == true)           // Se foi alterado.
        //{

        //    dB_PA.Pesquisar_pelo_Codigo_tbl_alunos_cadastro();                      // Chama o metodo para pesquisar pelo codigo.
        //    dB_PA.Executa_Pesquisa();                                               // Chama o metodo que executa a pesquisa.
        //    Carrega_Ficha_Aluno();                                                  // Chama o metodo que carrega a ficha do aluno.
        //    DB_PA.dados_alterados = false;
        //}
        #endregion

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