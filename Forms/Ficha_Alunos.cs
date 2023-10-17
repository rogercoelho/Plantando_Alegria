using MySql.Data.MySqlClient;
using Plantando_Alegria.MysqlDb;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_ficha_alunos : Form
    {
        public string selecao;              // Variavel que recebe a selecao do checklistbox
        public static string foto_aluno;    // variavel que recebe o caminho da foto.
        DB_PA dB_PA = new DB_PA();
        public frm_ficha_alunos()
        {
            InitializeComponent();
        }

        #region Metodo de execucao ao carregar Tela.
        public void frm_ficha_alunos_Load(object sender, EventArgs e)
        {
            Carrega_Ficha_Aluno();
        }
        #endregion

        #region Metodo do Botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();   // Instanciando objeto para a tela principal.
            frm_Tela_Principal.Show();                                          // Abre a tela principal.
            this.Close();                                                       // fecha a atual.
        }
        #endregion

        #region Metodo do Botao Editar.
        private void btn_editar_Click(object sender, EventArgs e)
        {
            #region Controle dos botoes e textbox.

            txtb_nome_aluno.Enabled = true;                 // Ativa o campo para edicao.
            txtb_endereco.Enabled = true;                   // Ativa o campo para edicao.
            txtb_bairro.Enabled = true;                     // Ativa o campo para edicao.
            txtb_cidade.Enabled = true;                     // Ativa o campo para edicao.
            txtb_cep.Enabled = true;                        // Ativa o campo para edicao.
            txtb_telefone.Enabled = true;                   // Ativa o campo para edicao.
            txtb_email.Enabled = true;                      // Ativa o campo para edicao.
            txtb_contato_emergencia.Enabled = true;         // Ativa o campo para edicao.
            txtb_telefone_emergencia_1.Enabled = true;      // Ativa o campo para edicao.
            txtb_telefone_emergencia_2.Enabled = true;      // Ativa o campo para edicao.

            btn_voltar.Visible = false;         // Desativa a visualizacao do botao.
            btn_editar.Visible = false;         // Desativa a visualizacao do botao.
            btn_limpar.Visible = true;          // Ativa a visualizacao do botao .           
            btn_salvar.Visible = true;          // Ativa a visualizacao do botao.
            btn_cancelar.Visible = true;        // Ativa a visualizacao do botao.
            btn_alterar_imagem.Visible = true;  // Ativa a visualizacao do botao.

            btn_limpar.Enabled = true;          // Habilita a execucao do botao.
            btn_salvar.Enabled = true;          // Habilita a execucao do botao.
            btn_cancelar.Enabled = true;        // Habilita a execucao do botao.
            btn_alterar_imagem.Enabled = true;  // Habilita a execucao do botao.
            btn_voltar.Enabled = false;         // Desabilita a execucao do botao.
            btn_editar.Enabled = false;         // Desabilita a execucao do botao.

            #endregion
        }
        #endregion

        #region Metodo do Botao Cancelar.
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            #region Controle dos botoes e textbox.

            txtb_nome_aluno.Enabled = false;                // Desativa o campo para edicao.
            txtb_endereco.Enabled = false;                  // Desativa o campo para edicao.
            txtb_bairro.Enabled = false;                    // Desativa o campo para edicao.
            txtb_cidade.Enabled = false;                    // Desativa o campo para edicao.
            txtb_cep.Enabled = false;                       // Desativa o campo para edicao.
            txtb_telefone.Enabled = false;                  // Desativa o campo para edicao.
            txtb_email.Enabled = false;                     // Desativa o campo para edicao.
            txtb_contato_emergencia.Enabled = false;        // Desativa o campo para edicao.
            txtb_telefone_emergencia_1.Enabled = false;     // Desativa o campo para edicao.
            txtb_telefone_emergencia_2.Enabled = false;     // Desativa o campo para edicao.

            btn_alterar_imagem.Visible = false;             // Desativa a visualizacao do botao.
            btn_cancelar.Visible = false;                   // Desativa a visualizacao do botao.
            btn_salvar.Visible = false;                     // Desativa a visualizacao do botao.
            btn_limpar.Visible = false;                     // Desativa a visualizacao do botao.
            btn_voltar.Visible = true;                      // Ativa a visualizacao do botao.
            btn_editar.Visible = true;                      // Ativa a visualizacao do botao.

            btn_alterar_imagem.Enabled = false;             // Desabilita a execucao do botao.
            btn_cancelar.Enabled = false;                   // Desabilita a execucao do botao.
            btn_salvar.Enabled = false;                     // Desabilita a execucao do botao.
            btn_limpar.Enabled = false;                     // Desabilita a execucao do botao.
            btn_voltar.Enabled = true;                      // Habilita a execucao do botao.
            btn_editar.Enabled = true;                      // Habilita a execucao do botao.

            #endregion

            Carrega_Ficha_Aluno();

        }
        #endregion

        #region Metodo do Botao Limpar.
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtb_nome_aluno.Clear();                                            // Limpa o textbox.
            txtb_endereco.Clear();                                              // Limpa o textbox.
            txtb_bairro.Clear();                                                // Limpa o textbox.
            txtb_cidade.Clear();                                                // Limpa o textbox.
            txtb_cep.Clear();                                                   // Limpa o textbox.
            txtb_telefone.Clear();                                              // Limpa o textbox.
            txtb_email.Clear();                                                 // Limpa o textbox.
            txtb_contato_emergencia.Clear();                                    // Limpa o textbox.
            txtb_telefone_emergencia_1.Clear();                                 // Limpa o textbox.
            txtb_telefone_emergencia_2.Clear();                                 // Limpa o textbox.
            pcb_imagem_aluno.Image = Properties.Resources.maquina_fotografica;  // Carrega a foto padrao na picturebox.
        }
        #endregion

        #region Metodo do botao de Alterar Imagem.
        private void btn_alterar_imagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();                             // Instanciando objeto para a classe OpenfileDialog.
            openfile.Filter = "Imagens (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png "; // filta os tipos de arquivos permitidos.

            if (openfile.ShowDialog() == DialogResult.OK)                               // Se pressionar OK na janela.
            {
                foto_aluno = openfile.FileName.ToString();                              // Pega o caminho da imagem selecionada.
                pcb_imagem_aluno.ImageLocation = foto_aluno;                            // Mostra a imagem no PictureBox.
            }
        }
        #endregion

        #region Metodo do botao Salvar
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
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

            dB_PA.Query_Atualizar_Cadastro();

            if (DB_PA.Cad_Ok == "OK")           // Essa é referente a atualizacao do cadastro.
            {
                dB_PA.Query_Alterar_Imagem();
         
            }

            if (DB_PA.Cad_Ok == "OK")           // Essa é referente a atualizacao da imagem.
            {
                MessageBox.Show("Funcionou.");
            }
            
        }

        #endregion
            
        #region Metodo que carrega a ficha do aluno.

        public void Carrega_Ficha_Aluno()
        {
            char[] remove = new char[] { '|' };                                                 // Criando um array de variaveis com caracteres que serao removidos da selecao.
            string[] selecao2 = selecao.Split(remove, StringSplitOptions.RemoveEmptyEntries);   // Selecao2 recebe de selecao com os caracteres removidos.

            txtb_codigo.Text = selecao2[1];                                         // textbox recebe selecao na posicao do array.
            txtb_nome_aluno.Text = selecao2[3].ToString().Trim();                   // textbox recebe selecao na posicao do array.
            txtb_telefone.Text = selecao2[5].ToString().Trim();                     // textbox recebe selecao na posicao do array.
            txtb_email.Text = selecao2[7].ToString().Trim();                        // textbox recebe selecao na posicao do array.
            txtb_endereco.Text = selecao2[9].ToString().Trim();                     // textbox recebe selecao na posicao do array.
            txtb_bairro.Text = selecao2[11].ToString().Trim();                      // textbox recebe selecao na posicao do array.
            txtb_cidade.Text = selecao2[13].ToString().Trim();                      // textbox recebe selecao na posicao do array.
            txtb_cep.Text = selecao2[15].ToString().Trim();                         // textbox recebe selecao na posicao do array.
            txtb_contato_emergencia.Text = selecao2[17].ToString().Trim();          // textbox recebe selecao na posicao do array.
            txtb_telefone_emergencia_1.Text = selecao2[19].ToString().Trim();       // textbox recebe selecao na posicao do array.
            txtb_telefone_emergencia_2.Text = selecao2[21].ToString().Trim();       // textbox recebe selecao na posicao do array.
            DB_PA.Alunos_Codigo = txtb_codigo.Text.Trim();                          // textbox recebe codigo do aluno direto da variavel.
            dB_PA.Pesquisar_Imagem();                                               // Chama o metodo de Pesquisar imagem
            byte[] imagem_byte = DB_PA.imagem_byte;                                 // Tranfere o array de byte da imagem.
            MemoryStream memoryStream = new MemoryStream(imagem_byte);              // Manda para a memoria a imagem (Memorystream).
            pcb_imagem_aluno.Image = Image.FromStream(memoryStream);                // Picturebox recebe a imagem decodificada da memoria.
            pcb_imagem_aluno.Refresh();                                             // Atualiza o picturebox.
        }
        #endregion

    }
}

