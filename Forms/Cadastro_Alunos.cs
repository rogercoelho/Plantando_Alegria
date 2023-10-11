using Plantando_Alegria.MysqlDb;
using System;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_cadastro_alunos : Form
    {
        public frm_cadastro_alunos()
        {
            InitializeComponent();
            
        }

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
            txtb_codigo.Text = "";                    // Limpa os campos após cadastrado.
            txtb_nome_aluno.Text = "";                // Limpa os campos após cadastrado.
            txtb_endereco.Text = "";                  // Limpa os campos após cadastrado.
            txtb_bairro.Text = "";                    // Limpa os campos após cadastrado.
            txtb_cidade.Text = "";                    // Limpa os campos após cadastrado.
            txtb_cep.Text = "";                       // Limpa os campos após cadastrado.
            txtb_email.Text = "";                     // Limpa os campos após cadastrado.
            txtb_telefone.Text = "";                  // Limpa os campos após cadastrado.
            txtb_contato_emergencia.Text = "";        // Limpa os campos após cadastrado.
            txtb_telefone_emergencia_1.Text = "";     // Limpa os campos após cadastrado.
            txtb_telefone_emergencia_2.Text = "";
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

            if (DB_PA.Cad_Ok == "OK")
            {
                #region Limpa todos os textbox.
                txtb_codigo.Clear();                    // Limpa os campos após cadastrado.
                txtb_nome_aluno.Clear();                // Limpa os campos após cadastrado.
                txtb_endereco.Clear();                  // Limpa os campos após cadastrado.
                txtb_bairro.Clear() ;                    // Limpa os campos após cadastrado.
                txtb_cidade.Clear();                    // Limpa os campos após cadastrado.
                txtb_cep.Clear();                       // Limpa os campos após cadastrado.
                txtb_email.Clear();                     // Limpa os campos após cadastrado.
                txtb_telefone.Clear();                  // Limpa os campos após cadastrado.
                txtb_contato_emergencia.Clear();        // Limpa os campos após cadastrado.
                txtb_telefone_emergencia_1.Clear();     // Limpa os campos após cadastrado.
                txtb_telefone_emergencia_2.Clear();
                #endregion
            }

            #endregion

            #region Insere a imagem na tabela Alunos_Imagem
          //  Alunos_Imagem_mysql Alunos_Imagem_Mysql = new Alunos_Imagem_mysql(codigo_aluno);
          // DB_PA.Inserir_Imagem(Alunos_Imagem_Mysql);

            #endregion

        }
        #endregion

        #region Metodo do Botao Inserir Imagem.

        public string foto;
        public string openfile;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();     // Instanciando objeto para a classe OpenFileDialog.
            openFile.Filter = "Imagens (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";  // Filtra arquivos jpeg, jpg, e png

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foto = openFile.FileName.ToString();    // tranfere o caminho da janela para a string foto.
                pcb_imagem_aluno.ImageLocation = foto;
            }
            DB_PA dB_PA = new DB_PA();
            dB_PA.fotos = foto;
            openfile = openFile.FileName.ToString();
            dB_PA.Inserir_Imagem();
            
            
        }

        #endregion

        #region Metodo que carrega a foto padrao caso nao seja inserido imagem do aluno.
        private void foto_padrao()
        {
            pcb_imagem_aluno.Image = Properties.Resources.maquina_fotografica;
            foto = "Resources/maquina_fotografica.png";
        }

        
        private void frm_cadastro_alunos_Load(object sender, EventArgs e)
        {
            foto_padrao();
        }
        #endregion
    }
}
