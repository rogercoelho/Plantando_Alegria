using Plantando_Alegria.MysqlDb;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_ficha_alunos : Form
    {
        Mensagens mensagens = new Mensagens();                              // Instanciando objeto para a classe mensagens.    
        
        private Alunos alunos;

        public frm_ficha_alunos(Alunos ctor_alunos)
        {
            InitializeComponent();
            alunos = ctor_alunos;
  
        }

        #region Inicio - Metodo de execucao ao carregar Tela.
        public void frm_ficha_alunos_Load(object sender, EventArgs e)
        {
            /*    Funcao -> Metodo que carrega a ficha do aluno do aluno que foi selecionado no checklistbox
             *    da tela de pesquisa de alunos.
             *  - Primeiro chama o metodo de limpar todas as variaveis da tela de ficha de aluno. 
             *  - Chama a metodo que trata a selecao da tela de pesquisa de alunos e transfere para
             *    as variaveis da ficha de aluno.
             *  - Chama o metodo que repassa os dados das variaveis da ficha de aluno para as variaeis do banco.
             *  - Chama o metodo que pesquisa a imagem do aluno selecionado.
             *  - Chama o metodo que carrega a imagem do aluno selecionado na tela de ficha de aluno.
             *  - Chama o metodo que carrega os dados do aluno selecionado na tela de ficha do aluno.
             */

            pcb_imagem_aluno.Image = alunos.Foto_Aluno;
            txtb_situacao_aluno.Text = alunos.Alunos_situacao;
            txtb_data_situacao.Text = " - Matricula DIA - " + alunos.Alunos_Data_Situacao;
            txtb_codigo.Text = Convert.ToString(alunos.Alunos_codigo);
            txtb_nome_aluno.Text = alunos.Alunos_nome;
            txtb_cpf.Text = Convert.ToString(alunos.Alunos_cpf);
            txtb_nome_responsavel.Text = alunos.Alunos_nome_responsavel;
            txtb_endereco.Text = alunos.Alunos_endereco;
            txtb_bairro.Text = alunos.Alunos_bairro;
            txtb_cidade.Text = alunos.Alunos_cidade;
            txtb_cep.Text = alunos.Alunos_cep;
            txtb_telefone.Text = alunos.Alunos_telefone;
            txtb_email.Text = alunos.Alunos_email;
            txtb_contato_emergencia.Text = alunos.Alunos_nome_contato_emergencia;
            txtb_telefone_emergencia_1.Text = alunos.Alunos_tel_contato_emergencia_1;
            txtb_telefone_emergencia_2.Text = alunos.Alunos_tel_contato_emergencia_2;
        }
        #endregion Fim - Metodo de execucao ao carregar Tela.

        #region Inicio - Metodo do Botao Limpar.
        public void btn_limpar_Click(object sender, EventArgs e)
        {
            /*  Funcao -> Faz a limpeza dos campos da ficha do aluno e carrega
             *  a imagem padrao do aluno na picturebox.
             */

            txtb_nome_aluno.Clear();
            txtb_nome_responsavel.Clear();
            txtb_endereco.Clear();
            txtb_bairro.Clear();
            txtb_cidade.Clear();
            txtb_cep.Clear();
            txtb_telefone.Clear();
            txtb_email.Clear();
            txtb_contato_emergencia.Clear();
            txtb_telefone_emergencia_1.Clear();
            txtb_telefone_emergencia_2.Clear();
            pcb_imagem_aluno.Image = Properties.Resources.maquina_fotografica;
        }
        #endregion Fim - Metodo do Botao Limpar.

        #region Inicio - Metodo do Botao Voltar.
        public void btn_voltar_Click(object sender, EventArgs e)
        {
            /*  Funcao -> Metodo que volta para a tela principal e fecha a tela atual.
             *  - Instncia o objeto para a tela principal.
             *  - Chama o metodo que abre a tela principal.
             *  - Chama o metodo que fecha a tela atual.
             */

            frm_controle_de_alunos frm_controle_de_alunos = new frm_controle_de_alunos();
            frm_controle_de_alunos.Show();
            this.Close();
        }
        #endregion Fim - Metodo do Botao Voltar.

        #region Inicio - Metodo do Botao Editar.
        public void btn_editar_Click(object sender, EventArgs e)
        {
            /* Funcao -> Metodo que habilita e desabilita botoes da tela de ficha de cadastro.
             */

            txtb_nome_aluno.Enabled = true;
            txtb_nome_responsavel.Enabled = true;
            txtb_endereco.Enabled = true;
            txtb_bairro.Enabled = true;
            txtb_cidade.Enabled = true;
            txtb_cep.Enabled = true;
            txtb_telefone.Enabled = true;
            txtb_email.Enabled = true;
            txtb_contato_emergencia.Enabled = true;
            txtb_telefone_emergencia_1.Enabled = true;
            txtb_telefone_emergencia_2.Enabled = true;

            txtb_situacao_aluno.Visible = false;
            txtb_data_situacao.Visible = false;
            cbbox_situacao_aluno.Visible = true;
            cbbox_situacao_aluno.SelectedIndex = 0;
            btn_voltar.Visible = false;
            btn_editar.Visible = false;
            btn_limpar.Visible = true;
            btn_salvar.Visible = true;
            btn_cancelar.Visible = true;
            btn_alterar_imagem.Visible = true;

            btn_limpar.Enabled = true;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_alterar_imagem.Enabled = true;
            btn_voltar.Enabled = false;
            btn_editar.Enabled = false;
        }
        #endregion Fim - Metodo do Botao Editar.

        #region Inicio - Metodo do botao de Alterar Imagem.
        public void btn_alterar_imagem_Click(object sender, EventArgs e)
        {
            /*    Funcao -> metodo do botao que carreg  a nova imagem do aluno na ficha de alunos para ser atualizada.
             *  - Intancia o objeto para a classe openfiledialog, que é a janela de selecao de arquivos.
             *  - Filtra os tipos de arquivos a sere abertos pelo openfiledialog
             *  - Se a janela do openfile tiver o Ok pressionado.
             *  - Atribui o caminho do arquivo aberto no openfile para a variavel da tabela Alunos_imagem
             *  - Atribui o local da imagem na picturebox o conteudo do caminho da variavel caminho_foto_aluno.
             *  - Atribui true na variavel da tabela Alunos_Imagem que identifica que a foto foi alterada para
             *    poder efetuar o processo de gravacao no banco da nova imagem.
             */

            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Imagens (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png ";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                alunos.Alunos_endereco_da_foto = openfile.FileName.ToString();
                pcb_imagem_aluno.ImageLocation = alunos.Alunos_endereco_da_foto;
                alunos.Foto_alterada = true;
                
            }
        }
        #endregion Fim - Metodo do botao de Alterar Imagem.

        #region Inicio - Metodo do Botao Cancelar.
        public void btn_cancelar_Click(object sender, EventArgs e)
        {
            /*   Funcao -> Metodo que habilita, desabilita botoes, carrega a imagem do aluno e 
             *   carrega os dados da ficha do aluno.
             */

            txtb_nome_aluno.Enabled = false;
            txtb_nome_responsavel.Enabled = false;
            txtb_endereco.Enabled = false;
            txtb_bairro.Enabled = false;
            txtb_cidade.Enabled = false;
            txtb_cep.Enabled = false;
            txtb_telefone.Enabled = false;
            txtb_email.Enabled = false;
            txtb_contato_emergencia.Enabled = false;
            txtb_telefone_emergencia_1.Enabled = false;
            txtb_telefone_emergencia_2.Enabled = false;
            btn_alterar_imagem.Visible = false;
            btn_cancelar.Visible = false;
            btn_salvar.Visible = false;
            btn_limpar.Visible = false;
            btn_voltar.Visible = true;
            btn_editar.Visible = true;
            txtb_situacao_aluno.Visible = true;
            txtb_data_situacao.Visible = true;
            cbbox_situacao_aluno.Visible = false;
            btn_alterar_imagem.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_salvar.Enabled = false;
            btn_limpar.Enabled = false;
            btn_voltar.Enabled = true;
            btn_editar.Enabled = true;
            
        }
        #endregion

        #region Inicio - Metodo do botao Salvar.
        public void btn_salvar_Click(object sender, EventArgs e)
        {
            /*  Funcao -> Metodo do botao que salva as alteraçoes realizadas na ficha do aluno e
             *  faz a gravacao da atualizacao no banco de dados.
             *  - Repassa as informacoes dos campos para as variaveis da tela de ficha do aluno.
             *  - Chama o metodo que faz a verificacao dos campos digitados se estao conforme
             *    os parametros da tabela.
             *  - Chama o metodo que faz a compracao entre as variaveis da ficha do aluno e do banco.
             *  - Se houver diferenca entre as variaveis da ficha do aluno e as variaveis do banco, 
             *    a variavel que valida vai retornar como true, e ai transfere as informacoes das 
             *    variaveis da ficha do aluno para as variaveis do banco para iniciar o processo 
             *    de atualizacao dos dados do aluno selecionado.
             *  - Se as variaveis que identificam que a foto e os dados do aluno foram alterados,
             *    retornarem como true, entao inicia a atualizacao de ambos.
             *  - Chama o metodo da query que atualiza primeiro os dados do aluno.
             *  - Depois chama o metodo dos parametros da tabela Alunos_cadastro.
             *  - Chama o metodo que executa a gravacao no banco.
             *  - Depois de gravado os dados do aluno no banco, chama o metodo da query que altera
             *    a imagem do aluno.
             *  - Chama o metodo que executa o processamento da imagem e prepara ela para gravar no 
             *    banco de dados.
             *  - Chama denovo o metodo que executa a gravacao no banco.
             *  - Depois atribui true na variavel que identifica que devemos passar para o processo
             *    de gravacao de log.
             *  - Chama o metodo de query do log para os dados do aluno.
             *  - Chama o metodo dos parametros da tabela Alunos_cadastro_Log.
             *  - E por ultimo chama novamente o metodo que executa o banco.
             *  - Depois volta a atribuir false para as variaveis de validacao dados_alterados e
             *    campos_validados.
             *  - Por fim, mostra a mensagem na tela.
             *  - Se a alteracao foi apenas nos dados do aluno ou apenas na imagem do aluno, o
             *    procedimento de alteracao segue o mesmo, porem apenas a rotina da parte alterada.
             *  - Caso as vriaveis de validacao estiverem como false, significa que nao houve alteracao
             *    entre os dados digitados e o conteudo do banco de dados, neste caso apenas mostra a 
             *    mensagem em tela dizendo que nao teve alteracao.
             */

            
            alunos.Atualiza_Dados_Aluno(Convert.ToInt32(txtb_codigo.Text.ToUpper().Trim()), txtb_nome_aluno.Text.ToUpper().Trim(), txtb_cpf.Text.ToUpper().Trim(), txtb_nome_responsavel.Text.ToUpper().Trim(), 
                                       txtb_endereco.Text.ToUpper().Trim(), txtb_bairro.Text.ToUpper().Trim(),txtb_cidade.Text.ToUpper().Trim(),txtb_cep.Text.ToUpper().Trim(),
                                       txtb_telefone.Text.ToUpper().Trim(), txtb_email.Text.ToUpper().Trim(), txtb_contato_emergencia.Text.ToUpper().Trim(), 
                                       txtb_telefone_emergencia_1.Text.ToUpper().Trim(),txtb_telefone_emergencia_2.Text.ToUpper().Trim(), cbbox_situacao_aluno.SelectedItem.ToString());
  
           
        }

        #endregion Fim - Metodo do botao Salvar.

        #region Incio - Metodo do Botao Historico.
        private void btn_historico_Click(object sender, EventArgs e)
        {
            /*    Funcao -> Metodo que traz o log de alteracoes (historico) do aluno selecionado.
             *  - Primeiro instancia o objeto para a tela de historico.
             *  - Depois atribui true na variavel que identifica que o botao voltar deve retornar
             *    para a tela de ficha do aluno e nao do plano.
             *  - Ai confere de o codigo do aluno na tela de ficha do aluno nao esta em branco.
             *  - Se nao estiver em branco tranfere o conteudo da variavel do codigo da ficha do
             *    aluno para a variavel que comunica com o banco.
             *  - Chama o metodo que mostra a tela de historico.
             *  - chama o metodo que fecha a tela atual.
             */
            
            bool historico_aluno = true;

            frm_historico frm_Historico = new frm_historico(historico_aluno, txtb_codigo.Text);
            frm_Historico.Show();
            this.Close();
            
        }
        #endregion Fim - Metodo do Botao Historico.

        #region Inicio - Método do botao de financas do aluno.
        private void lbl_financas_Click(object sender, EventArgs e)
        {
            /*    Funcao -> Chama o metodo que abre a tela de financas do aluno.
             *  - Instancia o objeto para a tela de financas.
             *  - Chama o metodo que mostra a tela de financas.
             *  - chama o metodo que fecha a tela atual.
             */
            frm_financas_aluno frm_financas_aluno = new frm_financas_aluno();
            frm_financas_aluno.Show();
            this.Close();
        }

        #endregion Fim - Método do botao de financas do aluno.


        
    
    
    }
}

