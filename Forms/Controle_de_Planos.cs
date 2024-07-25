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
    public partial class frm_controle_de_planos : Form
    {
        public frm_controle_de_planos()
        {
            InitializeComponent();
        }

        #region Inicio - Metodo do Botao Consulta de Planos.
        private void btn_consulta_planos_Click(object sender, EventArgs e)
        {
            frm_pesquisar_planos frm_pesquisar_planos = new frm_pesquisar_planos();
            frm_pesquisar_planos.Show();
            this.Close();
        }

        #endregion Fim - Metodo do Botao Consulta de Planos.

        #region Inicio - Metodo do Botao Voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_tela_principal = new frm_tela_principal();
            frm_tela_principal.Show();
            this.Close();
        }






        #endregion Fim - Metodo do Botao Voltar.

        #region Inicio - Metodo do Botao Cadastro de Planos.
        private void btn_cadastro__planos_Click(object sender, EventArgs e)
        {
            frm_cadastro_planos frm_cadastro_planos = new frm_cadastro_planos();
            frm_cadastro_planos.Show();
            this.Close();
        }
        #endregion Fim - Metodo do Botao Cadastro de Planos.
    }
}
