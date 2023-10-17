using Plantando_Alegria.MysqlDb;
using System;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_cadastro_alunos : Form
    {
       // public static string foto_aluno;
            
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

            #region Criando variaveis.
            DB_PA dB_PA = new DB_PA();  // Instancia objeto para a classe DB_PA.
            int verifica;               // Variavel para verificar os campos de numeros do textbox. 

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

            #region Passa os dados para a classe DB_PA
            DB_PA.Alunos_Codigo = txtb_codigo.Text;
            DB_PA.Alunos_Nome = txtb_nome_aluno.Text;
            DB_PA.Alunos_Telefone = txtb_telefone.Text;
            DB_PA.Alunos_Email = txtb_email.Text;
            DB_PA.Alunos_Endereco = txtb_endereco.Text;
            DB_PA.Alunos_Bairro = txtb_bairro.Text;
            DB_PA.Alunos_Cidade = txtb_cidade.Text;
            DB_PA.Alunos_CEP = txtb_cep.Text;
            DB_PA.Alunos_Contato_Emergencia = txtb_contato_emergencia.Text;
            DB_PA.Alunos_Telefone_Emergencia_1 = txtb_telefone_emergencia_1.Text;
            DB_PA.Alunos_Telefone_Emergencia_2 = txtb_telefone_emergencia_2.Text;
            #endregion

            dB_PA.Query_Cadastrar_Aluno();
            
            #region Insere a imagem na tabela Alunos_Imagem SE o cadastro for feito com sucesso.

            if (DB_PA.Cad_Ok == "OK")
            {
                dB_PA.Query_Inserir_Imagem();
            }

            #endregion

            #region Em caso de cadasto realizado com sucesso, limpa os textbox.

            if (DB_PA.Cad_Ok == "OK")
            {
                btn_limpar.PerformClick();  // Limpa os campos
            }
            
            #endregion

        }
        #endregion

        #region Metodo do botao inserir imagem.
        private void btn_inserir_imagem_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openfile = new OpenFileDialog();                             // Instanciando objeto para a classe OpenfileDialog.
            openfile.Filter = "Imagens (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png "; // filta os tipos de arquivos permitidos.

            if (openfile.ShowDialog() == DialogResult.OK)                               // Se pressionar OK na janela.
            {
                DB_PA.caminho_foto_aluno = openfile.FileName.ToString();                              // Pega o caminho da imagem selecionada.
                pcb_imagem_aluno.ImageLocation = DB_PA.caminho_foto_aluno;                            // Mostra a imagem no PictureBox.
            }

        }

        #endregion

        #region Metodos para a Foto Padrao.

        #region Metodo que carrega a foto padrao caso nao seja inserido imagem do aluno.
        private void frm_cadastro_alunos_Load(object sender, EventArgs e)           // Metodo que é carregado quando o sistema é iniciado.
        {
            foto_padrao();                      // caminho onde a foto esta armazenada.
        }
        #endregion

        #region Metodo do caminho da foto padrao.
        public void foto_padrao()
        {
            pcb_imagem_aluno.Image = Properties.Resources.maquina_fotografica;      // Carrega a foto padrao na picturebox.
            DB_PA.caminho_foto_aluno = "Resources/maquina_fotografica.png";                       // caminho onde a foto esta armazenada.

        }
        #endregion

        #endregion

    }
}
