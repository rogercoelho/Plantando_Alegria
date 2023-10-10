﻿using Microsoft.Win32;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using Plantando_Alegria.MysqlDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            #region Cadastra os dados no banco.

            codigo_aluno = Convert.ToInt32(txtb_codigo.Text); // converte o conteudo do textbox (string) em int.

            Alunos_Cadastro_mysql Alunos_Cadastro_Mysql = new Alunos_Cadastro_mysql(codigo_aluno, txtb_nome_aluno.Text.ToUpper(), txtb_endereco.Text.ToUpper(), txtb_bairro.Text.ToUpper(),
                                                                                    txtb_cidade.Text.ToUpper(), txtb_cep.Text.ToUpper(), txtb_telefone.Text.ToUpper(), txtb_email.Text.ToUpper(),
                                                                                    txtb_contato_emergencia.Text.ToUpper(), txtb_telefone_emergencia_1.Text.ToUpper(),
                                                                                    txtb_telefone_emergencia_2.Text.ToUpper());
            // Instanciando objeto da classe Alunos_Cadastro_mysql que retorna o conteudo das textbox em Caixa Alta (toUpper)



            DB_PA.Cadastrar_Aluno(Alunos_Cadastro_Mysql);   // Chama o metodo Cadastrar_Aluno da classe Db_PA com os valores do objeto Alunos_Cadastro_Mysql.

   

            #endregion

        }
        #endregion
    }
}
