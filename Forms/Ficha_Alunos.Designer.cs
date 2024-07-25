namespace Plantando_Alegria.Forms
{
    partial class frm_ficha_alunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcb_imagem_aluno = new System.Windows.Forms.PictureBox();
            this.btn_alterar_imagem = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_historico = new System.Windows.Forms.Button();
            this.lbl_nome_responsavel = new System.Windows.Forms.Label();
            this.txtb_nome_responsavel = new System.Windows.Forms.TextBox();
            this.txtb_cpf = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_tel_emergencia_1 = new System.Windows.Forms.Label();
            this.txtb_cep = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txtb_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_telefone_emergencia = new System.Windows.Forms.Label();
            this.lbl_contato_emergencia = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_nome_aluno = new System.Windows.Forms.Label();
            this.txtb_telefone_emergencia_1 = new System.Windows.Forms.TextBox();
            this.txtb_contato_emergencia = new System.Windows.Forms.TextBox();
            this.txtb_email = new System.Windows.Forms.TextBox();
            this.txtb_telefone = new System.Windows.Forms.TextBox();
            this.txtb_endereco = new System.Windows.Forms.TextBox();
            this.txtb_nome_aluno = new System.Windows.Forms.TextBox();
            this.txtb_codigo = new System.Windows.Forms.TextBox();
            this.lbl_cod_aluno = new System.Windows.Forms.Label();
            this.lbl_financas = new System.Windows.Forms.Button();
            this.cbbox_situacao_aluno = new System.Windows.Forms.ComboBox();
            this.lbl_situacao_aluno = new System.Windows.Forms.Label();
            this.txtb_situacao_aluno = new System.Windows.Forms.TextBox();
            this.txtb_data_situacao = new System.Windows.Forms.TextBox();
            this.lbl_titulo_2 = new System.Windows.Forms.Label();
            this.lbl_titulo_1 = new System.Windows.Forms.Label();
            this.btn_pesquisar_cep = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_tel_emergencia_2 = new System.Windows.Forms.Label();
            this.txtb_telefone_emergencia_2 = new System.Windows.Forms.TextBox();
            this.txtb_bairro = new System.Windows.Forms.TextBox();
            this.groupb_endereco = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem_aluno)).BeginInit();
            this.groupb_endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcb_imagem_aluno
            // 
            this.pcb_imagem_aluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcb_imagem_aluno.Image = global::Plantando_Alegria.Properties.Resources.maquina_fotografica;
            this.pcb_imagem_aluno.Location = new System.Drawing.Point(707, 31);
            this.pcb_imagem_aluno.Name = "pcb_imagem_aluno";
            this.pcb_imagem_aluno.Size = new System.Drawing.Size(145, 145);
            this.pcb_imagem_aluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_imagem_aluno.TabIndex = 77;
            this.pcb_imagem_aluno.TabStop = false;
            // 
            // btn_alterar_imagem
            // 
            this.btn_alterar_imagem.BackColor = System.Drawing.Color.White;
            this.btn_alterar_imagem.Enabled = false;
            this.btn_alterar_imagem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_alterar_imagem.FlatAppearance.BorderSize = 2;
            this.btn_alterar_imagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar_imagem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar_imagem.Location = new System.Drawing.Point(554, 141);
            this.btn_alterar_imagem.Name = "btn_alterar_imagem";
            this.btn_alterar_imagem.Size = new System.Drawing.Size(147, 35);
            this.btn_alterar_imagem.TabIndex = 61;
            this.btn_alterar_imagem.Text = "Alterar Imagem";
            this.btn_alterar_imagem.UseVisualStyleBackColor = false;
            this.btn_alterar_imagem.Visible = false;
            this.btn_alterar_imagem.Click += new System.EventHandler(this.btn_alterar_imagem_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(16, 565);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(70, 35);
            this.btn_voltar.TabIndex = 62;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.White;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.BorderSize = 2;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(99, 565);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(70, 35);
            this.btn_editar.TabIndex = 78;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_historico
            // 
            this.btn_historico.BackColor = System.Drawing.Color.White;
            this.btn_historico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_historico.FlatAppearance.BorderSize = 2;
            this.btn_historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historico.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historico.Location = new System.Drawing.Point(220, 565);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(94, 35);
            this.btn_historico.TabIndex = 81;
            this.btn_historico.Text = "Historico";
            this.btn_historico.UseVisualStyleBackColor = false;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // lbl_nome_responsavel
            // 
            this.lbl_nome_responsavel.AutoSize = true;
            this.lbl_nome_responsavel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_responsavel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_responsavel.Location = new System.Drawing.Point(25, 232);
            this.lbl_nome_responsavel.Name = "lbl_nome_responsavel";
            this.lbl_nome_responsavel.Size = new System.Drawing.Size(192, 22);
            this.lbl_nome_responsavel.TabIndex = 97;
            this.lbl_nome_responsavel.Text = "Nome do Responsável";
            // 
            // txtb_nome_responsavel
            // 
            this.txtb_nome_responsavel.Enabled = false;
            this.txtb_nome_responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_nome_responsavel.Location = new System.Drawing.Point(232, 235);
            this.txtb_nome_responsavel.Name = "txtb_nome_responsavel";
            this.txtb_nome_responsavel.Size = new System.Drawing.Size(586, 22);
            this.txtb_nome_responsavel.TabIndex = 85;
            // 
            // txtb_cpf
            // 
            this.txtb_cpf.Enabled = false;
            this.txtb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_cpf.Location = new System.Drawing.Point(416, 150);
            this.txtb_cpf.Name = "txtb_cpf";
            this.txtb_cpf.Size = new System.Drawing.Size(109, 22);
            this.txtb_cpf.TabIndex = 83;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(363, 148);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(41, 22);
            this.lbl_cpf.TabIndex = 103;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_tel_emergencia_1
            // 
            this.lbl_tel_emergencia_1.AutoSize = true;
            this.lbl_tel_emergencia_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tel_emergencia_1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel_emergencia_1.Location = new System.Drawing.Point(323, 190);
            this.lbl_tel_emergencia_1.Name = "lbl_tel_emergencia_1";
            this.lbl_tel_emergencia_1.Size = new System.Drawing.Size(20, 22);
            this.lbl_tel_emergencia_1.TabIndex = 106;
            this.lbl_tel_emergencia_1.Text = "1";
            // 
            // txtb_cep
            // 
            this.txtb_cep.Enabled = false;
            this.txtb_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_cep.Location = new System.Drawing.Point(76, 31);
            this.txtb_cep.Name = "txtb_cep";
            this.txtb_cep.Size = new System.Drawing.Size(79, 22);
            this.txtb_cep.TabIndex = 89;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(18, 28);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(41, 22);
            this.lbl_cep.TabIndex = 108;
            this.lbl_cep.Text = "CEP";
            // 
            // txtb_cidade
            // 
            this.txtb_cidade.Enabled = false;
            this.txtb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_cidade.Location = new System.Drawing.Point(588, 114);
            this.txtb_cidade.Name = "txtb_cidade";
            this.txtb_cidade.Size = new System.Drawing.Size(211, 22);
            this.txtb_cidade.TabIndex = 88;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(500, 111);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(66, 22);
            this.lbl_cidade.TabIndex = 104;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_telefone_emergencia
            // 
            this.lbl_telefone_emergencia.AutoSize = true;
            this.lbl_telefone_emergencia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefone_emergencia.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone_emergencia.Location = new System.Drawing.Point(17, 190);
            this.lbl_telefone_emergencia.Name = "lbl_telefone_emergencia";
            this.lbl_telefone_emergencia.Size = new System.Drawing.Size(300, 22);
            this.lbl_telefone_emergencia.TabIndex = 102;
            this.lbl_telefone_emergencia.Text = "Telefone do Contato de Emergencia";
            // 
            // lbl_contato_emergencia
            // 
            this.lbl_contato_emergencia.AutoSize = true;
            this.lbl_contato_emergencia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contato_emergencia.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contato_emergencia.Location = new System.Drawing.Point(17, 153);
            this.lbl_contato_emergencia.Name = "lbl_contato_emergencia";
            this.lbl_contato_emergencia.Size = new System.Drawing.Size(281, 22);
            this.lbl_contato_emergencia.TabIndex = 101;
            this.lbl_contato_emergencia.Text = "Nome do Contato de Emergência";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(363, 273);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(134, 22);
            this.lbl_email.TabIndex = 105;
            this.lbl_email.Text = "Email do Aluno";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(24, 273);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(79, 22);
            this.lbl_telefone.TabIndex = 100;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(18, 76);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(170, 22);
            this.lbl_endereco.TabIndex = 98;
            this.lbl_endereco.Text = "Endereco Completo";
            // 
            // lbl_nome_aluno
            // 
            this.lbl_nome_aluno.AutoSize = true;
            this.lbl_nome_aluno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_aluno.Location = new System.Drawing.Point(25, 199);
            this.lbl_nome_aluno.Name = "lbl_nome_aluno";
            this.lbl_nome_aluno.Size = new System.Drawing.Size(140, 22);
            this.lbl_nome_aluno.TabIndex = 96;
            this.lbl_nome_aluno.Text = "Nome do Aluno";
            // 
            // txtb_telefone_emergencia_1
            // 
            this.txtb_telefone_emergencia_1.Enabled = false;
            this.txtb_telefone_emergencia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_telefone_emergencia_1.Location = new System.Drawing.Point(347, 190);
            this.txtb_telefone_emergencia_1.Name = "txtb_telefone_emergencia_1";
            this.txtb_telefone_emergencia_1.Size = new System.Drawing.Size(118, 22);
            this.txtb_telefone_emergencia_1.TabIndex = 93;
            // 
            // txtb_contato_emergencia
            // 
            this.txtb_contato_emergencia.Enabled = false;
            this.txtb_contato_emergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_contato_emergencia.Location = new System.Drawing.Point(344, 155);
            this.txtb_contato_emergencia.Name = "txtb_contato_emergencia";
            this.txtb_contato_emergencia.Size = new System.Drawing.Size(467, 22);
            this.txtb_contato_emergencia.TabIndex = 92;
            // 
            // txtb_email
            // 
            this.txtb_email.Enabled = false;
            this.txtb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_email.Location = new System.Drawing.Point(509, 275);
            this.txtb_email.Name = "txtb_email";
            this.txtb_email.Size = new System.Drawing.Size(309, 22);
            this.txtb_email.TabIndex = 91;
            // 
            // txtb_telefone
            // 
            this.txtb_telefone.Enabled = false;
            this.txtb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_telefone.Location = new System.Drawing.Point(232, 276);
            this.txtb_telefone.Name = "txtb_telefone";
            this.txtb_telefone.Size = new System.Drawing.Size(99, 22);
            this.txtb_telefone.TabIndex = 90;
            // 
            // txtb_endereco
            // 
            this.txtb_endereco.Enabled = false;
            this.txtb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_endereco.Location = new System.Drawing.Point(213, 76);
            this.txtb_endereco.Name = "txtb_endereco";
            this.txtb_endereco.Size = new System.Drawing.Size(586, 22);
            this.txtb_endereco.TabIndex = 86;
            // 
            // txtb_nome_aluno
            // 
            this.txtb_nome_aluno.Enabled = false;
            this.txtb_nome_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_nome_aluno.Location = new System.Drawing.Point(232, 202);
            this.txtb_nome_aluno.Name = "txtb_nome_aluno";
            this.txtb_nome_aluno.Size = new System.Drawing.Size(586, 22);
            this.txtb_nome_aluno.TabIndex = 84;
            // 
            // txtb_codigo
            // 
            this.txtb_codigo.Enabled = false;
            this.txtb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_codigo.Location = new System.Drawing.Point(232, 150);
            this.txtb_codigo.Name = "txtb_codigo";
            this.txtb_codigo.Size = new System.Drawing.Size(109, 22);
            this.txtb_codigo.TabIndex = 82;
            // 
            // lbl_cod_aluno
            // 
            this.lbl_cod_aluno.AutoSize = true;
            this.lbl_cod_aluno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cod_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_aluno.Location = new System.Drawing.Point(25, 148);
            this.lbl_cod_aluno.Name = "lbl_cod_aluno";
            this.lbl_cod_aluno.Size = new System.Drawing.Size(150, 22);
            this.lbl_cod_aluno.TabIndex = 95;
            this.lbl_cod_aluno.Text = "Codigo do Aluno";
            // 
            // lbl_financas
            // 
            this.lbl_financas.BackColor = System.Drawing.Color.White;
            this.lbl_financas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_financas.FlatAppearance.BorderSize = 2;
            this.lbl_financas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_financas.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_financas.Location = new System.Drawing.Point(335, 565);
            this.lbl_financas.Name = "lbl_financas";
            this.lbl_financas.Size = new System.Drawing.Size(94, 35);
            this.lbl_financas.TabIndex = 109;
            this.lbl_financas.Text = "Finanças";
            this.lbl_financas.UseVisualStyleBackColor = false;
            this.lbl_financas.Click += new System.EventHandler(this.lbl_financas_Click);
            // 
            // cbbox_situacao_aluno
            // 
            this.cbbox_situacao_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbox_situacao_aluno.FormattingEnabled = true;
            this.cbbox_situacao_aluno.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbbox_situacao_aluno.Location = new System.Drawing.Point(232, 109);
            this.cbbox_situacao_aluno.Name = "cbbox_situacao_aluno";
            this.cbbox_situacao_aluno.Size = new System.Drawing.Size(121, 24);
            this.cbbox_situacao_aluno.TabIndex = 110;
            this.cbbox_situacao_aluno.Visible = false;
            // 
            // lbl_situacao_aluno
            // 
            this.lbl_situacao_aluno.AutoSize = true;
            this.lbl_situacao_aluno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_situacao_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situacao_aluno.Location = new System.Drawing.Point(25, 108);
            this.lbl_situacao_aluno.Name = "lbl_situacao_aluno";
            this.lbl_situacao_aluno.Size = new System.Drawing.Size(159, 22);
            this.lbl_situacao_aluno.TabIndex = 111;
            this.lbl_situacao_aluno.Text = "Situacao do Aluno";
            // 
            // txtb_situacao_aluno
            // 
            this.txtb_situacao_aluno.Enabled = false;
            this.txtb_situacao_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_situacao_aluno.Location = new System.Drawing.Point(232, 109);
            this.txtb_situacao_aluno.Name = "txtb_situacao_aluno";
            this.txtb_situacao_aluno.Size = new System.Drawing.Size(83, 22);
            this.txtb_situacao_aluno.TabIndex = 112;
            this.txtb_situacao_aluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb_data_situacao
            // 
            this.txtb_data_situacao.Enabled = false;
            this.txtb_data_situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_data_situacao.Location = new System.Drawing.Point(371, 108);
            this.txtb_data_situacao.Name = "txtb_data_situacao";
            this.txtb_data_situacao.Size = new System.Drawing.Size(202, 22);
            this.txtb_data_situacao.TabIndex = 113;
            // 
            // lbl_titulo_2
            // 
            this.lbl_titulo_2.AutoSize = true;
            this.lbl_titulo_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_2.Location = new System.Drawing.Point(240, 47);
            this.lbl_titulo_2.Name = "lbl_titulo_2";
            this.lbl_titulo_2.Size = new System.Drawing.Size(317, 25);
            this.lbl_titulo_2.TabIndex = 115;
            this.lbl_titulo_2.Text = "Escola de Circo e Produções";
            // 
            // lbl_titulo_1
            // 
            this.lbl_titulo_1.AutoSize = true;
            this.lbl_titulo_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo_1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_1.Location = new System.Drawing.Point(283, 16);
            this.lbl_titulo_1.Name = "lbl_titulo_1";
            this.lbl_titulo_1.Size = new System.Drawing.Size(232, 31);
            this.lbl_titulo_1.TabIndex = 114;
            this.lbl_titulo_1.Text = "Plantando Alegria";
            // 
            // btn_pesquisar_cep
            // 
            this.btn_pesquisar_cep.BackColor = System.Drawing.Color.White;
            this.btn_pesquisar_cep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pesquisar_cep.FlatAppearance.BorderSize = 2;
            this.btn_pesquisar_cep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar_cep.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar_cep.Location = new System.Drawing.Point(213, 22);
            this.btn_pesquisar_cep.Name = "btn_pesquisar_cep";
            this.btn_pesquisar_cep.Size = new System.Drawing.Size(128, 35);
            this.btn_pesquisar_cep.TabIndex = 116;
            this.btn_pesquisar_cep.Text = "Pesquisar CEP";
            this.btn_pesquisar_cep.UseVisualStyleBackColor = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.White;
            this.btn_limpar.Enabled = false;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_limpar.FlatAppearance.BorderSize = 2;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(659, 565);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(92, 35);
            this.btn_limpar.TabIndex = 63;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Visible = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.White;
            this.btn_salvar.Enabled = false;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_salvar.FlatAppearance.BorderSize = 2;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(487, 565);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(70, 35);
            this.btn_salvar.TabIndex = 79;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Visible = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 2;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(563, 565);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 35);
            this.btn_cancelar.TabIndex = 80;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(18, 111);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(60, 22);
            this.lbl_bairro.TabIndex = 99;
            this.lbl_bairro.Text = "Bairro";
            // 
            // lbl_tel_emergencia_2
            // 
            this.lbl_tel_emergencia_2.AutoSize = true;
            this.lbl_tel_emergencia_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tel_emergencia_2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel_emergencia_2.Location = new System.Drawing.Point(498, 190);
            this.lbl_tel_emergencia_2.Name = "lbl_tel_emergencia_2";
            this.lbl_tel_emergencia_2.Size = new System.Drawing.Size(20, 22);
            this.lbl_tel_emergencia_2.TabIndex = 107;
            this.lbl_tel_emergencia_2.Text = "2";
            // 
            // txtb_telefone_emergencia_2
            // 
            this.txtb_telefone_emergencia_2.Enabled = false;
            this.txtb_telefone_emergencia_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_telefone_emergencia_2.Location = new System.Drawing.Point(522, 192);
            this.txtb_telefone_emergencia_2.Name = "txtb_telefone_emergencia_2";
            this.txtb_telefone_emergencia_2.Size = new System.Drawing.Size(134, 22);
            this.txtb_telefone_emergencia_2.TabIndex = 94;
            // 
            // txtb_bairro
            // 
            this.txtb_bairro.Enabled = false;
            this.txtb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_bairro.Location = new System.Drawing.Point(213, 113);
            this.txtb_bairro.Name = "txtb_bairro";
            this.txtb_bairro.Size = new System.Drawing.Size(257, 22);
            this.txtb_bairro.TabIndex = 87;
            // 
            // groupb_endereco
            // 
            this.groupb_endereco.Controls.Add(this.txtb_bairro);
            this.groupb_endereco.Controls.Add(this.btn_pesquisar_cep);
            this.groupb_endereco.Controls.Add(this.txtb_telefone_emergencia_2);
            this.groupb_endereco.Controls.Add(this.lbl_tel_emergencia_2);
            this.groupb_endereco.Controls.Add(this.lbl_tel_emergencia_1);
            this.groupb_endereco.Controls.Add(this.txtb_cidade);
            this.groupb_endereco.Controls.Add(this.lbl_cidade);
            this.groupb_endereco.Controls.Add(this.lbl_bairro);
            this.groupb_endereco.Controls.Add(this.lbl_telefone_emergencia);
            this.groupb_endereco.Controls.Add(this.lbl_contato_emergencia);
            this.groupb_endereco.Controls.Add(this.lbl_endereco);
            this.groupb_endereco.Controls.Add(this.txtb_telefone_emergencia_1);
            this.groupb_endereco.Controls.Add(this.txtb_contato_emergencia);
            this.groupb_endereco.Controls.Add(this.txtb_endereco);
            this.groupb_endereco.Controls.Add(this.lbl_cep);
            this.groupb_endereco.Controls.Add(this.txtb_cep);
            this.groupb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupb_endereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupb_endereco.Location = new System.Drawing.Point(7, 312);
            this.groupb_endereco.Name = "groupb_endereco";
            this.groupb_endereco.Size = new System.Drawing.Size(851, 232);
            this.groupb_endereco.TabIndex = 117;
            this.groupb_endereco.TabStop = false;
            // 
            // frm_ficha_alunos
            // 
            this.AcceptButton = this.btn_historico;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(870, 632);
            this.ControlBox = false;
            this.Controls.Add(this.groupb_endereco);
            this.Controls.Add(this.lbl_titulo_2);
            this.Controls.Add(this.lbl_titulo_1);
            this.Controls.Add(this.txtb_data_situacao);
            this.Controls.Add(this.txtb_situacao_aluno);
            this.Controls.Add(this.cbbox_situacao_aluno);
            this.Controls.Add(this.lbl_situacao_aluno);
            this.Controls.Add(this.lbl_financas);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome_responsavel);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txtb_nome_responsavel);
            this.Controls.Add(this.txtb_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txtb_email);
            this.Controls.Add(this.txtb_telefone);
            this.Controls.Add(this.lbl_nome_aluno);
            this.Controls.Add(this.txtb_nome_aluno);
            this.Controls.Add(this.txtb_codigo);
            this.Controls.Add(this.lbl_cod_aluno);
            this.Controls.Add(this.btn_historico);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.pcb_imagem_aluno);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_alterar_imagem);
            this.Controls.Add(this.btn_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_ficha_alunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantando Alegria - Ficha do Aluno";
            this.Load += new System.EventHandler(this.frm_ficha_alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem_aluno)).EndInit();
            this.groupb_endereco.ResumeLayout(false);
            this.groupb_endereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_alterar_imagem;
        private System.Windows.Forms.Button btn_voltar;
        public System.Windows.Forms.PictureBox pcb_imagem_aluno;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.Label lbl_nome_responsavel;
        private System.Windows.Forms.TextBox txtb_nome_responsavel;
        private System.Windows.Forms.TextBox txtb_cpf;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_tel_emergencia_1;
        private System.Windows.Forms.TextBox txtb_cep;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txtb_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_telefone_emergencia;
        private System.Windows.Forms.Label lbl_contato_emergencia;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_nome_aluno;
        private System.Windows.Forms.TextBox txtb_telefone_emergencia_1;
        private System.Windows.Forms.TextBox txtb_contato_emergencia;
        private System.Windows.Forms.TextBox txtb_email;
        private System.Windows.Forms.TextBox txtb_telefone;
        private System.Windows.Forms.TextBox txtb_endereco;
        private System.Windows.Forms.TextBox txtb_nome_aluno;
        private System.Windows.Forms.TextBox txtb_codigo;
        private System.Windows.Forms.Label lbl_cod_aluno;
        private System.Windows.Forms.Button lbl_financas;
        private System.Windows.Forms.ComboBox cbbox_situacao_aluno;
        private System.Windows.Forms.Label lbl_situacao_aluno;
        public System.Windows.Forms.TextBox txtb_situacao_aluno;
        public System.Windows.Forms.TextBox txtb_data_situacao;
        private System.Windows.Forms.Label lbl_titulo_2;
        private System.Windows.Forms.Label lbl_titulo_1;
        private System.Windows.Forms.Button btn_pesquisar_cep;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_tel_emergencia_2;
        private System.Windows.Forms.TextBox txtb_telefone_emergencia_2;
        private System.Windows.Forms.TextBox txtb_bairro;
        private System.Windows.Forms.GroupBox groupb_endereco;
    }
}