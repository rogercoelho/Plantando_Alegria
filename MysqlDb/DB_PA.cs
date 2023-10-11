﻿using MySql.Data.MySqlClient;
using Plantando_Alegria.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Plantando_Alegria.MysqlDb
{
    public class DB_PA
    {
        public static string Cad_Ok;        // string para a limpeza do textbox
        public static string openfile2 = (string)frm_cadastro_alunos.caminho_openfile;

        #region Metodo de Cadastro de Alunos.
        public static void Cadastrar_Aluno(Alunos_Cadastro_mysql alunos_cadastro_mysql)   // Metodo que recebe 2 valores.
        {            
            string query = "INSERT INTO Alunos_Cadastro VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_Telefone, @Alunos_Email," +
                                                                "@Alunos_Endereco, @Alunos_Bairro, @Alunos_Cidade, @Alunos_CEP," +
                                                                "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                                "@Alunos_Telefone_Emergencia_2, @Criado_Em)";
                                                            // Variavel que recebe a query do mysql.

            Conexao_Banco_PA Conexao_Banco_PA = new Conexao_Banco_PA();     // Instancia o objeto para a classe Conexao_Banco_PA.
            MySqlCommand cmd = new MySqlCommand();                          // Instancia o objeto para a classe MySqlCommand.
            cmd.CommandText = query;                                        // A query é repassada para o CommandText dos comandos mysql.

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

            try
            {
                cmd.Connection = Conexao_Banco_PA.Conectar_DB();        // Tenta fazer a conexao com o Banco chamando o metodo Conectar_DB da classe Conexao_Banco_PA
                cmd.ExecuteNonQuery();                                  // Comando que excuta a Query.
                Conexao_Banco_PA.Desconectar_DB();

                MessageBox.Show("Cadastro Realizado com Sucesso\n", "Plantando Alegria - Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                DB_PA.Cad_Ok = "OK";
                                
            }
            catch (MySqlException errodb)       // Caso dê erro, mostra o erro do banco de dados.
            {
                MessageBox.Show("Erro ao Efetuar Cadastro.\n" + errodb.Message, "Plantando Alegria - Erro",  MessageBoxButtons.OK, MessageBoxIcon.Error);

                DB_PA.Cad_Ok = "Erro";
            }

            Conexao_Banco_PA.Desconectar_DB();  // Chama o metodo Desconectar_DB da classe Conexao_Banco_Pa. (Desconecta do banco).

        }

        #endregion

        #region Metodo de inserir imagem do aluno

        public static void Inserir_Imagem(Alunos_Imagem_mysql alunos_Imagem_Mysql)  // Metdodo que recebe 2 valores.
        {
            DB_PA dB_PA = new DB_PA();

            string query = "INSERT INTO Alunos_Imagem VALUES (@Alunos_Codigo, @Alunos_Imagem, @Criado_Em)";  // variavel que recebe a query do banco.

            Conexao_Banco_PA Conexao_Banco_PA = new Conexao_Banco_PA();     // Instanciando objeto para a classe Conexao_Banco_PA.
            MySqlCommand cmd = new MySqlCommand();                          // Instanciando objeto para a classe MysqlCommand.
            cmd.CommandText = query;                                        // variavel com a query sendo repassada para dentro do MysqlCommand.

            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = alunos_Imagem_Mysql.Alunos_Codigo;          // Parametros do Banco que Adiciona na coluna da query
            cmd.Parameters.Add("@Alunos_Imagem", MySqlDbType.LongBlob).Value = dB_PA.Imagem();                           // O tipo da coluna (longblob) Recebe o valor de alunos_imagem_mysql.
            cmd.Parameters.Add("@Criado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;                                 
                                                                                                                         
            try                                                                                                         
            {                                                                                                           
                cmd.Connection = Conexao_Banco_PA.Conectar_DB();    // Conecta no banco de dados
                cmd.ExecuteNonQuery();                              // Executa query.
                Conexao_Banco_PA.Desconectar_DB();                  // Desconecta do banco de dados.

            }
            catch (MySqlException errodb)       // Caso de erro de conexao com o banco, retorna a mesaggem de erro.
            {

            }
            Conexao_Banco_PA.Desconectar_DB();
        }

        #endregion

        #region Metodo que trata a imagem para inserir no banco.
        
        private byte[] Imagem()             // Metodo private que retorna um array de byte para a foto ser inserida
                                            // na tabela Alunos_Imagem, na coluna Alunos_Imagem do tipo longblob.
        {
            
            byte[] imagem_byte = null;      // Crio uma variavel do tipo array de byte e inicio com nulo.
            if ( openfile2 == "")
            {
                return null;
            }
            
            FileStream arquivo_imagem = new FileStream(openfile2, FileMode.Open, FileAccess.Read);
            BinaryReader binary_reader = new BinaryReader(arquivo_imagem);

            imagem_byte = binary_reader.ReadBytes((int)arquivo_imagem.Length);

            return imagem_byte;
        }
       

        



        #endregion


        //public static void Atualizar_Cadastro (Alunos_Cadastro_mysql alunos_cadastro, string id)
        //{
        //    //string sql_sintaxe = "Insert into Cadastro_Alunos (Aluno_Codigo, Aluno_Nome, Aluno_Telefone, Aluno_Email," +    // Str_sql recebe a sintaxe do banco mysql.
        //    //                                       "Aluno_Endereco, Aluno_Bairro, Aluno_Cidade, Aluno_CEP," +               // Str_sql recebe a sintaxe do banco mysql.
        //    //                                       "Aluno_Contato_Emergencia, Aluno_Telefone_Emergencia_1," +               // Str_sql recebe a sintaxe do banco mysql.
        //    //                                       "Aluno_Telefone_Emergencia_2) Values(?,?,?,?,?,?,?,?,?,?,?)";            // Str_sql recebe a sintaxe do banco mysql.

        //    string sql_sintaxe = "UPDATE Alunos_Cadastro SET Alunos_Nome = @Alunos_Nome, Alunos_Endereco =@Alunos_Endereco, Alunos_Bairro = @Alunos_Bairro," +
        //                                                   " Alunos_Cidade = @Alunos_Cidade, Alunos_CEP = @Alunos_CEP, " +
        //                                                   " Alunos_Contato_Emergencia = @Alunos_Contato_Emergencia, " +
        //                                                   " Alunos_Telefone_Emergencia_1 = @Alunos_Telefone_Emergencia_1," +
        //                                                   " Alunos_telefone_Emergencia_2 = @Alunos_Telefone_Emergencia_2" +
        //                                                   " WHERE Alunos_Codigo = @Alunos_Codigo";

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

    }
}
