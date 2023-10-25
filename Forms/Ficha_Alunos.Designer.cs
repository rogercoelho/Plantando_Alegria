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
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_alterar_imagem = new System.Windows.Forms.Button();
            this.lbl_ficha_aluno = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.txtb_telefone_emergencia_2 = new System.Windows.Forms.TextBox();
            this.lbl_tel_emergencia_2 = new System.Windows.Forms.Label();
            this.lbl_tel_emergencia_1 = new System.Windows.Forms.Label();
            this.txtb_cep = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txtb_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txtb_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
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
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_historico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_imagem_aluno
            // 
            this.pcb_imagem_aluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcb_imagem_aluno.Image = global::Plantando_Alegria.Properties.Resources.maquina_fotografica;
            this.pcb_imagem_aluno.Location = new System.Drawing.Point(595, 22);
            this.pcb_imagem_aluno.Name = "pcb_imagem_aluno";
            this.pcb_imagem_aluno.Size = new System.Drawing.Size(143, 139);
            this.pcb_imagem_aluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_imagem_aluno.TabIndex = 77;
            this.pcb_imagem_aluno.TabStop = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_limpar.Enabled = false;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_limpar.FlatAppearance.BorderSize = 2;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(659, 510);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(92, 35);
            this.btn_limpar.TabIndex = 63;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Visible = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_alterar_imagem
            // 
            this.btn_alterar_imagem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_alterar_imagem.Enabled = false;
            this.btn_alterar_imagem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_alterar_imagem.FlatAppearance.BorderSize = 2;
            this.btn_alterar_imagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar_imagem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar_imagem.Location = new System.Drawing.Point(442, 126);
            this.btn_alterar_imagem.Name = "btn_alterar_imagem";
            this.btn_alterar_imagem.Size = new System.Drawing.Size(147, 35);
            this.btn_alterar_imagem.TabIndex = 61;
            this.btn_alterar_imagem.Text = "Alterar Imagem";
            this.btn_alterar_imagem.UseVisualStyleBackColor = false;
            this.btn_alterar_imagem.Visible = false;
            this.btn_alterar_imagem.Click += new System.EventHandler(this.btn_alterar_imagem_Click);
            // 
            // lbl_ficha_aluno
            // 
            this.lbl_ficha_aluno.AutoSize = true;
            this.lbl_ficha_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ficha_aluno.Location = new System.Drawing.Point(147, 22);
            this.lbl_ficha_aluno.Name = "lbl_ficha_aluno";
            this.lbl_ficha_aluno.Size = new System.Drawing.Size(347, 26);
            this.lbl_ficha_aluno.TabIndex = 0;
            this.lbl_ficha_aluno.Text = "Plantando Alegria - Ficha do Aluno";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(16, 510);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(70, 35);
            this.btn_voltar.TabIndex = 62;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // txtb_telefone_emergencia_2
            // 
            this.txtb_telefone_emergencia_2.Enabled = false;
            this.txtb_telefone_emergencia_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_telefone_emergencia_2.Location = new System.Drawing.Point(476, 358);
            this.txtb_telefone_emergencia_2.Name = "txtb_telefone_emergencia_2";
            this.txtb_telefone_emergencia_2.Size = new System.Drawing.Size(134, 20);
            this.txtb_telefone_emergencia_2.TabIndex = 9;
            // 
            // lbl_tel_emergencia_2
            // 
            this.lbl_tel_emergencia_2.AutoSize = true;
            this.lbl_tel_emergencia_2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_tel_emergencia_2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel_emergencia_2.Location = new System.Drawing.Point(452, 356);
            this.lbl_tel_emergencia_2.Name = "lbl_tel_emergencia_2";
            this.lbl_tel_emergencia_2.Size = new System.Drawing.Size(18, 20);
            this.lbl_tel_emergencia_2.TabIndex = 21;
            this.lbl_tel_emergencia_2.Text = "2";
            // 
            // lbl_tel_emergencia_1
            // 
            this.lbl_tel_emergencia_1.AutoSize = true;
            this.lbl_tel_emergencia_1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_tel_emergencia_1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel_emergencia_1.Location = new System.Drawing.Point(287, 356);
            this.lbl_tel_emergencia_1.Name = "lbl_tel_emergencia_1";
            this.lbl_tel_emergencia_1.Size = new System.Drawing.Size(18, 20);
            this.lbl_tel_emergencia_1.TabIndex = 19;
            this.lbl_tel_emergencia_1.Text = "1";
            // 
            // txtb_cep
            // 
            this.txtb_cep.Enabled = false;
            this.txtb_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_cep.Location = new System.Drawing.Point(659, 240);
            this.txtb_cep.Name = "txtb_cep";
            this.txtb_cep.Size = new System.Drawing.Size(79, 20);
            this.txtb_cep.TabIndex = 4;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(617, 242);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(36, 20);
            this.lbl_cep.TabIndex = 20;
            this.lbl_cep.Text = "CEP";
            // 
            // txtb_cidade
            // 
            this.txtb_cidade.Enabled = false;
            this.txtb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_cidade.Location = new System.Drawing.Point(400, 240);
            this.txtb_cidade.Name = "txtb_cidade";
            this.txtb_cidade.Size = new System.Drawing.Size(211, 20);
            this.txtb_cidade.TabIndex = 3;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(334, 242);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(60, 20);
            this.lbl_cidade.TabIndex = 17;
            this.lbl_cidade.Text = "Cidade";
            // 
            // txtb_bairro
            // 
            this.txtb_bairro.Enabled = false;
            this.txtb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_bairro.Location = new System.Drawing.Point(70, 242);
            this.txtb_bairro.Name = "txtb_bairro";
            this.txtb_bairro.Size = new System.Drawing.Size(235, 20);
            this.txtb_bairro.TabIndex = 2;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(12, 242);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(52, 20);
            this.lbl_bairro.TabIndex = 13;
            this.lbl_bairro.Text = "Bairro";
            // 
            // lbl_telefone_emergencia
            // 
            this.lbl_telefone_emergencia.AutoSize = true;
            this.lbl_telefone_emergencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_telefone_emergencia.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone_emergencia.Location = new System.Drawing.Point(12, 356);
            this.lbl_telefone_emergencia.Name = "lbl_telefone_emergencia";
            this.lbl_telefone_emergencia.Size = new System.Drawing.Size(249, 20);
            this.lbl_telefone_emergencia.TabIndex = 16;
            this.lbl_telefone_emergencia.Text = "Telefone do Contato Emergencia";
            // 
            // lbl_contato_emergencia
            // 
            this.lbl_contato_emergencia.AutoSize = true;
            this.lbl_contato_emergencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_contato_emergencia.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contato_emergencia.Location = new System.Drawing.Point(12, 321);
            this.lbl_contato_emergencia.Name = "lbl_contato_emergencia";
            this.lbl_contato_emergencia.Size = new System.Drawing.Size(157, 20);
            this.lbl_contato_emergencia.TabIndex = 15;
            this.lbl_contato_emergencia.Text = "Contato Emergência";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(276, 272);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(118, 20);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email do Aluno";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(12, 272);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(144, 20);
            this.lbl_telefone.TabIndex = 14;
            this.lbl_telefone.Text = "Telefone do Aluno";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(12, 208);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(155, 20);
            this.lbl_endereco.TabIndex = 12;
            this.lbl_endereco.Text = "Endereco Completo";
            // 
            // lbl_nome_aluno
            // 
            this.lbl_nome_aluno.AutoSize = true;
            this.lbl_nome_aluno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_nome_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_aluno.Location = new System.Drawing.Point(12, 174);
            this.lbl_nome_aluno.Name = "lbl_nome_aluno";
            this.lbl_nome_aluno.Size = new System.Drawing.Size(125, 20);
            this.lbl_nome_aluno.TabIndex = 11;
            this.lbl_nome_aluno.Text = "Nome do Aluno";
            // 
            // txtb_telefone_emergencia_1
            // 
            this.txtb_telefone_emergencia_1.Enabled = false;
            this.txtb_telefone_emergencia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_telefone_emergencia_1.Location = new System.Drawing.Point(311, 356);
            this.txtb_telefone_emergencia_1.Name = "txtb_telefone_emergencia_1";
            this.txtb_telefone_emergencia_1.Size = new System.Drawing.Size(118, 20);
            this.txtb_telefone_emergencia_1.TabIndex = 8;
            // 
            // txtb_contato_emergencia
            // 
            this.txtb_contato_emergencia.Enabled = false;
            this.txtb_contato_emergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_contato_emergencia.Location = new System.Drawing.Point(175, 321);
            this.txtb_contato_emergencia.Name = "txtb_contato_emergencia";
            this.txtb_contato_emergencia.Size = new System.Drawing.Size(563, 20);
            this.txtb_contato_emergencia.TabIndex = 7;
            // 
            // txtb_email
            // 
            this.txtb_email.Enabled = false;
            this.txtb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_email.Location = new System.Drawing.Point(400, 272);
            this.txtb_email.Name = "txtb_email";
            this.txtb_email.Size = new System.Drawing.Size(338, 20);
            this.txtb_email.TabIndex = 6;
            // 
            // txtb_telefone
            // 
            this.txtb_telefone.Enabled = false;
            this.txtb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_telefone.Location = new System.Drawing.Point(162, 272);
            this.txtb_telefone.Name = "txtb_telefone";
            this.txtb_telefone.Size = new System.Drawing.Size(99, 20);
            this.txtb_telefone.TabIndex = 5;
            // 
            // txtb_endereco
            // 
            this.txtb_endereco.Enabled = false;
            this.txtb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_endereco.Location = new System.Drawing.Point(173, 210);
            this.txtb_endereco.Name = "txtb_endereco";
            this.txtb_endereco.Size = new System.Drawing.Size(565, 20);
            this.txtb_endereco.TabIndex = 1;
            // 
            // txtb_nome_aluno
            // 
            this.txtb_nome_aluno.Enabled = false;
            this.txtb_nome_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_nome_aluno.Location = new System.Drawing.Point(152, 176);
            this.txtb_nome_aluno.Name = "txtb_nome_aluno";
            this.txtb_nome_aluno.Size = new System.Drawing.Size(586, 20);
            this.txtb_nome_aluno.TabIndex = 0;
            // 
            // txtb_codigo
            // 
            this.txtb_codigo.Enabled = false;
            this.txtb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_codigo.Location = new System.Drawing.Point(152, 143);
            this.txtb_codigo.Name = "txtb_codigo";
            this.txtb_codigo.Size = new System.Drawing.Size(109, 20);
            this.txtb_codigo.TabIndex = 1;
            // 
            // lbl_cod_aluno
            // 
            this.lbl_cod_aluno.AutoSize = true;
            this.lbl_cod_aluno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_cod_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_aluno.Location = new System.Drawing.Point(12, 141);
            this.lbl_cod_aluno.Name = "lbl_cod_aluno";
            this.lbl_cod_aluno.Size = new System.Drawing.Size(134, 20);
            this.lbl_cod_aluno.TabIndex = 10;
            this.lbl_cod_aluno.Text = "Codigo do Aluno";
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.BorderSize = 2;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(99, 510);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(70, 35);
            this.btn_editar.TabIndex = 78;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_salvar.Enabled = false;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_salvar.FlatAppearance.BorderSize = 2;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(487, 510);
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
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 2;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(563, 510);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 35);
            this.btn_cancelar.TabIndex = 80;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_historico
            // 
            this.btn_historico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_historico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_historico.FlatAppearance.BorderSize = 2;
            this.btn_historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historico.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historico.Location = new System.Drawing.Point(280, 510);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(94, 35);
            this.btn_historico.TabIndex = 81;
            this.btn_historico.Text = "Historico";
            this.btn_historico.UseVisualStyleBackColor = false;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // frm_ficha_alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 557);
            this.ControlBox = false;
            this.Controls.Add(this.btn_historico);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txtb_telefone_emergencia_2);
            this.Controls.Add(this.lbl_tel_emergencia_2);
            this.Controls.Add(this.lbl_tel_emergencia_1);
            this.Controls.Add(this.txtb_cep);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txtb_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txtb_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_telefone_emergencia);
            this.Controls.Add(this.lbl_contato_emergencia);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_nome_aluno);
            this.Controls.Add(this.txtb_telefone_emergencia_1);
            this.Controls.Add(this.txtb_contato_emergencia);
            this.Controls.Add(this.txtb_email);
            this.Controls.Add(this.txtb_telefone);
            this.Controls.Add(this.txtb_endereco);
            this.Controls.Add(this.txtb_nome_aluno);
            this.Controls.Add(this.txtb_codigo);
            this.Controls.Add(this.lbl_cod_aluno);
            this.Controls.Add(this.pcb_imagem_aluno);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_alterar_imagem);
            this.Controls.Add(this.lbl_ficha_aluno);
            this.Controls.Add(this.btn_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_ficha_alunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantando Alegria - Ficha do Aluno";
            this.Load += new System.EventHandler(this.frm_ficha_alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_alterar_imagem;
        private System.Windows.Forms.Label lbl_ficha_aluno;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox txtb_telefone_emergencia_2;
        private System.Windows.Forms.Label lbl_tel_emergencia_2;
        private System.Windows.Forms.Label lbl_tel_emergencia_1;
        private System.Windows.Forms.TextBox txtb_cep;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txtb_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txtb_bairro;
        private System.Windows.Forms.Label lbl_bairro;
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
        public System.Windows.Forms.PictureBox pcb_imagem_aluno;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_historico;
    }
}