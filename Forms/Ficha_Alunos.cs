using Plantando_Alegria.MysqlDb;
using System;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_ficha_alunos : Form
    {
        #region Instanciando objetos.

        DB_PA dB_PA = new DB_PA();                                          // Instanciando objeto para a classe DB_PA.
        Mensagens mensagens = new Mensagens();                              // Instanciando objeto para a classe mensagens.    

        #endregion

        #region Variaveis operacionais.
        public static string selecao;       // Variavel que recebe a selecao do checklistbox
        public static string[] selecao2;    // Array de variavei que recebe a pesquisa selecionada.            

        #endregion

        #region Metodo Construtor.
        public frm_ficha_alunos()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodo do Botao Voltar.
        public void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();   // Instanciando objeto para a tela principal.
            frm_Tela_Principal.Show();                                          // Abre a tela principal.
            this.Close();                                                       // fecha a atual.
        }
        #endregion

        #region Metodo do Botao Cancelar.
        public void btn_cancelar_Click(object sender, EventArgs e)
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

            Carrega_Ficha_Aluno();          // Chama o metodo que carrega a ficha do aluno.

        }
        #endregion

        #region Metodo do Botao Limpar.
        public void btn_limpar_Click(object sender, EventArgs e)
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
        public void btn_alterar_imagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();                             // Instanciando objeto para a classe OpenfileDialog.
            openfile.Filter = "Imagens (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png "; // filta os tipos de arquivos permitidos.

            if (openfile.ShowDialog() == DialogResult.OK)                               // Se pressionar OK na janela.
            {
                DB_PA.caminho_foto_aluno = openfile.FileName.ToString();                // Pega o caminho da imagem selecionada.
                pcb_imagem_aluno.ImageLocation = DB_PA.caminho_foto_aluno;              // Mostra a imagem no PictureBox.
                DB_PA.foto_alterada = true;                                             // Atribui o valor true para foto alterada.
            }
        }
        #endregion

        #region Metodo do Botao Editar.
        public void btn_editar_Click(object sender, EventArgs e)
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

        #region Metodo do botao Salvar.
        public void btn_salvar_Click(object sender, EventArgs e)
        {
            
            #region Atribui valor para as variaveis.
            
            DB_PA.Alunos_Codigo = txtb_codigo.Text.ToUpper().Trim();                                   // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_Nome = txtb_nome_aluno.Text.ToUpper().Trim();                                 // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_Telefone = txtb_telefone.Text.ToUpper().Trim();                               // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_Email = txtb_email.Text.ToUpper().Trim();                                     // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_Endereco = txtb_endereco.Text.ToUpper().Trim();                               // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_Bairro = txtb_bairro.Text.ToUpper().Trim();                                   // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_Cidade = txtb_cidade.Text.ToUpper().Trim();                                   // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_CEP = txtb_cep.Text.ToUpper().Trim();                                         // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_Contato_Emergencia = txtb_contato_emergencia.Text.ToUpper().Trim();           // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_Telefone_Emergencia_1 = txtb_telefone_emergencia_1.Text.ToUpper().Trim();     // Repassa o valor do textbox para a variavel.
            DB_PA.Alunos_Telefone_Emergencia_2 = txtb_telefone_emergencia_2.Text.ToUpper().Trim();     // Repassa o valor do textbox para a variavel.

            #endregion

            #region Valida os campos da ficha do aluno.
            dB_PA.Compara_Ficha_Aluno();              // Chama o metodo de validacao dos campos.

            #endregion

            #region Verifica o que foi alterado e executa a mudanca.

            if (DB_PA.foto_alterada == true && DB_PA.dados_alterados == true)           // Verifica se foi alterada a foto e os dados.
            {
                dB_PA.Query_Alterar_Imagem();                                           // Chama o metodo da query da imagem.
                dB_PA.Processa_Imagem();                                                // Chama o metodo que trata a imagem.
                dB_PA.Executa_Banco();                                                  // Chama o metodo que salva no banco.
                dB_PA.Query_Atualizar_Cadastro_Aluno();                                 // Chama o metodo da query dos dados.
                dB_PA.Cadastrar_Atualizar_Alunos_Cadastro();                            // Chama o metodo que trata os dados.
                dB_PA.Executa_Banco();                                                  // Chama o metodo que salva no banco.
                mensagens.Mensagem_10();                                                // mostra mensagem.
            }
            else if (DB_PA.foto_alterada == false && DB_PA.dados_alterados == true)     // Se alterou so os dados
            {
                dB_PA.Query_Atualizar_Cadastro_Aluno();                                 // Chama o metodo da query dos dados.
                dB_PA.Cadastrar_Atualizar_Alunos_Cadastro();                            // Chama o metodo que trata os dados.
                dB_PA.Executa_Banco();                                                  // Chama o metodo que salva no banco.
                DB_PA.e_log = true;                                                     // Atribui true na variavel que chama o log.
                dB_PA.Log_Query_Cadastrar_Aluno();                                      // Chama o metodo da query do log
                dB_PA.Cadastrar_Atualizar_Alunos_Cadastro();                            // Chama o metodo que trata os dados.
                dB_PA.Executa_Banco();                                                  // Chama o metodo que salva no banco.
                mensagens.Mensagem_08();                                                // mostra mensagem.
            }
            else if (DB_PA.foto_alterada == true && DB_PA.dados_alterados == false)     // Se alterou so a foto.
            {
                dB_PA.Query_Alterar_Imagem();                                           // Chama o metodo da query da imagem.
                dB_PA.Processa_Imagem();                                                // Chama o metodo que trata a imagem.
                dB_PA.Executa_Banco();                                                  // Chama o metodo que salva no banco.
                mensagens.Mensagem_09();                                                // mostra mensagem.
            }
            else                                                                        // Sem alteracoes.
            {
                mensagens.Mensagem_07();                                                // mostra mensagem.
            }


            #endregion

            #region Carrega a alteracao na ficha do aluno.

            DB_PA.pesquisar_alunos = true;
            dB_PA.Limpar_Variaveis_Alunos();
            DB_PA.Alunos_Codigo = txtb_codigo.Text.Trim();
            btn_limpar.PerformClick();

            if (DB_PA.dados_alterados == true || DB_PA.foto_alterada == true)           // Se foi alterado.
            {
                
                dB_PA.Pesquisar_pelo_Codigo_tbl_alunos_cadastro();                      // Chama o metodo para pesquisar pelo codigo.
                dB_PA.Executa_Pesquisa();                                               // Chama o metodo que executa a pesquisa.
                Carrega_Ficha_Aluno();                                                  // Chama o metodo que carrega a ficha do aluno.
                DB_PA.dados_alterados = false;
            }
            #endregion

            btn_cancelar.PerformClick();            // Trava os botoes novamente.
        }

        #endregion

        #region Metodo do Botao Historico.
        private void btn_historico_Click(object sender, EventArgs e)
        {
            frm_historico frm_Historico = new frm_historico();      // Instancia objeto para o frm_historico.
            frm_historico.volta_ficha_aluno = true;                 // Atribui true a variavel volta_ficha_aluno.
            DB_PA.Alunos_Codigo = selecao2[1];                      // Variavel Alunos codigo recebe o valor da variavel selecao2 posicao 1
            frm_Historico.Show();                                   // Abre o form historico.
            this.Close();                                           // fecha a tela.
        }
        #endregion

        #region Metodo de execucao ao carregar Tela.
        public void frm_ficha_alunos_Load(object sender, EventArgs e)
        {
            Carrega_Ficha_Aluno();      // Chama o metodo que carrega a ficha do aluno.
        }
        #endregion

        #region Metodo que carrega a ficha do aluno.

        public void Carrega_Ficha_Aluno()
        {
            char[] remove = new char[] { '|' };                                         // Criando um array de variaveis com caracteres que serao removidos da selecao.
            selecao2 = selecao.Split(remove, StringSplitOptions.RemoveEmptyEntries);    // Selecao2 recebe de selecao com os caracteres removidos.

            txtb_codigo.Text = selecao2[1];                                             // textbox recebe selecao na posicao do array.
            txtb_nome_aluno.Text = selecao2[3].ToString().Trim();                       // textbox recebe selecao na posicao do array.
            txtb_nome_responsavel.Text = selecao2[5];                                   // textbox recebe selecao na posicao do array.
            txtb_cpf.Text = selecao2[7];                                                // textbox recebe selecao na posicao do array.
            txtb_endereco.Text = selecao2[9].ToString().Trim();                         // textbox recebe selecao na posicao do array.
            txtb_bairro.Text = selecao2[11].ToString().Trim();                          // textbox recebe selecao na posicao do array.
            txtb_cidade.Text = selecao2[13].ToString().Trim();                          // textbox recebe selecao na posicao do array.
            txtb_cep.Text = selecao2[15].ToString().Trim();                             // textbox recebe selecao na posicao do array.
            txtb_telefone.Text = selecao2[17].ToString().Trim();                        // textbox recebe selecao na posicao do array.
            txtb_email.Text = selecao2[19].ToString().Trim();                           // textbox recebe selecao na posicao do array.
            txtb_contato_emergencia.Text = selecao2[21].ToString().Trim();              // textbox recebe selecao na posicao do array.
            txtb_telefone_emergencia_1.Text = selecao2[23].ToString().Trim();           // textbox recebe selecao na posicao do array.
            txtb_telefone_emergencia_2.Text = selecao2[25].ToString().Trim();           // textbox recebe selecao na posicao do array.
            DB_PA.Alunos_Codigo = txtb_codigo.Text.Trim();                              // textbox recebe codigo do aluno direto da variavel.
            dB_PA.Pesquisar_Imagem();                                                   // Chama o metodo de Pesquisar imagem
            byte[] imagem_byte = DB_PA.imagem_byte;                                     // Tranfere o array de byte da imagem.
            MemoryStream memoryStream = new MemoryStream(imagem_byte);                  // Manda para a memoria a imagem (Memorystream).
            pcb_imagem_aluno.Image = Image.FromStream(memoryStream);                    // Picturebox recebe a imagem decodificada da memoria.
            pcb_imagem_aluno.Refresh();                                                 // Atualiza o picturebox.
        }
        #endregion

    }
}

