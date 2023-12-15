using Plantando_Alegria.MysqlDb;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_cadastro_alunos : Form
    {
        #region Instanciando objetos.
            
        Mensagens mensagens = new Mensagens();  // Instanciando objeto para a classe mensagens.     
        DB_PA dB_PA = new DB_PA();              // Instancia objeto para a classe DB_PA.

        #endregion

        #region Metodo Construtor.
        public frm_cadastro_alunos()
        {
            InitializeComponent();
            
        }
        #endregion

        #region Metodo do botao Voltar.
        public void btn_voltar_Click(object sender, EventArgs e)
        {
            #region Abre a tela principal e fecha a atual.
        
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();   // Instancia objeto para pa classe.
            frm_Tela_Principal.Show();                                          // abre o frm tela principal
            this.Close();                                                       // Fecha o atual.
            #endregion

        }
        #endregion

        #region Metodo do Botao Limpar.
        public void btn_limpar_Click(object sender, EventArgs e)
        {

            txtb_codigo.Clear();                    // Limpa os campos após cadastrado.
            txtb_nome_aluno.Clear();                // Limpa os campos após cadastrado.
            txtb_endereco.Clear();                  // Limpa os campos após cadastrado.
            txtb_bairro.Clear();                    // Limpa os campos após cadastrado.
            txtb_cidade.Clear();                    // Limpa os campos após cadastrado.
            txtb_cep.Clear();                       // Limpa os campos após cadastrado.
            txtb_email.Clear();                     // Limpa os campos após cadastrado.
            txtb_telefone.Clear();                  // Limpa os campos após cadastrado.
            txtb_contato_emergencia.Clear();        // Limpa os campos após cadastrado.
            txtb_telefone_emergencia_1.Clear();     // Limpa os campos após cadastrado.
            txtb_telefone_emergencia_2.Clear();     // Limpa os campos após cadastrado.
            foto_padrao();                          // Carrega a foto padrao do sistema.

        }
        #endregion

        #region Metodo do Botao Adicionar Aluno
        public void btn_adicionar_aluno_Click(object sender, EventArgs e)
        {

            #region Repassa os dados dos campos para as variaveis DB_PA.          

            DB_PA.Alunos_Codigo = txtb_codigo.Text.ToUpper();                                   // Variavel recebe o valor do textbox.
            DB_PA.Alunos_CPF = txtb_cpf.Text.ToUpper();                                         // Variavel recebe o valor do textbox.
            DB_PA.Alunos_Nome = txtb_nome_aluno.Text.ToUpper();                                 // Variavel recebe o valor do textbox.
            DB_PA.Alunos_Telefone = txtb_telefone.Text.ToUpper();                               // Variavel recebe o valor do textbox.
            DB_PA.Alunos_Email = txtb_email.Text.ToUpper();                                     // Variavel recebe o valor do textbox.
            DB_PA.Alunos_Endereco = txtb_endereco.Text.ToUpper();                               // Variavel recebe o valor do textbox.
            DB_PA.Alunos_Bairro = txtb_bairro.Text.ToUpper();                                   // Variavel recebe o valor do textbox.
            DB_PA.Alunos_Cidade = txtb_cidade.Text.ToUpper();                                   // Variavel recebe o valor do textbox.
            DB_PA.Alunos_CEP = txtb_cep.Text.ToUpper();                                         // Variavel recebe o valor do textbox.
            DB_PA.Alunos_Contato_Emergencia = txtb_contato_emergencia.Text.ToUpper();           // Variavel recebe o valor do textbox.
            DB_PA.Alunos_Telefone_Emergencia_1 = txtb_telefone_emergencia_1.Text.ToUpper();     // Variavel recebe o valor do textbox.
            DB_PA.Alunos_Telefone_Emergencia_2 = txtb_telefone_emergencia_2.Text.ToUpper();     // Variavel recebe o valor do textbox.

            #endregion

            #region Valida os campos do cadastro do aluno.

            dB_PA.Verifica_Campos();    // Chama o metodo que valida os campos.

            #endregion

            #region Se foram validados Cadastra o aluno, insere a imagem e registra o log.
            if (DB_PA.campos_validados == true)     // Se estiver validado.
            {
                #region Cadastra os dados do aluno.
                dB_PA.Query_Cadastrar_Aluno();                  // Chama o metodo da query de cadastro de alunos.
                dB_PA.Cadastrar_Atualizar_Alunos_Cadastro();    // Chama o metodo que prepara os dados para o banco.
                dB_PA.Executa_Banco();                          // Chama o metodo que grava no banco.
                DB_PA.e_cadastro = false;                   // Troca o valor da variavel para falso.

                #endregion

                #region Se o cadastro voltar OK insere a imagem do aluno.

                if (DB_PA.Cad_Ok == "OK")                       // Se o cadastro foi criado com sucesso.
                {
                    dB_PA.Query_Inserir_Imagem();               // Chama o metodo da query de inserir imagem.
                    dB_PA.Processa_Imagem();                    // chama o metodo que prepara a imagem para o banco.
                    dB_PA.Executa_Banco();                      // chama o metodo que grava no banco.
                }
                #endregion

                #region Se cadastro voltar OK Grava o log.
                if (DB_PA.Cad_Ok == "OK")
                {
                    DB_PA.e_log = true;                             // Atribui True a variavel para registrar o log.
                    dB_PA.Log_Query_Cadastrar_Aluno();              // Chama o metodo Query Cadastrar log.
                    dB_PA.Cadastrar_Atualizar_Alunos_Cadastro();    // Chama o metodo que prepara os dados para o banco
                    dB_PA.Executa_Banco();                          // Chama o metodo que grava no banco.

                    if (DB_PA.Cad_Ok == "OK")
                    {
                        mensagens.Mensagem_11();                     // Mostra a mensagem.
                        btn_limpar.PerformClick();                   // Limpa os campos

                    }

                }
                #endregion
            }

            #endregion
        }
        #endregion

        #region Metodo do botao inserir imagem.
        public void btn_inserir_imagem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openfile = new OpenFileDialog();                             // Instanciando objeto para a classe OpenfileDialog.
            openfile.Filter = "Imagens (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png "; // filtra os tipos de arquivos permitidos.

            if (openfile.ShowDialog() == DialogResult.OK)                               // Se pressionar OK na janela.
            {
                DB_PA.caminho_foto_aluno = openfile.FileName.ToString();                // Pega o caminho da imagem selecionada.
                pcb_imagem_aluno.ImageLocation = DB_PA.caminho_foto_aluno;              // Mostra a imagem no PictureBox.
            }

        }

        #endregion

        #region Metodo para a Foto Padrao.

        #region Metodo que carrega a foto padrao caso nao seja inserido imagem do aluno.
        public void frm_cadastro_alunos_Load(object sender, EventArgs e)    // Metodo que é carregado quando o sistema é iniciado.
        {
            foto_padrao();  // Chama o metodo do caminho onde a foto esta armazenada.
        }
        #endregion

        #region Metodo do caminho da foto padrao.
        public void foto_padrao()
        {
            pcb_imagem_aluno.Image = Properties.Resources.maquina_fotografica;  // Carrega a foto padrao na picturebox.
            DB_PA.caminho_foto_aluno = "Resources/maquina_fotografica.png";     // caminho onde a foto esta armazenada.

        }
        #endregion

        #endregion

    }
}
