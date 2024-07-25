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
    public partial class frm_financas_aluno : Form
    {
        private Alunos tabelaAlunos;

        #region Inicio - Instanciando Objetos.
        DB_PA dB_PA = new DB_PA();
        Mensagens mensagens = new Mensagens();
        #endregion Fim - Instanciando Objetos.

        #region Inicio - Variaveis Operacionais.

        public static bool   inserir_plano = false;                 // variavel que controla a visibilidade dos campos da tela de financas (btn cancelar)
        public static string tela_financas_data_plano_contratado;

        #endregion Fim - Variaveis operacionais.

        #region Inicio - Metodo Construtor.
        public frm_financas_aluno()
        {
            InitializeComponent();
            tabelaAlunos = new Alunos();
        }

        #endregion Fim - Metodo Construtor.

        #region Inicio - Metodo do Botao Voltar.

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_ficha_alunos frm_Ficha_Alunos = new frm_ficha_alunos(tabelaAlunos);
            frm_Ficha_Alunos.Show();
            this.Close();
        }

        #endregion Fim - Metodo do Botao Voltar.

        #region Inicio - Metodo de execucao ao carregar tela.

        private void Financas_Aluno_Load(object sender, EventArgs e)
        {

            dB_PA.Transfere_Informacoes_TBLXInicio_Financas_Aluno();
            txtb_codigo_aluno.Text = Convert.ToString(DB_PA.tela_financas_codigo_aluno);
            txtb_nome_aluno.Text = DB_PA.tela_financas_nome_aluno;
            pcb_imagem_financas_aluno.Image = DB_PA.imagem_aluno;
            dB_PA.Consultar_Parcelas_Pendentes();
            dtgridview_financas.DataSource = dB_PA.tela_financas_parcelas;

            if (dtgridview_financas[3, 0].Value != null)
            {

                string comparadata = dtgridview_financas[3, 0].Value.ToString();
                DateTime dt;
                dt = Convert.ToDateTime(comparadata);

                if (dt > DateTime.Now)
                {
                    lbl_situacao_resultado.ForeColor = Color.Green;
                    lbl_situacao_resultado.Text = "EM DIA";
                }
                else
                {
                    lbl_situacao_resultado.ForeColor = Color.Red;
                    lbl_situacao_resultado.Text = "EM ATRASO";
                }
            }
            else
            {
                lbl_situacao_resultado.ForeColor = Color.Orange;
                lbl_situacao_resultado.Text = "SEM PLANO ATIVO";
            }



        }

        #endregion Fim - Metodo de execucao ao carregar tela.

        #region Inicio - Metodo do botao Inserir Plano.

        private void btn_inserir_plano_Click(object sender, EventArgs e)
        {
            inserir_plano = true;
            
            dtgridview_financas.Visible = false;

            #region Inicio - Faz a pesquisa da lista de codigos de planos e carrega no combobox.

            DB_PA.tela_financas_pesquisar_plano = true;
            dB_PA.Tela_Financas_Busca_Codigo_Plano();
            dB_PA.Executa_Pesquisa();
            cbbox_codigo_plano.Items.AddRange(dB_PA.lista.ToArray());
            DB_PA.tela_financas_pesquisar_plano = false;

            #endregion Fim - Faz a pesquisa da lista de codigos de planos e carrega no combobox.

            #region Inicio - Controle do Botao Inserir Plano.

            lbl_codigo_plano.Visible = true;
            lbl_dia_plano.Visible = true;
            lbl_mes_plano.Visible = true;
            lbl_ano_plano.Visible = true;
            cbbox_codigo_plano.Visible = true;
            cbbox_dia_inicio_plano.Visible = true;
            cbbox_dia_inicio_plano.SelectedIndex = 0;
            cbbox_mes_inicio_plano.Visible = true;
            cbbox_mes_inicio_plano.SelectedIndex = 0;
            cbbox_ano_inicio_plano.Visible = true;
            cbbox_ano_inicio_plano.SelectedIndex = 0;
            btn_buscar.Visible = true;
            btn_confirmar_inclusao.Visible = true;
            btn_registrar_Pagamento.Visible = true;
            lbl_pgto_valor_total.Visible = true;
            txtb_registrar_pgto_valor_total.Visible = true;
            lbl_data_pgto.Visible = true;
            txtb_data_pgto.Visible = true;
            btn_registrar_observacao.Visible = true;
            txtb_registrar_observacao.Visible = true;
            btn_inserir_comprovante.Visible = true;
            btn_cancelar.Visible = true;

            #endregion Fim - Controle do Botao Inserir Plano.
        }

        #endregion Fim - Metodo do botao Inserir Plano.

        #region Inicio - Metodo do botao Buscar Planos.

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cbbox_codigo_plano.SelectedItem == null)
            {
                mensagens.Mensagem_44();
                return;
            }

            #region Inicio - Controle dos campos do botao Buscar.

            lbl_info.Visible = true;
            lbl_nome_plano.Visible = true;
            txtb_nome_plano.Visible = true;
            lbl_parcelas.Visible = true;
            txtb_parcelas.Visible = true;
            lbl_valor_mensal.Visible = true;
            txtb_valor_mensal.Visible = true;
            lbl_valor_total.Visible = true;
            txtb_valor_total.Visible = true;

            #endregion Fim - Controle dos campos do botao Buscar.

            #region Inicio - Carrega o plano selecionado.

            DB_PA.tbl_planos_cadastro_codigo = DB_PA.tela_financas_codigo_plano = cbbox_codigo_plano.SelectedItem.ToString();
            DB_PA.pesquisar_planos = true;
            
            dB_PA.Pesquisar_pelo_Codigo_tbl_planos_cadastro();
            dB_PA.Executa_Pesquisa();
            DB_PA.planos_selecao = Convert.ToString(dB_PA.lista[0]);
            dB_PA.Tela_Financas_Trata_Selecao_Plano();

            txtb_nome_plano.Text = DB_PA.tela_financas_nome_plano;
            txtb_parcelas.Text = DB_PA.tela_financas_qtd_meses_parcelas;
            txtb_valor_mensal.Text = Convert.ToString (DB_PA.tela_financas_valor_mensal);
            txtb_valor_mensal.Text = txtb_valor_mensal.Text.Replace(".", ",");
            txtb_valor_total.Text = Convert.ToString(DB_PA.tela_financas_valor_total);
            txtb_valor_total.Text = txtb_valor_total.Text.Replace(".", ",");
            DB_PA.pesquisar_planos = false;

            #endregion Fim - Carrega o plano selecionado.
        }

        #endregion Fim - Metodo do botao Buscar Planos.

        #region Inicio - Metodo do Botao Cancelar.

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            #region Inicio - Cancela insersao de plano do aluno.
            if (inserir_plano == true)
            {
                cbbox_codigo_plano.SelectedIndex = -1;
                cbbox_dia_inicio_plano.SelectedIndex = -1;
                cbbox_mes_inicio_plano.SelectedIndex = -1;
                cbbox_ano_inicio_plano.SelectedIndex = -1;
                txtb_nome_plano.Clear();
                txtb_parcelas.Clear();
                txtb_valor_mensal.Clear();
                txtb_valor_total.Clear();
                txtb_data_pgto.Clear();
                txtb_registrar_pgto_valor_total.Clear();
                txtb_registrar_observacao.Clear();

                lbl_info.Visible = false;
                lbl_nome_plano.Visible = false;
                lbl_parcelas.Visible = false;
                lbl_valor_mensal.Visible = false;
                lbl_valor_total.Visible = false;
                lbl_codigo_plano.Visible = false;
                lbl_dia_plano.Visible = false;
                lbl_mes_plano.Visible = false;
                lbl_ano_plano.Visible = false;
                cbbox_codigo_plano.Visible = false;
                cbbox_dia_inicio_plano.Visible = false;
                cbbox_mes_inicio_plano.Visible = false;
                cbbox_ano_inicio_plano.Visible = false;
                btn_buscar.Visible = false;
                btn_cancelar.Visible = false;
                inserir_plano = false;
                btn_confirmar_inclusao.Visible = false;
                btn_registrar_Pagamento.Visible = false;
                lbl_pgto_valor_total.Visible = false;
                txtb_registrar_pgto_valor_total.Visible = false;
                lbl_data_pgto.Visible = false;
                txtb_data_pgto.Visible = false;
                btn_inserir_comprovante.Visible = false;
                btn_registrar_observacao.Visible = false;
                txtb_registrar_observacao.Visible = false;
            }
            #endregion Fim - Cancela insersao de plano do aluno.

        }

        #endregion Fim - Metodo do Botao Cancelar.

        #region Inicio - Metodo do botao Confirmar Inclusao Plano.

            
        private void btn_confirmar_inclusao_Click(object sender, EventArgs e)
        {
        
            #region Inicio - Valida os campos da inclusão de plano.
            while (cbbox_codigo_plano.SelectedItem == null)
            {
                mensagens.Mensagem_23();
                return;
            }
            while (cbbox_dia_inicio_plano.SelectedItem == null)
            {
                mensagens.Mensagem_39(); 
                return;
            }
            while (cbbox_mes_inicio_plano.SelectedItem == null)
            {
                mensagens.Mensagem_40();
                return;
            }
            while (cbbox_ano_inicio_plano.SelectedItem == null)
            {
                mensagens.Mensagem_41();
                return;
            }
            #endregion Fim - Valida os campos da inclusão de plano.

            DB_PA.tela_financas_dia_plano = Convert.ToInt32(cbbox_dia_inicio_plano.SelectedItem);
            DB_PA.tela_financas_mes_plano = Convert.ToInt32(cbbox_mes_inicio_plano.SelectedItem);
            DB_PA.tela_financas_ano_plano = Convert.ToInt32(cbbox_ano_inicio_plano.SelectedItem);
           

            for (int i = 1; i <= Convert.ToInt32(txtb_parcelas.Text) ; i++)
            {
                tela_financas_data_plano_contratado = cbbox_dia_inicio_plano.SelectedItem + "/" + cbbox_mes_inicio_plano.SelectedItem + "/" + cbbox_ano_inicio_plano.SelectedItem;
                DB_PA.tela_financas_valor_mensal = Convert.ToDouble(txtb_valor_mensal.Text);
                DB_PA.tela_financas_data_parcelas = DB_PA.tela_financas_dia_plano + "/" + DB_PA.tela_financas_mes_plano + "/" + DB_PA.tela_financas_ano_plano;
                dB_PA.Incluir_Plano_Base_Aluno();
                dB_PA.Executa_Banco();
                DB_PA.tela_financas_numero_parcela++;
                
                if (DB_PA.tela_financas_mes_plano <12)
                {
                    DB_PA.tela_financas_mes_plano++;
                }
                else
                {
                    DB_PA.tela_financas_mes_plano = 1;
                    DB_PA.tela_financas_ano_plano++;
                }
                
            }

            DB_PA.tela_financas_numero_parcela = 1;
            if (DB_PA.Cad_Ok == "OK")
            {
                mensagens.Mensagem_43();
            }
        }



        #endregion Fim - Inicio - Metodo do botao Confirmar Inclusao Plano.

        #region Inicio - Metodo do Botao Relatorio.
        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            if (dtgridview_financas.Visible == true)
            {
                dtgridview_financas.Visible = false;
            }
            else 
            { 
                dtgridview_financas.Visible = true;
            }
            
        }

        #endregion Fim - Metodo do Botao Relatorio.

    }
}
