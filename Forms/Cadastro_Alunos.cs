using Plantando_Alegria.MysqlDb;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plantando_Alegria.Forms
{
    public partial class frm_cadastro_alunos : Form
    {
        private Alunos alunos;


        /* Instanciando objetos para a classe de mensagens e para a classe DB_PA */

        Mensagens mensagens = new Mensagens();       
        DB_PA dB_PA = new DB_PA();
        

        /* Metodo construtor */
        public frm_cadastro_alunos()
        {
            InitializeComponent();
            alunos = new Alunos();            
        }

        #region Inicio - Metodo do botao Voltar.
        public void btn_voltar_Click(object sender, EventArgs e)
        {
            /* Funcao -> Fecha a tela atual e abre a tela principal. 
             * - Instancia o objeto para a classe da tela principal.
             * - Chama o metodo que faz aparecer a tela principal.
             * - Chama o metodo que fecha a tela atual. */

            frm_tela_principal frm_Tela_Principal = new frm_tela_principal();  
            frm_Tela_Principal.Show();                                         
            this.Close();                                                      
        }
        #endregion Fim - Metodo do botao Voltar.

        #region Inicio - Metodo do Botao Limpar.
        public void btn_limpar_Click(object sender, EventArgs e)
        {
            /* Funcao -> Limpa os campos da tela de cadastro de alunos
             * e chama o metodo que carrega a foto padrao. */

            txtb_codigo.Clear();                    
            txtb_nome_aluno.Clear();                
            txtb_nome_responsavel.Clear();          
            txtb_cpf.Clear();                       
            txtb_endereco.Clear();                  
            txtb_bairro.Clear();                    
            txtb_cidade.Clear();                    
            txtb_cep.Clear();                       
            txtb_email.Clear();                     
            txtb_telefone.Clear();                  
            txtb_contato_emergencia.Clear();        
            txtb_telefone_emergencia_1.Clear();     
            txtb_telefone_emergencia_2.Clear();     
            foto_padrao();                          

        }
        #endregion Fim - Metodo do Botao Limpar.

        #region Inicio - Metodo do Botao Adicionar Aluno
        public void btn_adicionar_aluno_Click(object sender, EventArgs e)
        {
            alunos.Cadastrar_Aluno(Convert.ToInt32(txtb_codigo.Text), txtb_nome_aluno.Text.ToUpper().Trim(), txtb_cpf.Text.ToUpper().Trim(),
                                   txtb_nome_responsavel.Text.ToUpper().Trim(), txtb_endereco.Text.ToUpper().Trim(), txtb_bairro.Text.ToUpper().Trim(),
                                   txtb_cidade.Text.ToUpper().Trim(), txtb_cep.Text.ToUpper().Trim(), txtb_telefone.Text.ToUpper().Trim(),
                                   txtb_email.Text.ToUpper().Trim(), txtb_contato_emergencia.Text.ToUpper().Trim(), 
                                   txtb_telefone_emergencia_1.Text.ToUpper().Trim(), txtb_telefone_emergencia_2.Text.ToUpper().Trim(), "ATIVO");

            btn_limpar.PerformClick();
            
        }
        #endregion Fim - Metodo do Botao Adicionar Aluno

        #region Inicio - Metodo do botao inserir imagem.
        public void btn_inserir_imagem_Click(object sender, EventArgs e)
        {
            /*   Funcao -> Botao que seleciona a imagem do aluno para ser inserido no banco de dados.
             * - Instancia o objeto para a classe OpenfileDialog para ser chamado pelo botao.
             * - Utiliza o filtro do openFileDialog para identificar os tipos de arquivos que podem ser abertos.
             * - Se depois de selecionado o arquivo, for pressoinado o botao OK da janela de selecao.
             * - Transfere o caminho da foto selecionada do OpenFileDialog para a variavel que guarda o caminho da
             *   foto da tabela Alunos_Imagem.
             * - Mostra a imagem na picturebox da tela de cadastro de alunos infromando o imagelocation como sendo a variavel
             *   que guarda o caminho da foto da tabela Alunos_Imagem. */


            OpenFileDialog openfile = new OpenFileDialog();                             
            openfile.Filter = "Imagens (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png ";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                alunos.Alunos_endereco_da_foto = openfile.FileName.ToString();
                pcb_imagem_aluno.ImageLocation = alunos.Alunos_endereco_da_foto;
            }
        }

        #endregion Fim - Metodo do botao inserir imagem.

        #region Inicio - Metodo que carrega ao iniciar a tela.
        public void frm_cadastro_alunos_Load(object sender, EventArgs e)
        {
            foto_padrao();  // Chama o metodo do caminho onde a foto esta armazenada.
        }

        #endregion Fim - Metodo que carrega ao iniciar a tela.

        #region Inicio - Metodo do caminho da foto padrao.
        public void foto_padrao()
        {
            /* Funcao -> Define e carrega a foto padrao na tela.
             * - Primeiro carrega a foto padrao na picturebox que esta na pasta Resources do projeto.
             * - Depois para gravar a foto padrao na tabela Alunos_Imagem, é atribuido o caminho do local da foto
             *   na variavel que guarda o caminho para gravar na tabela do banco. */

            pcb_imagem_aluno.Image = Properties.Resources.maquina_fotografica; 
            alunos.Alunos_endereco_da_foto = "Resources/maquina_fotografica.png";
        }


        #endregion Fim - Metodo do caminho da foto padrao.

    }
}

#region Codigo comentado

//cadastro de alunos.
/*   Funcao -> Adiciona o aluno no banco de dados.
             * - Carrega as variaveis com os dados informado na tela de cadastro de alunos. As variaveis estao na classe DB_PA.
             * - Chama o metodo que verifica os dados das variaveis da tela de cadastro de alunos.
             * - Se os dados das variaveis foram validados, atribui verdadeiro na variavel que identifica se é cadastro.
             * - Chama o metodo que transfere as informacoes para as variaveis da tabela Alunos_Cadastro do banco de dados. 
             * - Chama o metodo da query do banco de dados (Insert). 
             * - Chama o metodo dos parametros da tabela Alunos_Cadastro.
             * - Chama o metodo que faz a conexao com o banco e grava o cadastro na tabela Alunos_Cadastro.
             *   Se o cadastro voltar OK inicia o processo de gavacao da imagem do aluno.
             * - Chama o metodo da query que insere a imagem (Insert).
             * - Chama o metodo que faz a tratativa da imagem reduzindo para 145 X 145 e salvando em png.
             * - Atribui null no Cad_ok para pegar nova posicao de status de gravacao no banco.
             * - Chama o metodo que faz a conexao com o banco e grava a imagem na tabela Alunos_Imagem.  
             * - Se a gravacao da imagem voltar OK, volta a atribuir falso na variavel que identifica
             *   se é cadastro e comeca a gravacao do log. Atribui verdadeiro na variavel que identifica se é log. 
             * - Chama o metodo da query que insere os dados na tabela Alunos_Cadastro_Log.
             * - Chama o metodo dos parametros do cadastro de log. 
             * - Atribui null no Cad_Ok para pegar nova posicao de status de gravacao no banco.
             * - Chama o metodo que faz a conexao do banco e grava o log. 
             * - Se o cadastro do log voltar OK, mostra a mensagem e executa o metodo do botao limpar para limpar
             *   todos os campos da tela de cadastro de alunos.
             * - Volta a atribuir falso na variavel que identifica se é log e limpa as informacoes da variavel que identifica se
             *   o cadastro voltou OK da gravacao do banco. */

//dB_PA.Limpar_Variaveis_Cadastro_Aluno();

//#region Inicio - Repassa os dados dos campos para as variaveis da tela.

//DB_PA.tela_cadastro_aluno_situacao = "ATIVO";
//DB_PA.tela_cadastro_aluno_codigo = txtb_codigo.Text.ToUpper();         
//DB_PA.tela_cadastro_cpf = txtb_cpf.Text.ToUpper();                                       
//DB_PA.tela_cadastro_aluno_nome = txtb_nome_aluno.Text.ToUpper();                         
//DB_PA.tela_cadastro_nome_responsavel = txtb_nome_responsavel.Text.ToUpper();             
//DB_PA.tela_cadastro_endereco = txtb_endereco.Text.ToUpper();                             
//DB_PA.tela_cadastro_bairro = txtb_bairro.Text.ToUpper();                                 
//DB_PA.tela_cadastro_cidade = txtb_cidade.Text.ToUpper();                                 
//DB_PA.tela_cadastro_cep = txtb_cep.Text.ToUpper();                                       
//DB_PA.tela_cadastro_telefone = txtb_telefone.Text.ToUpper();                             
//DB_PA.tela_cadastro_email = txtb_email.Text.ToUpper();                                   
//DB_PA.tela_cadastro_nome_contato_emergencia = txtb_contato_emergencia.Text.ToUpper();    
//DB_PA.tela_cadastro_tel_contato_emergencia_1 = txtb_telefone_emergencia_1.Text.ToUpper();
//DB_PA.tela_cadastro_tel_contato_emergencia_2 = txtb_telefone_emergencia_2.Text.ToUpper();

//#endregion Fim - Repassa os dados dos campos para as variaveis da tela.          

//dB_PA.Verifica_Campos_Tela_Cadastro_Aluno();   

//if (DB_PA.campos_validados == true)           
//{
//    DB_PA.e_cadastro = true;                  
//    dB_PA.Transfere_Cadastro_AlunosXTabela_Alunos_Cadastro();
//    dB_PA.Query_Cadastrar_Aluno();                  
//    dB_PA.Cadastrar_Atualizar_Alunos_Cadastro();    
//    dB_PA.Executa_Banco();
//    dB_PA.Transfere_Situacao_AlunoXTabela_Alunos_Situacao();
//    dB_PA.Query_Inserir_Situacao_Aluno();
//    dB_PA.Parametros_Inserir_Situacao_Alunos();
//    dB_PA.Executa_Banco();

//    if (DB_PA.Cad_Ok == "OK")                       
//    {
//        dB_PA.Query_Inserir_Imagem();               
//        dB_PA.Processa_Imagem();                    
//        DB_PA.Cad_Ok = null;
//        dB_PA.Executa_Banco();                      
//    }
//    DB_PA.e_cadastro = false;                       

//    if (DB_PA.Cad_Ok == "OK")
//    {
//        DB_PA.e_log = true;                         
//        dB_PA.Log_Query_Cadastrar_Aluno();          
//        dB_PA.Cadastrar_Log();                      
//        DB_PA.Cad_Ok = null;
//        dB_PA.Executa_Banco();                      

//        if (DB_PA.Cad_Ok == "OK")
//        {
//            mensagens.Mensagem_11();                
//            btn_limpar.PerformClick();              
//        }
//        DB_PA.e_log = false;
//        DB_PA.Cad_Ok = null;
//    }
//}

#endregion

