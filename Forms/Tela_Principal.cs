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
        public frm_tela_principal()
        {
            InitializeComponent();
        }

        private void btn_cadastro_alunos_Click(object sender, EventArgs e)
        {
            #region Abre o form Cadastro de alunos e fecha o principal.
            frm_cadastro_alunos frm_Cadastro_Alunos = new frm_cadastro_alunos();    // Instancia objeto para a classe Cadastro_Alunos.
            frm_Cadastro_Alunos.Show();                                             // Mostra a tela de cadasto.
            this.Hide();                                                            // Esconde a tela principal.
            #endregion
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Encerra a Aplicacao.
        }

        private void btn_consultar_aluno_Click(object sender, EventArgs e)
        {
            #region Abre o formulario de consulta

           // Plantando_Alegria_Consultar_Aluno consultar_Aluno = new Plantando_Alegria_Consultar_Aluno();  // Instancia a classe Consultar_Alunos.

           // consultar_Aluno.Show();                                   // Mostra a tela de consulta
            this.Hide();                                              // Esconde a tela principal

            #endregion
        }

        private void btn_cadastro_planos_Click(object sender, EventArgs e)
        {
            #region Abre o form Cadastro de Planos e fecha o principal.

          //  Cadastro_Planos cadastro_planos = new Cadastro_Planos();        // Instancia a classe Cadastro_Planos.
          //  cadastro_planos.Show();                                         // Mostra a tela de cadastro de planos.
            this.Hide();                                                    // Esconde a tela Principal

            #endregion
        }

        private void btn_pesquisar_plano_Click(object sender, EventArgs e)
        {
            #region Abre o Form Consulta de Planos e Fecha o principal.

           // Consultar_Planos consultar_Planos = new Consultar_Planos();     // Instancia objeto para a classe Consultar Planos.
           // consultar_Planos.Show();                                        // Mostra a tela Consultar Planos.
            this.Hide();                                                    // Fecha a tela.

            #endregion
        }
    }
}
