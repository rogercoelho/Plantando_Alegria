using MySqlConnector;
using Plantando_Alegria.MysqlDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_ficha_alunos : Form
    {
        public string selecao;      // variavel que recebe a selecao do checklistbox


        public frm_ficha_alunos()
        {
            InitializeComponent();
        }

        private void frm_ficha_alunos_Load(object sender, EventArgs e)
        {
            frm_pesquisar_alunos frm_Pesquisar_Alunos = new frm_pesquisar_alunos();

            

            char[] remove = new char[] { '|' };                                                 // Criando um array de variaveis com caracteres que serao removidos da selecao.
            string[] selecao2 = selecao.Split(remove, StringSplitOptions.RemoveEmptyEntries);   // Selecao2 recebe de selecao com os caracteres removidos.

            txtb_codigo.Text = selecao2[1];
            txtb_nome_aluno.Text = selecao2[3].ToString();
            txtb_telefone.Text = selecao2[5].ToString();
            txtb_email.Text = selecao2[7].ToString();
            txtb_endereco.Text = selecao2[9].ToString();
            txtb_bairro.Text = selecao2[11].ToString();
            txtb_cidade.Text = selecao2[13].ToString();
            txtb_cep.Text = selecao2[15].ToString();
            txtb_contato_emergencia.Text = selecao2[17].ToString();
            txtb_telefone_emergencia_1.Text = selecao2[19].ToString();
            txtb_telefone_emergencia_2.Text = selecao2[21].ToString();



        }
    }
}

