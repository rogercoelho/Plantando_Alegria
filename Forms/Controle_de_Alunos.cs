using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_controle_de_alunos : Form
    {

        #region Inicio - Metodo Contrutor.
        public frm_controle_de_alunos()
        {
            InitializeComponent();
        }

        #endregion Fim - Metodo Contrutor.

        #region Inicio - Metodo Botao Consulta de Alunos.
        private void btn_consulta_alunos_Click(object sender, EventArgs e)
        {
            frm_consultar_alunos frm_Pesquisar_Alunos = new frm_consultar_alunos();     // Instanciando objeto para a classe Consultar_Alunos.
            frm_Pesquisar_Alunos.Show();                                                // Mostra a tela de consulta
            this.Close();                                                                // Esconde a tela principal
        }

        #endregion Fim - Metodo Botao Consulta de Alunos.

        #region Inicio - Metodo Botao Cadastro de Alunos.
        private void btn_cadastro_alunos_Click(object sender, EventArgs e)
        {
            frm_cadastro_alunos frm_Cadastro_Alunos = new frm_cadastro_alunos();        // Instanciando objeto para a classe Cadastro_Alunos.    
            frm_Cadastro_Alunos.Show();                                             // Mostra a tela de cadasto.
            this.Hide();                                                            // Esconde a tela principal.
        }

        #endregion Fim - Metodo Botao Cadastro de Alunos.

        #region Inicio - Metodo Botao Controle de Presenca.

        // Implementar Controlede presenca.

        #endregion Fim - Metodo Botao Controle de Presenca.

        #region Inicio - Metodo Botao Relatorio de Aluno.

        // Implementar Relatorio de aluno.

        #endregion Fim - Metodo Botao Relatorio de Aluno.

        #region Inicio - Metodo Botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_tela_principal = new frm_tela_principal();
            frm_tela_principal.Show();
            this.Close();
        }

        #endregion Fim - Metodo Botao Voltar.


    }
}
