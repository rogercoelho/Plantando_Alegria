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
        public frm_ficha_alunos()
        {
            InitializeComponent();
        }

        private void frm_ficha_alunos_Load(object sender, EventArgs e)
        {
            DB_PA dB_PA = new DB_PA();
            frm_pesquisar_alunos frm_Pesquisar_Alunos = new frm_pesquisar_alunos();

            txtb_codigo.Text = frm_Pesquisar_Alunos.codigo_aluno;
            dB_PA.Cod_Aluno_1 = txtb_codigo.Text;
            dB_PA.Pesquisar_pelo_Codigo_tbl_alunos_cadastro();

            txtb_nome_aluno.Text = dB_PA.lista[1].ToString();
            txtb_telefone.Text = dB_PA.lista[2].ToString();
            txtb_email.Text = dB_PA.lista[3].ToString();
            txtb_endereco.Text = dB_PA.lista[4].ToString();
            txtb_bairro.Text = dB_PA.lista[5].ToString();
            txtb_cidade.Text = dB_PA.lista[6].ToString();
            txtb_cep.Text = dB_PA.lista[7].ToString();
            txtb_contato_emergencia.Text = dB_PA.lista[8].ToString();
            txtb_telefone_emergencia_1.Text = dB_PA.lista[9].ToString();
            txtb_telefone_emergencia_2.Text = dB_PA.lista[10].ToString();



        }
    }
}

