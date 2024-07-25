using MySql.Data.MySqlClient;
using Plantando_Alegria.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Plantando_Alegria.MysqlDb
{
    public class Alunos
    {
        MySqlCommand cmd = new MySqlCommand();
        DataTable dataTable = new DataTable();
        Mensagens mensagens = new Mensagens();
        Conexao_Banco_PA conexao_Banco_PA = new Conexao_Banco_PA();
        ResizeImages resizeImages = new ResizeImages();
        MySqlDataReader dataReader;

        public int Alunos_codigo { get; set; }
        public string Alunos_nome { get; set; }
        public string Alunos_nome_responsavel { get; set; }
        public string Alunos_cpf { get; set; }
        public string Alunos_endereco { get; set; }
        public string Alunos_bairro { get; set; }
        public string Alunos_cidade { get; set; }
        public string Alunos_cep { get; set; }
        public string Alunos_telefone { get; set; }
        public string Alunos_email { get; set; }
        public string Alunos_nome_contato_emergencia { get; set; }
        public string Alunos_tel_contato_emergencia_1 { get; set; }
        public string Alunos_tel_contato_emergencia_2 { get; set; }
        public string Alunos_log_atualizado_em { get; set; }
        public string Alunos_situacao { get; set; }
        public string Alunos_Data_Situacao { get; set; }
        public string Alunos_endereco_da_foto { get; set; }
        public byte[] Foto_aluno_byte { get; set; }
        public Image Foto_Aluno { get; set; }
        public object Datagrid { get; set; }
        public bool Pesquisa_feita { get; set; }
        public bool Foto_alterada { get; set; }
        public bool Dados_validados { get; set; }
        public string Query { get; set; }


        #region Inicio - Metodo que executa as Queryes.

        public void Executa_a_Query()
        {
            try
            {
                cmd.Connection = conexao_Banco_PA.Conectar_DB();
                cmd.ExecuteNonQuery();
                conexao_Banco_PA.Desconectar_DB();

            }
            catch (MySqlException errodb)
            {
                mensagens.Mensagem_22(errodb.Message); //Talvez alterar a mensagem de erro para cada tabela.
                conexao_Banco_PA.Desconectar_DB();
                return;

            }
        }


        #endregion Fim - Metodo que executa as Queryes.

        #region Inicio - Metodo que valida os campos do Cadastro e Ficha do Aluno.

        public void Validar_Campos_Cadastro_ou_Ficha_Aluno(int codigo, string nome, string cpf, string responsavel, string endereco, string bairro, string cidade, string cep, string tel_aluno,
                             string email, string contato_emergencia, string tel_emergencia1, string tel_emergencia2, string situacao)
        {
            Dados_validados = false;

            while (string.IsNullOrEmpty(Convert.ToString(codigo)))
            {
                mensagens.Mensagem_12();
                return;
            }
            while (!int.TryParse(Convert.ToString(codigo), out int verifica))
            {
                mensagens.Mensagem_12();
                return;
            }
            int positivo = Convert.ToInt32(codigo);
            if (positivo <= 0)
            {
                mensagens.Mensagem_12();
                return;
            }
            while (string.IsNullOrEmpty(cpf))
            {
                mensagens.Mensagem_34();
                return;
            }
            while (!BigInteger.TryParse(cpf, out BigInteger verifica))
            {
                mensagens.Mensagem_34();
                return;
            }
            while (string.IsNullOrEmpty(nome))
            {
                mensagens.Mensagem_13();
                return;
            }
            if (responsavel == "")
            {
                responsavel = "ALUNO MAIOR DE IDADE";
            }
            while (string.IsNullOrEmpty(endereco))
            {
                mensagens.Mensagem_14();
                return;
            }
            while (string.IsNullOrEmpty(bairro))
            {
                mensagens.Mensagem_15();
                return;
            }
            while (string.IsNullOrEmpty(cidade))
            {
                mensagens.Mensagem_16();
                return;
            }
            while (string.IsNullOrEmpty(cep))
            {
                mensagens.Mensagem_17();
                return;
            }
            while (!int.TryParse(cep, out int verifica))
            {
                mensagens.Mensagem_17();
                return;
            }
            while (string.IsNullOrEmpty(tel_aluno))
            {
                mensagens.Mensagem_18();
                return;
            }
            while (string.IsNullOrEmpty(email))
            {
                mensagens.Mensagem_19();
                return;
            }
            while (string.IsNullOrEmpty(contato_emergencia))
            {
                mensagens.Mensagem_20();
                return;
            }
            while (string.IsNullOrEmpty(tel_emergencia1))
            {
                mensagens.Mensagem_21();
                return;
            }
            if (tel_emergencia2 == "")
            {
                tel_emergencia2 = "NÃO INFORMADO";
            }

            Dados_validados = true;
        }

        #endregion Fim - Metodo que valida os campos do Cadastro e Ficha do Aluno.

        #region Inicio - Metodo de Cadastrar o Aluno.

        public void Cadastrar_Aluno(int codigo, string nome, string cpf, string responsavel, string endereco, string bairro, string cidade, string cep, string tel_aluno,
                             string email, string contato_emergencia, string tel_emergencia1, string tel_emergencia2, string situacao)
        {
            Validar_Campos_Cadastro_ou_Ficha_Aluno(codigo, nome, cpf, responsavel, endereco, bairro, cidade, cep, tel_aluno, email, contato_emergencia, tel_emergencia1, tel_emergencia2, situacao);

            if (Dados_validados == false)
            {
                return;
            }

            #region Inicio - Insere os dados na tabela de cadastro de alunos.

            Query = "INSERT INTO Alunos_Cadastro VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_CPF, @Alunos_Nome_Responsavel, " +
                                                        "@Alunos_Endereco, @Alunos_Bairro," +
                                                        "@Alunos_Cidade, @Alunos_CEP, @Alunos_Telefone, @Alunos_Email," +
                                                        "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                        "@Alunos_Telefone_Emergencia_2)";
            cmd.CommandText = Query;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = codigo;
            cmd.Parameters.Add("@Alunos_Nome", MySqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@Alunos_CPF", MySqlDbType.VarChar).Value = cpf;
            cmd.Parameters.Add("@Alunos_Nome_Responsavel", MySqlDbType.VarChar).Value = responsavel;
            cmd.Parameters.Add("@Alunos_Endereco", MySqlDbType.VarChar).Value = endereco;
            cmd.Parameters.Add("@Alunos_Bairro", MySqlDbType.VarChar).Value = bairro;
            cmd.Parameters.Add("@Alunos_Cidade", MySqlDbType.VarChar).Value = cidade;
            cmd.Parameters.Add("@Alunos_CEP", MySqlDbType.VarChar).Value = cep;
            cmd.Parameters.Add("@Alunos_Telefone", MySqlDbType.VarChar).Value = tel_aluno;
            cmd.Parameters.Add("@Alunos_Email", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@Alunos_Contato_Emergencia", MySqlDbType.VarChar).Value = contato_emergencia;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_1", MySqlDbType.VarChar).Value = tel_emergencia1;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_2", MySqlDbType.VarChar).Value = tel_emergencia2;

            Executa_a_Query();

            #endregion Fim - Insere os dados na tabela de cadastro de alunos.

            #region Inicio - Insere o Log na tabela de Cadastro do Aluno.

            Query = "INSERT INTO Alunos_Cadastro_log VALUES (@Alunos_Codigo, @Alunos_Nome, @Alunos_CPF,  " +
                                                        "@Alunos_Nome_Responsavel, @Alunos_Endereco, @Alunos_Bairro," +
                                                        "@Alunos_Cidade, @Alunos_CEP, @Alunos_Telefone, @Alunos_Email," +
                                                        "@Alunos_Contato_Emergencia, @Alunos_Telefone_Emergencia_1," +
                                                        "@Alunos_Telefone_Emergencia_2, @Atualizado_Em)";
            cmd.CommandText = Query;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = codigo;
            cmd.Parameters.Add("@Alunos_Nome", MySqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@Alunos_CPF", MySqlDbType.VarChar).Value = cpf;
            cmd.Parameters.Add("@Alunos_Nome_Responsavel", MySqlDbType.VarChar).Value = responsavel;
            cmd.Parameters.Add("@Alunos_Endereco", MySqlDbType.VarChar).Value = endereco;
            cmd.Parameters.Add("@Alunos_Bairro", MySqlDbType.VarChar).Value = bairro;
            cmd.Parameters.Add("@Alunos_Cidade", MySqlDbType.VarChar).Value = cidade;
            cmd.Parameters.Add("@Alunos_CEP", MySqlDbType.VarChar).Value = cep;
            cmd.Parameters.Add("@Alunos_Telefone", MySqlDbType.VarChar).Value = tel_aluno;
            cmd.Parameters.Add("@Alunos_Email", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@Alunos_Contato_Emergencia", MySqlDbType.VarChar).Value = contato_emergencia;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_1", MySqlDbType.VarChar).Value = tel_emergencia1;
            cmd.Parameters.Add("@Alunos_Telefone_Emergencia_2", MySqlDbType.VarChar).Value = tel_emergencia2;
            cmd.Parameters.Add("@Atualizado_em", MySqlDbType.Timestamp).Value = DateTime.Now;

            Executa_a_Query();

            #endregion Fim - Insere o Log na tabela de Cadastro do Aluno.

            #region Inicio - Insere os dados na tabela de situacao do aluno.

            Query = "INSERT INTO Alunos_Situacao VALUES (@Alunos_Codigo, @Alunos_Situacao, @Alunos_Data_Situacao_Alterada)";
            cmd.CommandText = Query;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = codigo;
            cmd.Parameters.Add("@Alunos_Situacao", MySqlDbType.VarChar).Value = situacao;
            cmd.Parameters.Add("@Alunos_Data_Situacao_Alterada", MySqlDbType.Timestamp).Value = DateTime.Now;

            Executa_a_Query();

            #endregion Fim - Insere os dados na tabela de situacao do aluno.

            #region Inicio - Insere a imagem do aluno na tabela de imagens do aluno.

            Query = "INSERT INTO Alunos_Imagem VALUES (@Alunos_Codigo, @Imagem, @Criado_Em, @Atualizado_Em)";
            cmd.CommandText = Query;

            FileStream arquivo_imagem = new FileStream(Alunos_endereco_da_foto, FileMode.Open, FileAccess.Read);
            var imagem = Image.FromStream(arquivo_imagem);
            MemoryStream stream_imagem_menor = new MemoryStream();
            try
            {
                using (imagem)
                {
                    var imagem_menor = resizeImages.ResizeImage(imagem, 145, 145);
                    imagem_menor.Save(stream_imagem_menor, ImageFormat.Png);
                    stream_imagem_menor.Position = 0;
                    BinaryReader binaryReader = new BinaryReader(stream_imagem_menor);
                    Foto_aluno_byte = binaryReader.ReadBytes((int)stream_imagem_menor.Length);
                }
            }
            catch (Exception erro)
            {
                mensagens.Mensagem_38("-->" + erro.Message);
                return;
            }
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = codigo;
            cmd.Parameters.Add("@Imagem", MySqlDbType.LongBlob).Value = Foto_aluno_byte;
            cmd.Parameters.Add("@Criado_Em", MySqlDbType.Timestamp).Value = DateTime.Now;
            cmd.Parameters.Add("@Atualizado_Em", MySqlDbType.Timestamp).Value = null;

            Executa_a_Query();

            #endregion Fim - Insere a imagem do aluno na tabela de imagens do aluno.

            mensagens.Mensagem_11();

        }

        #endregion Fim - Metodo de Cadastrar o Aluno.

        #region Inicio - Metodo de Consulta de alunos.
        public void Consulta_Aluno(string codigo, string nome, string cpf)
        {

            #region Inicio - Valida Campos de codigo e cpf.

            if (codigo != "" && Convert.ToInt32(codigo) <= 0)
            {
                mensagens.Mensagem_12();
                return;
            }
            if (cpf != "")
            {

                while (!BigInteger.TryParse(cpf, out BigInteger verifica))
                {
                    mensagens.Mensagem_34();
                    return;
                }
            }
            #endregion Fim - Valida Campos de codigo e cpf.

            #region Inicio - Verifica qual campo faz a pesquisa.

            if (codigo == "" && nome == "" && cpf == "")
            {
                mensagens.Mensagem_01();
                Query = "SELECT Alunos_Cadastro.*, Alunos_Situacao.Alunos_Situacao " +
                        "FROM Alunos_Cadastro LEFT JOIN Alunos_Situacao " +
                        "ON Alunos_Cadastro.Alunos_Codigo = Alunos_Situacao.Alunos_Codigo " +
                        "ORDER BY 1";
                Preenche_Datagrid();

            }
            else if (codigo != "" && nome == "" && cpf == "")
            {
                Query = "SELECT Alunos_Cadastro.*, Alunos_Situacao.Alunos_Situacao " +
                        "FROM Alunos_Cadastro LEFT JOIN Alunos_Situacao " +
                        "ON Alunos_Cadastro.Alunos_Codigo = Alunos_Situacao.Alunos_Codigo " +
                        "WHERE Alunos_Cadastro.Alunos_Codigo =" + codigo +
                        " ORDER BY 1";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = codigo;
                Preenche_Datagrid();

            }
            else if (codigo == "" && nome != "" && cpf == "")
            {
                Query = "SELECT Alunos_Cadastro.*, Alunos_Situacao.Alunos_Situacao " +
                        "FROM Alunos_Cadastro LEFT JOIN Alunos_Situacao " +
                        "ON Alunos_Cadastro.Alunos_Codigo = Alunos_Situacao.Alunos_Codigo " +
                        "WHERE Alunos_Cadastro.Alunos_Nome LIKE " + "'" + nome + "' " +
                        "ORDER BY 1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Alunos_Nome", nome);
                Preenche_Datagrid();
            }
            else if (codigo == "" && nome == "" && cpf != "")
            {
                Query = "SELECT Alunos_Cadastro.*, Alunos_Situacao.Alunos_Situacao " +
                        "FROM Alunos_Cadastro LEFT JOIN Alunos_Situacao " +
                        "ON Alunos_Cadastro.Alunos_Codigo = Alunos_Situacao.Alunos_Codigo " +
                        "WHERE Alunos_Cadastro.Alunos_CPF = " + cpf +
                        " ORDER BY 1";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Alunos_CPF", MySqlDbType.Int32).Value = cpf;
                Preenche_Datagrid();
            }
            else if (codigo != "" && nome != "" && cpf != "")
            {
                mensagens.Mensagem_05();
                Query = "SELECT Alunos_Cadastro.*, Alunos_Situacao.Alunos_Situacao " +
                        "FROM Alunos_Cadastro LEFT JOIN Alunos_Situacao " +
                        "ON Alunos_Cadastro.Alunos_Codigo = Alunos_Situacao.Alunos_Codigo " +
                        "WHERE Alunos_Cadastro.Alunos_Codigo= " + codigo +
                        " OR Alunos_Cadastro.Alunos_Nome LIKE " + "'" + nome + "' " +
                        "OR Alunos_Cadastro.Alunos_CPF = " + cpf +
                        " ORDER BY 1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Alunos_codigo", codigo);
                cmd.Parameters.AddWithValue("@Alunos_Nome", nome);
                cmd.Parameters.AddWithValue("@Alunos_CPF", cpf);
                Preenche_Datagrid();
            }
            else if (codigo != "" && nome != "" && cpf == "")
            {
                mensagens.Mensagem_35();
                Query = "SELECT Alunos_Cadastro.*, Alunos_Situacao.Alunos_Situacao " +
                        "FROM Alunos_Cadastro LEFT JOIN Alunos_Situacao " +
                        "ON Alunos_Cadastro.Alunos_Codigo = Alunos_Situacao.Alunos_Codigo " +
                        "WHERE Alunos_Cadastro.Alunos_Codigo= " + codigo +
                        " OR Alunos_Cadastro.Alunos_Nome LIKE " + "'" + nome + "' " +
                        "ORDER BY 1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Alunos_codigo", codigo);
                cmd.Parameters.AddWithValue("@Alunos_Nome", nome);
                Preenche_Datagrid();
            }
            else if (codigo != "" && nome == "" && cpf != "")
            {
                mensagens.Mensagem_36();
                Query = "SELECT Alunos_Cadastro.*, Alunos_Situacao.Alunos_Situacao " +
                        "FROM Alunos_Cadastro LEFT JOIN Alunos_Situacao " +
                        "ON Alunos_Cadastro.Alunos_Codigo = Alunos_Situacao.Alunos_Codigo " +
                        "WHERE Alunos_Cadastro.Alunos_Codigo= " + codigo +
                        " OR Alunos_Cadastro.Alunos_CPF = " + cpf +
                        " ORDER BY 1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Alunos_codigo", codigo);
                cmd.Parameters.AddWithValue("@Alunos_CPF", cpf);
                Preenche_Datagrid();
            }
            else if (codigo == "" && nome != "" && cpf != "")
            {
                mensagens.Mensagem_37();
                Query = "SELECT Alunos_Cadastro.*, Alunos_Situacao.Alunos_Situacao " +
                        "FROM Alunos_Cadastro LEFT JOIN Alunos_Situacao " +
                        "ON Alunos_Cadastro.Alunos_Codigo = Alunos_Situacao.Alunos_Codigo " +
                        "WHERE Alunos_Cadastro.Alunos_Nome LIKE " + "'" + nome + "' " +
                        "OR Alunos_Cadastro.Alunos_CPF= " + cpf +
                        " ORDER BY 1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Alunos_Nome", nome);
                cmd.Parameters.AddWithValue("@Alunos_CPF", cpf);
                Preenche_Datagrid();
            }

            #endregion Fim - Verifica qual campo faz a pesquisa.
        }

            #region Inicio - Preenche o Datagrid.

        private void Preenche_Datagrid()
        {
            dataTable.Clear();

            try
            {
                cmd.Connection = conexao_Banco_PA.Conectar_DB();            // Conecta no banco de dados da PA.
                cmd.CommandText = Query;                                    // Repassa a query para o mysqlcommand.
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);   // Instanciando objeto dataadapter que faz a consulta no mysql.
                dataAdapter.Fill(dataTable);                                // dataadapter preenche o datatable.
                Datagrid = dataTable;                                   // objeto datagrid recebe o datatable.
                Pesquisa_feita = true;

            }
            catch (MySqlException erro_db)
            {
                mensagens.Mensagem_04("--->" + erro_db.Message);
                Pesquisa_feita = false;
                return;

            }

            cmd.Connection.Close();                                     // Encerra a conexao.
        }

        #endregion Fim - Preenche o Datagrid.

        #endregion Fim - Metodo de Consulta de alunos.

        #region Inicio - Metodo da Ficha do Aluno.
        public void Aluno_Selecionado(int codigo, string nome, string cpf, string responsavel,
                                   string endereco, string bairro, string cidade, string cep,
                                   string telefone, string email, string contato_emergencia,
                                   string tel_emergencia_1, string tel_emergencia_2, string situacao)
        {
            #region Inicio - Envia o aluno selecionado para as prop.

            Alunos_codigo = codigo;
            Alunos_nome = nome;
            Alunos_nome_responsavel = responsavel;
            Alunos_cpf = cpf;
            Alunos_endereco = endereco;
            Alunos_bairro = bairro;
            Alunos_cidade = cidade;
            Alunos_cep = cep;
            Alunos_telefone = telefone;
            Alunos_email = email;
            Alunos_nome_contato_emergencia = contato_emergencia;
            Alunos_tel_contato_emergencia_1 = tel_emergencia_1;
            Alunos_tel_contato_emergencia_2 = tel_emergencia_2;
            Alunos_situacao = situacao;

            Query = "SELECT Alunos_Data_Situacao_Alterada, DATE_FORMAT(Alunos_Data_Situacao_Alterada,'%D/%M/%Y') FROM Alunos_Situacao WHERE Alunos_Codigo = "
                     + codigo + " ORDER BY Alunos_Data_Situacao_Alterada DESC LIMIT 1";
            
            cmd.CommandText = Query;
            Executa_a_Query();

            #endregion Fim - Envia o aluno selecionado para as prop.

            #region Inicio - Pesquisa a Imagem do aluno selecionado.

            Query = "SELECT Imagem FROM Alunos_Imagem WHERE Alunos_Codigo = " + codigo;
            cmd.CommandText = Query;

            try
            {
                cmd.Connection = conexao_Banco_PA.Conectar_DB();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    Foto_aluno_byte = (byte[])dataReader[0];
                }
                else
                {
                    mensagens.Mensagem_46();
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

            MemoryStream memoryStream = new MemoryStream(Foto_aluno_byte);
            Foto_Aluno = Image.FromStream(memoryStream);
            Foto_alterada = false;

            #endregion Fim - Pesquisa a Imagem do aluno selecionado.

        }

            #region Inicio - Metodo que compara os dados do aluno e salva as alteracoes.

        public void Atualiza_Dados_Aluno(int codigo, string nome, string cpf, string responsavel,
                                   string endereco, string bairro, string cidade, string cep,
                                   string telefone, string email, string contato_emergencia,
                                   string tel_emergencia_1, string tel_emergencia_2, string situacao)
        {
            Query = "SELECT Alunos_Cadastro.*, Alunos_Situacao.Alunos_Situacao " +
                        "FROM Alunos_Cadastro LEFT JOIN Alunos_Situacao " +
                        "ON Alunos_Cadastro.Alunos_Codigo = Alunos_Situacao.Alunos_Codigo " +
                        "WHERE Alunos_Cadastro.Alunos_Codigo =" + codigo +
                        " ORDER BY 1";
            cmd.CommandText = Query;
            cmd.Parameters.Clear();


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
                    dataReader.Read();
                    Alunos_codigo = Convert.ToInt32(dataReader[0].ToString());
                    Alunos_nome = dataReader[1].ToString();
                    Alunos_cpf = dataReader[2].ToString();
                    Alunos_nome_responsavel = dataReader[3].ToString();
                    Alunos_endereco = dataReader[4].ToString();
                    Alunos_bairro = dataReader[5].ToString();
                    Alunos_cidade = dataReader[6].ToString();
                    Alunos_cep = dataReader[7].ToString();
                    Alunos_telefone = dataReader[8].ToString();
                    Alunos_email = dataReader[9].ToString();
                    Alunos_nome_contato_emergencia = dataReader[10].ToString();
                    Alunos_tel_contato_emergencia_1 = dataReader[11].ToString();
                    Alunos_tel_contato_emergencia_2 = dataReader[12].ToString();
                    Alunos_situacao = dataReader[13].ToString();
                    dataReader.Close();
                }

                conexao_Banco_PA.Desconectar_DB();
            }
            catch (MySqlException erro_db)
            {
                mensagens.Mensagem_04("-->" + erro_db.Message);

            }

            if (Alunos_codigo != codigo)
            {
                mensagens.Mensagem_50();
                return;
            }
            if (Alunos_nome == nome &&
                Alunos_cpf == cpf &&
                Alunos_nome_responsavel == responsavel &&
                Alunos_endereco == endereco &&
                Alunos_bairro == bairro &&
                Alunos_cidade == cidade &&
                Alunos_cep == cep &&
                Alunos_telefone == telefone &&
                Alunos_email == email &&
                Alunos_nome_contato_emergencia == contato_emergencia &&
                Alunos_tel_contato_emergencia_1 == tel_emergencia_1 &&
                Alunos_tel_contato_emergencia_2 == tel_emergencia_2 &&
                Alunos_situacao == situacao)

            {
                mensagens.Mensagem_07();
            }
            else
            {

                Validar_Campos_Cadastro_ou_Ficha_Aluno(codigo, nome, cpf, responsavel, endereco, bairro, cidade, cep, telefone, email, contato_emergencia, tel_emergencia_1, tel_emergencia_2, situacao);

                if (Dados_validados == false)
                {
                    return;
                }

                Query = "UPDATE Alunos_Cadastro SET Alunos_Nome = @Alunos_Nome, Alunos_CPF = @Alunos_CPF, Alunos_Nome_Responsavel = @Alunos_Nome_Responsavel, " +
                                                      "Alunos_Endereco = @Alunos_Endereco, Alunos_Bairro = @Alunos_Bairro," +
                                                      " Alunos_Cidade = @Alunos_Cidade, Alunos_CEP = @Alunos_CEP, " +
                                                      " Alunos_Telefone = @Alunos_Telefone, Alunos_Email = @Alunos_Email, " +
                                                      " Alunos_Contato_Emergencia = @Alunos_Contato_Emergencia, " +
                                                      " Alunos_Telefone_Emergencia_1 = @Alunos_Telefone_Emergencia_1," +
                                                      " Alunos_telefone_Emergencia_2 = @Alunos_Telefone_Emergencia_2" +
                                                      " WHERE Alunos_Codigo =" + codigo;
                cmd.CommandText = Query;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Alunos_Nome", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@Alunos_CPF", MySqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@Alunos_Nome_Responsavel", MySqlDbType.VarChar).Value = responsavel;
                cmd.Parameters.Add("@Alunos_Endereco", MySqlDbType.VarChar).Value = endereco;
                cmd.Parameters.Add("@Alunos_Bairro", MySqlDbType.VarChar).Value = bairro;
                cmd.Parameters.Add("@Alunos_Cidade", MySqlDbType.VarChar).Value = cidade;
                cmd.Parameters.Add("@Alunos_CEP", MySqlDbType.VarChar).Value = cep;
                cmd.Parameters.Add("@Alunos_Telefone", MySqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@Alunos_Email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@Alunos_Contato_Emergencia", MySqlDbType.VarChar).Value = contato_emergencia;
                cmd.Parameters.Add("@Alunos_Telefone_Emergencia_1", MySqlDbType.VarChar).Value = tel_emergencia_1;
                cmd.Parameters.Add("@Alunos_Telefone_Emergencia_2", MySqlDbType.VarChar).Value = tel_emergencia_2;
                Executa_a_Query();

                Query = "UPDATE Alunos_Situacao SET Alunos_Situacao = @Alunos_Situacao, Alunos_Data_Situacao_Alterada = @Alunos_Data_Situacao_Alterada " +
                        "WHERE Alunos_Codigo = @Alunos_Codigo";
                cmd.CommandText = Query;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Alunos_Situacao", MySqlDbType.VarChar).Value = situacao;
                cmd.Parameters.Add("@Alunos_Data_Situacao_Alterada", MySqlDbType.Timestamp).Value = DateTime.Now;
                cmd.Parameters.Add("@Alunos_Codigo", MySqlDbType.Int32).Value = codigo;
                Executa_a_Query();

                mensagens.Mensagem_08();
     


            }

            #endregion Fim - Metodo que compara os dados do aluno e salva as alteracoes.

            
            
            
            
            
            #endregion Fim - Metodos da Ficha do Aluno.
       
        
        }
    }
}

