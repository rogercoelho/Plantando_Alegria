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
        #region Inicio - Metodo construtor.
        public frm_tela_principal()
        {
            InitializeComponent();
        }

        #endregion Fim - Metodo construtor.

        #region Inicio - Metodo Botao Controle de Alunos.
        private void btn_controle_alunos_Click(object sender, EventArgs e)
        {
            frm_controle_de_alunos frm_controle_de_alunos = new frm_controle_de_alunos();
            frm_controle_de_alunos.Show();
            this.Hide();
        }
        #endregion Fim - Metodo Botao Controle de Alunos.

        #region Inicio - Metodo Botao Controle de Planos.
        private void btn_controle_planos_Click(object sender, EventArgs e)
        {
            frm_controle_de_planos frm_controle_de_planos = new frm_controle_de_planos();
            frm_controle_de_planos.Show();
            this.Hide();
        }
        #endregion Fim - Metodo Botao Controle de Planos.

        #region Inicio - Metodo Botao Controle Financeiro.

        // Implementar Controle Financeiro.

        #endregion Fim - Metodo Botao Controle Financeiro.

        #region Inicio - Metodo Botao Suporte.

        // Implementar botado de suporte.

        #endregion Fim - Metodo Botao Suporte.

        #region Inicio - Metodo do Botao Sair.
        public void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Encerra a Aplicacao.
        }
        #endregion Fim - Metodo do Botao Sair.


    }
}
