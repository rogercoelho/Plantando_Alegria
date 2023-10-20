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
    public partial class frm_pesquisar_planos : Form
    {
        public frm_pesquisar_planos()
        {
            InitializeComponent();
        }

        #region Metodo do botao voltar.
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();
            frm_Tela_Principal.Show();
            this.Close();
        }
        #endregion

        #region Metodo do botao Limpar
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtb_codigo_plano.Clear();
            txtb_nome_plano.Clear();
            chkbox_resultado.Items.Clear();
        }

        #endregion

    }
}
