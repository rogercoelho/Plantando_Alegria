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
        public string selecao;       // variavel que recebe a selecao do checklistbox
        public string codigo_aluno;
        public frm_ficha_alunos()
        {
            InitializeComponent();
        }

        public void frm_ficha_alunos_Load(object sender, EventArgs e)
        {
            DB_PA dB_PA = new DB_PA();

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
            DB_PA.Cod_Aluno = txtb_codigo.Text;
            dB_PA.Pesquisar_Imagem();
            byte[] imagem_byte = DB_PA.imagem_byte;
            MemoryStream memoryStream = new MemoryStream(imagem_byte);
            pcb_imagem_aluno.Image = Image.FromStream(memoryStream);
            pcb_imagem_aluno.Refresh();




        }
    }
}

