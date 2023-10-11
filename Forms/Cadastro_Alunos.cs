using Plantando_Alegria.MysqlDb;
using System;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_cadastro_alunos : Form
    {
        public static object caminho_openfile = new object();
            
        #region Metodo Construtor.
        public frm_cadastro_alunos()
        {
            InitializeComponent();
            
        }
        #endregion

        #region Metodo do botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
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
            #region Limpa todos os textbox.
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
            #endregion
        }
        #endregion

        #region Metodo do Botao Adicionar Aluno
        public void btn_adicionar_aluno_Click(object sender, EventArgs e)
        {

            #region Criando variaveis.
            int verifica,       // Variavel para verificar os campos de numeros do textbox. 
                codigo_aluno;   // Variavel criada para converter a entrada do textbox (string) para int.

            #endregion

            #region Valida o conteudo dos textbox.

            while (!int.TryParse(txtb_codigo.Text, out verifica))  // Enquanto o txtbox nao for apenas numeros retorna a mensagem.
            {

                MessageBox.Show("O campo de Código do Aluno aceita apenas numeros e não pode estar vazio.\n");

                return;
            }
            while (string.IsNullOrEmpty(txtb_nome_aluno.Text))                     // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                MessageBox.Show("O campo Nome do Aluno não pode estar vazio.\n");

                return;
            }
            while (string.IsNullOrEmpty(txtb_endereco.Text))                        // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                MessageBox.Show("O Campo Endereco do Aluno não pode estar vazio.\n");

                return;
            }
            while (string.IsNullOrEmpty(txtb_bairro.Text))                          // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                MessageBox.Show("O Campo Bairro não pode estar vazio.\n");

                return;
            }
            while (string.IsNullOrEmpty(txtb_cidade.Text))                          // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                MessageBox.Show("O Campo Cidade não pode estar vazio.\n");

                return;
            }
            while (string.IsNullOrEmpty(txtb_cep.Text))                             // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                MessageBox.Show("O Campo CEP não pode estar vazio.\n");

                return;
            }
            while (string.IsNullOrEmpty(txtb_telefone.Text))                        // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                MessageBox.Show("O campo Telefone do Aluno não pode estar vazio.\n");

                return;
            }
            while (string.IsNullOrEmpty(txtb_email.Text))                           // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                MessageBox.Show("O Campo Email do Aluno não pode estar vazio\n");

                return;
            }
            while (string.IsNullOrEmpty(txtb_contato_emergencia.Text))              // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                MessageBox.Show("O Campo Contado de Emergencia não pode estar vazio.\n");

                return;
            }
            while (string.IsNullOrEmpty(txtb_telefone_emergencia_1.Text))             // Enquanto txtbox estiver em branco retorna a mensagem.
            {
                MessageBox.Show("O Campo Telefone do Contato de Emergencia não pode estar vazio.\n");

                return;
            }
            if (txtb_telefone_emergencia_2.Text == "")
            {
                txtb_telefone_emergencia_2.Text = "NÃO INFORMADO";
            }
            #endregion

            #region Cadastra os dados na tabela Alunos_Cadastro.

            codigo_aluno = Convert.ToInt32(txtb_codigo.Text); // converte o conteudo do textbox (string) em int.

            Alunos_Cadastro_mysql Alunos_Cadastro_Mysql = new Alunos_Cadastro_mysql(codigo_aluno, txtb_nome_aluno.Text.ToUpper(), txtb_endereco.Text.ToUpper(), txtb_bairro.Text.ToUpper(),
                                                                                    txtb_cidade.Text.ToUpper(), txtb_cep.Text.ToUpper(), txtb_telefone.Text.ToUpper(), txtb_email.Text.ToUpper(),
                                                                                    txtb_contato_emergencia.Text.ToUpper(), txtb_telefone_emergencia_1.Text.ToUpper(),
                                                                                    txtb_telefone_emergencia_2.Text.ToUpper());
            // Instanciando objeto da classe Alunos_Cadastro_mysql que retorna o conteudo das textbox em Caixa Alta (toUpper)

            DB_PA.Cadastrar_Aluno(Alunos_Cadastro_Mysql);   // Chama o metodo Cadastrar_Aluno da classe Db_PA com os valores do objeto Alunos_Cadastro_Mysql.

            #region Em caso de cadasto realizado com sucesso, limpa os textbox.
            if (DB_PA.Cad_Ok == "OK")
            {
                txtb_codigo.Clear();                    // Limpa os campos após cadastrado.
                txtb_nome_aluno.Clear();                // Limpa os campos após cadastrado.
                txtb_endereco.Clear();                  // Limpa os campos após cadastrado.
                txtb_bairro.Clear() ;                   // Limpa os campos após cadastrado.
                txtb_cidade.Clear();                    // Limpa os campos após cadastrado.
                txtb_cep.Clear();                       // Limpa os campos após cadastrado.
                txtb_email.Clear();                     // Limpa os campos após cadastrado.
                txtb_telefone.Clear();                  // Limpa os campos após cadastrado.
                txtb_contato_emergencia.Clear();        // Limpa os campos após cadastrado.
                txtb_telefone_emergencia_1.Clear();     // Limpa os campos após cadastrado.
                txtb_telefone_emergencia_2.Clear();     // Limpa os campos após cadastrado.
            }
            #endregion


            #endregion

            #region Insere a imagem na tabela Alunos_Imagem
            Alunos_Imagem_mysql Alunos_Imagem_Mysql = new Alunos_Imagem_mysql(codigo_aluno);
            DB_PA.Inserir_Imagem(Alunos_Imagem_Mysql);

            #endregion

        }
        #endregion

        #region Metodo do botao inserir imagem.
        private void btn_inserir_imagem_Click(object sender, EventArgs e)
        {
            #region Recebe o caminho da imagem do aluno e mostra no picturebox.

            OpenFileDialog openfile = new OpenFileDialog ();                                // Insancia objeto para a classe OpenfileDialog (janela abrir arquivo)
            caminho_openfile = openfile.GetType();
            caminho_openfile = openfile.Filter = "Imagens (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png ";     // Filtra apenas imagens jpg, jpeg e png

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                caminho_openfile = openfile.FileName.ToString();
                                                                  // Pega o caminho da imagem selecionada.
                pcb_imagem_aluno.ImageLocation = (string)caminho_openfile;                          // Mostra a imagem no PictureBox.
            }
            #endregion
        }

        #endregion

        #region Metodo que carrega a foto padrao caso nao seja inserido imagem do aluno.
        private void foto_padrao()
        {
            pcb_imagem_aluno.Image = Properties.Resources.maquina_fotografica;
            caminho_openfile = "Resources/maquina_fotografica.png";
        }

        
        private void frm_cadastro_alunos_Load(object sender, EventArgs e)
        {
            foto_padrao();
        }
        #endregion
    }
}
