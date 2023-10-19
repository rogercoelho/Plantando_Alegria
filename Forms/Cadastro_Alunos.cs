﻿using Plantando_Alegria.MysqlDb;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_cadastro_alunos : Form
    {
        #region Instanciando objetos.
            
        frm_tela_principal frm_Tela_Principal = new frm_tela_principal();   // Instancia objeto para pa classe.
        DB_PA.Encerramento encerramento = new DB_PA.Encerramento();         // Instanciando objeto para a classe encerramento.     
        DB_PA dB_PA = new DB_PA();                                          // Instancia objeto para a classe DB_PA.

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

            DB_PA.Alunos_Codigo = txtb_codigo.Text.ToUpper();
            DB_PA.Alunos_Nome = txtb_nome_aluno.Text.ToUpper();
            DB_PA.Alunos_Telefone = txtb_telefone.Text.ToUpper();
            DB_PA.Alunos_Email = txtb_email.Text.ToUpper();
            DB_PA.Alunos_Endereco = txtb_endereco.Text.ToUpper();
            DB_PA.Alunos_Bairro = txtb_bairro.Text.ToUpper();
            DB_PA.Alunos_Cidade = txtb_cidade.Text.ToUpper();
            DB_PA.Alunos_CEP = txtb_cep.Text.ToUpper();
            DB_PA.Alunos_Contato_Emergencia = txtb_contato_emergencia.Text.ToUpper();
            DB_PA.Alunos_Telefone_Emergencia_1 = txtb_telefone_emergencia_1.Text.ToUpper();
            DB_PA.Alunos_Telefone_Emergencia_2 = txtb_telefone_emergencia_2.Text.ToUpper();

            #endregion      
            
            dB_PA.Verifica_Campos();                            // Chama o metodo que valida os campos.

            if (DB_PA.campos_validados == true)                 // Se estiver validado.
            {
                dB_PA.Query_Cadastrar_Aluno();                  // Chama o metodo da query de cadastro de alunos.
                dB_PA.Cadastrar_Atualizar_Alunos_Cadastro();    // Chama o metodo que prepara os dados para o banco.
                dB_PA.Executa_Banco();                          // Chama o metodo que grava no banco.
                
                if (DB_PA.e_cadastro == true)                   // Variavel que identifica que é um cadastro novo.
                {
                    DB_PA.e_cadastro = false;                   // Troca o valor da variavel para falso.
                    dB_PA.Query_Inserir_Imagem();               // Chama o metodo da query de inserir imagem.
                    dB_PA.Processa_Imagem();                    // chama o metodo que prepara a imagem para o banco.
                    dB_PA.Executa_Banco();                      // chama o metodo que grava no banco.
                }
            }

            #region Em caso de cadasto realizado com sucesso, limpa os textbox.

            if (DB_PA.Cad_Ok == "OK")
            {
                encerramento.Mensagem_11();                     // Mostra a mensagem.
                btn_limpar.PerformClick();                      // Limpa os campos
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
                DB_PA.caminho_foto_aluno = openfile.FileName.ToString();                // Pega o caminho da imagem selecionada.
                pcb_imagem_aluno.ImageLocation = DB_PA.caminho_foto_aluno;              // Mostra a imagem no PictureBox.
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
