using Plantando_Alegria.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantando_Alegria
{
    public partial class frm_tela_principal : Form
    {

        #region Metodo construtor.
        public frm_tela_principal()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodo do botao Cadastro de Alunos.
        public void btn_cadastro_alunos_Click(object sender, EventArgs e)
        {
            #region Abre o form Cadastro de alunos e fecha o principal.
            
            frm_cadastro_alunos frm_Cadastro_Alunos = new frm_cadastro_alunos();        // Instanciando objeto para a classe Cadastro_Alunos.    
            frm_Cadastro_Alunos.Show();                                             // Mostra a tela de cadasto.
            this.Hide();                                                            // Esconde a tela principal.
            
            #endregion
        }
        #endregion

        #region Metodo do Botao Pesquisar Aluno. 
        public void btn_pesquisar_aluno_Click(object sender, EventArgs e)
        {
            #region Abre o formulario de Pesquisa de alunos.

            frm_pesquisar_alunos frm_Pesquisar_Alunos = new frm_pesquisar_alunos();     // Instanciando objeto para a classe Consultar_Alunos.
            frm_Pesquisar_Alunos.Show();                                                // Mostra a tela de consulta
            this.Hide();                                                                // Esconde a tela principal

            #endregion

        }
        #endregion

        #region Metodo do botao Cadastro de Planos.
        public void btn_cadastro_planos_Click(object sender, EventArgs e)
        {
            #region Abre o form Cadastro de Planos e fecha o principal.

            frm_cadastro_planos frm_Cadastro_Planos = new frm_cadastro_planos();        // Instanciando objeto para a classe Cadastro_Planos.
            frm_Cadastro_Planos.Show();     // Mostra a tela de cadastro de planos.
            this.Hide();                    // Esconde a tela Principal

            #endregion
        }

        #endregion

        public void btn_pesquisar_plano_Click(object sender, EventArgs e)
        {
            #region Abre o Form Consulta de Planos e Fecha o principal.

           // Consultar_Planos consultar_Planos = new Consultar_Planos();     // Instancia objeto para a classe Consultar Planos.
           // consultar_Planos.Show();                                        // Mostra a tela Consultar Planos.
            this.Hide();                                                    // Fecha a tela.

            #endregion
        }

        #region Metodo do Botao Sair.
        public void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Encerra a Aplicacao.
        }
        #endregion
    }
}
