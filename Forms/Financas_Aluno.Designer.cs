namespace Plantando_Alegria.Forms
{
    partial class frm_financas_aluno
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
            this.txtb_codigo_aluno = new System.Windows.Forms.TextBox();
            this.lbl_cod_aluno = new System.Windows.Forms.Label();
            this.lbl_financas_do_aluno = new System.Windows.Forms.Label();
            this.lbl_nome_aluno = new System.Windows.Forms.Label();
            this.txtb_nome_aluno = new System.Windows.Forms.TextBox();
            this.btn_inserir_plano = new System.Windows.Forms.Button();
            this.cbbox_codigo_plano = new System.Windows.Forms.ComboBox();
            this.lbl_codigo_plano = new System.Windows.Forms.Label();
            this.lbl_mes_plano = new System.Windows.Forms.Label();
            this.lbl_dia_plano = new System.Windows.Forms.Label();
            this.cbbox_mes_inicio_plano = new System.Windows.Forms.ComboBox();
            this.lbl_ano_plano = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_nome_plano = new System.Windows.Forms.TextBox();
            this.lbl_nome_plano = new System.Windows.Forms.Label();
            this.lbl_parcelas = new System.Windows.Forms.Label();
            this.txtb_parcelas = new System.Windows.Forms.TextBox();
            this.lbl_valor_mensal = new System.Windows.Forms.Label();
            this.txtb_valor_mensal = new System.Windows.Forms.TextBox();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.txtb_valor_total = new System.Windows.Forms.TextBox();
            this.cbbox_ano_inicio_plano = new System.Windows.Forms.ComboBox();
            this.btn_confirmar_inclusao = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pcb_imagem_financas_aluno = new System.Windows.Forms.PictureBox();
            this.lbl_Situacao = new System.Windows.Forms.Label();
            this.lbl_situacao_resultado = new System.Windows.Forms.Label();
            this.dtgridview_financas = new System.Windows.Forms.DataGridView();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.lbl_pgto_valor_total = new System.Windows.Forms.Label();
            this.btn_registrar_Pagamento = new System.Windows.Forms.Button();
            this.btn_registrar_observacao = new System.Windows.Forms.Button();
            this.txtb_registrar_pgto_valor_total = new System.Windows.Forms.TextBox();
            this.txtb_registrar_observacao = new System.Windows.Forms.TextBox();
            this.lbl_data_pgto = new System.Windows.Forms.Label();
            this.txtb_data_pgto = new System.Windows.Forms.TextBox();
            this.btn_inserir_comprovante = new System.Windows.Forms.Button();
            this.cbbox_dia_inicio_plano = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem_financas_aluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_financas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_codigo_aluno
            // 
            this.txtb_codigo_aluno.Enabled = false;
            this.txtb_codigo_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_codigo_aluno.Location = new System.Drawing.Point(152, 76);
            this.txtb_codigo_aluno.Name = "txtb_codigo_aluno";
            this.txtb_codigo_aluno.Size = new System.Drawing.Size(109, 22);
            this.txtb_codigo_aluno.TabIndex = 96;
            // 
            // lbl_cod_aluno
            // 
            this.lbl_cod_aluno.AutoSize = true;
            this.lbl_cod_aluno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_cod_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_aluno.Location = new System.Drawing.Point(12, 76);
            this.lbl_cod_aluno.Name = "lbl_cod_aluno";
            this.lbl_cod_aluno.Size = new System.Drawing.Size(134, 20);
            this.lbl_cod_aluno.TabIndex = 97;
            this.lbl_cod_aluno.Text = "Codigo do Aluno";
            // 
            // lbl_financas_do_aluno
            // 
            this.lbl_financas_do_aluno.AutoSize = true;
            this.lbl_financas_do_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_financas_do_aluno.Location = new System.Drawing.Point(194, 18);
            this.lbl_financas_do_aluno.Name = "lbl_financas_do_aluno";
            this.lbl_financas_do_aluno.Size = new System.Drawing.Size(379, 26);
            this.lbl_financas_do_aluno.TabIndex = 98;
            this.lbl_financas_do_aluno.Text = "Plantando Alegria - Finanças do Aluno";
            // 
            // lbl_nome_aluno
            // 
            this.lbl_nome_aluno.AutoSize = true;
            this.lbl_nome_aluno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_nome_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_aluno.Location = new System.Drawing.Point(12, 114);
            this.lbl_nome_aluno.Name = "lbl_nome_aluno";
            this.lbl_nome_aluno.Size = new System.Drawing.Size(125, 20);
            this.lbl_nome_aluno.TabIndex = 100;
            this.lbl_nome_aluno.Text = "Nome do Aluno";
            // 
            // txtb_nome_aluno
            // 
            this.txtb_nome_aluno.Enabled = false;
            this.txtb_nome_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_nome_aluno.Location = new System.Drawing.Point(143, 116);
            this.txtb_nome_aluno.Name = "txtb_nome_aluno";
            this.txtb_nome_aluno.Size = new System.Drawing.Size(488, 22);
            this.txtb_nome_aluno.TabIndex = 99;
            // 
            // btn_inserir_plano
            // 
            this.btn_inserir_plano.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_inserir_plano.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_inserir_plano.FlatAppearance.BorderSize = 2;
            this.btn_inserir_plano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir_plano.Location = new System.Drawing.Point(16, 155);
            this.btn_inserir_plano.Name = "btn_inserir_plano";
            this.btn_inserir_plano.Size = new System.Drawing.Size(143, 35);
            this.btn_inserir_plano.TabIndex = 110;
            this.btn_inserir_plano.Text = "Inserir Plano";
            this.btn_inserir_plano.UseVisualStyleBackColor = false;
            this.btn_inserir_plano.Click += new System.EventHandler(this.btn_inserir_plano_Click);
            // 
            // cbbox_codigo_plano
            // 
            this.cbbox_codigo_plano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_codigo_plano.FormattingEnabled = true;
            this.cbbox_codigo_plano.Location = new System.Drawing.Point(19, 233);
            this.cbbox_codigo_plano.Name = "cbbox_codigo_plano";
            this.cbbox_codigo_plano.Size = new System.Drawing.Size(121, 21);
            this.cbbox_codigo_plano.TabIndex = 111;
            this.cbbox_codigo_plano.Visible = false;
            // 
            // lbl_codigo_plano
            // 
            this.lbl_codigo_plano.AutoSize = true;
            this.lbl_codigo_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_codigo_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_plano.Location = new System.Drawing.Point(15, 210);
            this.lbl_codigo_plano.Name = "lbl_codigo_plano";
            this.lbl_codigo_plano.Size = new System.Drawing.Size(131, 20);
            this.lbl_codigo_plano.TabIndex = 112;
            this.lbl_codigo_plano.Text = "Codigo do Plano";
            this.lbl_codigo_plano.Visible = false;
            // 
            // lbl_mes_plano
            // 
            this.lbl_mes_plano.AutoSize = true;
            this.lbl_mes_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_mes_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes_plano.Location = new System.Drawing.Point(331, 207);
            this.lbl_mes_plano.Name = "lbl_mes_plano";
            this.lbl_mes_plano.Size = new System.Drawing.Size(174, 20);
            this.lbl_mes_plano.TabIndex = 113;
            this.lbl_mes_plano.Text = "Mes de Inicio do Plano";
            this.lbl_mes_plano.Visible = false;
            // 
            // lbl_dia_plano
            // 
            this.lbl_dia_plano.AutoSize = true;
            this.lbl_dia_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_dia_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia_plano.Location = new System.Drawing.Point(158, 210);
            this.lbl_dia_plano.Name = "lbl_dia_plano";
            this.lbl_dia_plano.Size = new System.Drawing.Size(166, 20);
            this.lbl_dia_plano.TabIndex = 114;
            this.lbl_dia_plano.Text = "Dia de Inicio do Plano";
            this.lbl_dia_plano.Visible = false;
            // 
            // cbbox_mes_inicio_plano
            // 
            this.cbbox_mes_inicio_plano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_mes_inicio_plano.FormattingEnabled = true;
            this.cbbox_mes_inicio_plano.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbox_mes_inicio_plano.Location = new System.Drawing.Point(351, 231);
            this.cbbox_mes_inicio_plano.Name = "cbbox_mes_inicio_plano";
            this.cbbox_mes_inicio_plano.Size = new System.Drawing.Size(121, 21);
            this.cbbox_mes_inicio_plano.TabIndex = 116;
            this.cbbox_mes_inicio_plano.Visible = false;
            // 
            // lbl_ano_plano
            // 
            this.lbl_ano_plano.AutoSize = true;
            this.lbl_ano_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_ano_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ano_plano.Location = new System.Drawing.Point(511, 207);
            this.lbl_ano_plano.Name = "lbl_ano_plano";
            this.lbl_ano_plano.Size = new System.Drawing.Size(173, 20);
            this.lbl_ano_plano.TabIndex = 117;
            this.lbl_ano_plano.Text = "Ano de Inicio do Plano";
            this.lbl_ano_plano.Visible = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatAppearance.BorderSize = 2;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(19, 264);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(143, 35);
            this.btn_buscar.TabIndex = 119;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Visible = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_info.Location = new System.Drawing.Point(172, 270);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(378, 22);
            this.lbl_info.TabIndex = 120;
            this.lbl_info.Text = "Será cadastrado o plano abaixo para o aluno:";
            this.lbl_info.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 121;
            this.label1.Visible = false;
            // 
            // txtb_nome_plano
            // 
            this.txtb_nome_plano.Enabled = false;
            this.txtb_nome_plano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_nome_plano.Location = new System.Drawing.Point(146, 311);
            this.txtb_nome_plano.Name = "txtb_nome_plano";
            this.txtb_nome_plano.Size = new System.Drawing.Size(358, 22);
            this.txtb_nome_plano.TabIndex = 122;
            this.txtb_nome_plano.Visible = false;
            // 
            // lbl_nome_plano
            // 
            this.lbl_nome_plano.AutoSize = true;
            this.lbl_nome_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_nome_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_plano.Location = new System.Drawing.Point(18, 311);
            this.lbl_nome_plano.Name = "lbl_nome_plano";
            this.lbl_nome_plano.Size = new System.Drawing.Size(122, 20);
            this.lbl_nome_plano.TabIndex = 123;
            this.lbl_nome_plano.Text = "Nome do Plano";
            this.lbl_nome_plano.Visible = false;
            // 
            // lbl_parcelas
            // 
            this.lbl_parcelas.AutoSize = true;
            this.lbl_parcelas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_parcelas.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parcelas.Location = new System.Drawing.Point(18, 342);
            this.lbl_parcelas.Name = "lbl_parcelas";
            this.lbl_parcelas.Size = new System.Drawing.Size(68, 20);
            this.lbl_parcelas.TabIndex = 124;
            this.lbl_parcelas.Text = "Parcelas";
            this.lbl_parcelas.Visible = false;
            // 
            // txtb_parcelas
            // 
            this.txtb_parcelas.Enabled = false;
            this.txtb_parcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_parcelas.Location = new System.Drawing.Point(146, 342);
            this.txtb_parcelas.Name = "txtb_parcelas";
            this.txtb_parcelas.Size = new System.Drawing.Size(109, 22);
            this.txtb_parcelas.TabIndex = 125;
            this.txtb_parcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_parcelas.Visible = false;
            // 
            // lbl_valor_mensal
            // 
            this.lbl_valor_mensal.AutoSize = true;
            this.lbl_valor_mensal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_valor_mensal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_mensal.Location = new System.Drawing.Point(18, 372);
            this.lbl_valor_mensal.Name = "lbl_valor_mensal";
            this.lbl_valor_mensal.Size = new System.Drawing.Size(103, 20);
            this.lbl_valor_mensal.TabIndex = 126;
            this.lbl_valor_mensal.Text = "Valor Mensal";
            this.lbl_valor_mensal.Visible = false;
            // 
            // txtb_valor_mensal
            // 
            this.txtb_valor_mensal.Enabled = false;
            this.txtb_valor_mensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_valor_mensal.Location = new System.Drawing.Point(146, 372);
            this.txtb_valor_mensal.Name = "txtb_valor_mensal";
            this.txtb_valor_mensal.Size = new System.Drawing.Size(109, 22);
            this.txtb_valor_mensal.TabIndex = 127;
            this.txtb_valor_mensal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_valor_mensal.Visible = false;
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_valor_total.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_total.Location = new System.Drawing.Point(18, 401);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(88, 20);
            this.lbl_valor_total.TabIndex = 128;
            this.lbl_valor_total.Text = "Valor Total";
            this.lbl_valor_total.Visible = false;
            // 
            // txtb_valor_total
            // 
            this.txtb_valor_total.Enabled = false;
            this.txtb_valor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_valor_total.Location = new System.Drawing.Point(146, 401);
            this.txtb_valor_total.Name = "txtb_valor_total";
            this.txtb_valor_total.Size = new System.Drawing.Size(109, 22);
            this.txtb_valor_total.TabIndex = 129;
            this.txtb_valor_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_valor_total.Visible = false;
            // 
            // cbbox_ano_inicio_plano
            // 
            this.cbbox_ano_inicio_plano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_ano_inicio_plano.FormattingEnabled = true;
            this.cbbox_ano_inicio_plano.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034"});
            this.cbbox_ano_inicio_plano.Location = new System.Drawing.Point(531, 231);
            this.cbbox_ano_inicio_plano.Name = "cbbox_ano_inicio_plano";
            this.cbbox_ano_inicio_plano.Size = new System.Drawing.Size(121, 21);
            this.cbbox_ano_inicio_plano.TabIndex = 130;
            this.cbbox_ano_inicio_plano.Visible = false;
            // 
            // btn_confirmar_inclusao
            // 
            this.btn_confirmar_inclusao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_confirmar_inclusao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_confirmar_inclusao.FlatAppearance.BorderSize = 2;
            this.btn_confirmar_inclusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar_inclusao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar_inclusao.Location = new System.Drawing.Point(562, 264);
            this.btn_confirmar_inclusao.Name = "btn_confirmar_inclusao";
            this.btn_confirmar_inclusao.Size = new System.Drawing.Size(167, 35);
            this.btn_confirmar_inclusao.TabIndex = 131;
            this.btn_confirmar_inclusao.Text = "Confirmar Inclusão";
            this.btn_confirmar_inclusao.UseVisualStyleBackColor = false;
            this.btn_confirmar_inclusao.Visible = false;
            this.btn_confirmar_inclusao.Click += new System.EventHandler(this.btn_confirmar_inclusao_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 2;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(16, 585);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(143, 35);
            this.btn_cancelar.TabIndex = 132;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(743, 585);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(70, 35);
            this.btn_voltar.TabIndex = 133;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pcb_imagem_financas_aluno
            // 
            this.pcb_imagem_financas_aluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcb_imagem_financas_aluno.Image = global::Plantando_Alegria.Properties.Resources.maquina_fotografica;
            this.pcb_imagem_financas_aluno.Location = new System.Drawing.Point(657, 18);
            this.pcb_imagem_financas_aluno.Name = "pcb_imagem_financas_aluno";
            this.pcb_imagem_financas_aluno.Size = new System.Drawing.Size(145, 145);
            this.pcb_imagem_financas_aluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_imagem_financas_aluno.TabIndex = 134;
            this.pcb_imagem_financas_aluno.TabStop = false;
            // 
            // lbl_Situacao
            // 
            this.lbl_Situacao.AutoSize = true;
            this.lbl_Situacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Situacao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Situacao.Location = new System.Drawing.Point(282, 77);
            this.lbl_Situacao.Name = "lbl_Situacao";
            this.lbl_Situacao.Size = new System.Drawing.Size(92, 20);
            this.lbl_Situacao.TabIndex = 135;
            this.lbl_Situacao.Text = "Situação ->";
            // 
            // lbl_situacao_resultado
            // 
            this.lbl_situacao_resultado.AutoSize = true;
            this.lbl_situacao_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situacao_resultado.Location = new System.Drawing.Point(383, 75);
            this.lbl_situacao_resultado.Name = "lbl_situacao_resultado";
            this.lbl_situacao_resultado.Size = new System.Drawing.Size(0, 24);
            this.lbl_situacao_resultado.TabIndex = 136;
            // 
            // dtgridview_financas
            // 
            this.dtgridview_financas.BackgroundColor = System.Drawing.Color.White;
            this.dtgridview_financas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridview_financas.Location = new System.Drawing.Point(321, 212);
            this.dtgridview_financas.Name = "dtgridview_financas";
            this.dtgridview_financas.Size = new System.Drawing.Size(388, 280);
            this.dtgridview_financas.TabIndex = 137;
            this.dtgridview_financas.Visible = false;
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_relatorio.FlatAppearance.BorderSize = 2;
            this.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relatorio.Location = new System.Drawing.Point(176, 155);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(143, 35);
            this.btn_relatorio.TabIndex = 138;
            this.btn_relatorio.Text = "Relatório";
            this.btn_relatorio.UseVisualStyleBackColor = false;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // lbl_pgto_valor_total
            // 
            this.lbl_pgto_valor_total.AutoSize = true;
            this.lbl_pgto_valor_total.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_pgto_valor_total.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pgto_valor_total.Location = new System.Drawing.Point(558, 359);
            this.lbl_pgto_valor_total.Name = "lbl_pgto_valor_total";
            this.lbl_pgto_valor_total.Size = new System.Drawing.Size(88, 20);
            this.lbl_pgto_valor_total.TabIndex = 139;
            this.lbl_pgto_valor_total.Text = "Valor Total";
            this.lbl_pgto_valor_total.Visible = false;
            // 
            // btn_registrar_Pagamento
            // 
            this.btn_registrar_Pagamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_registrar_Pagamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_registrar_Pagamento.FlatAppearance.BorderSize = 2;
            this.btn_registrar_Pagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_Pagamento.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_Pagamento.Location = new System.Drawing.Point(562, 311);
            this.btn_registrar_Pagamento.Name = "btn_registrar_Pagamento";
            this.btn_registrar_Pagamento.Size = new System.Drawing.Size(176, 35);
            this.btn_registrar_Pagamento.TabIndex = 141;
            this.btn_registrar_Pagamento.Text = "Registrar Pagameto";
            this.btn_registrar_Pagamento.UseVisualStyleBackColor = false;
            this.btn_registrar_Pagamento.Visible = false;
            // 
            // btn_registrar_observacao
            // 
            this.btn_registrar_observacao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_registrar_observacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_registrar_observacao.FlatAppearance.BorderSize = 2;
            this.btn_registrar_observacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_observacao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_observacao.Location = new System.Drawing.Point(19, 440);
            this.btn_registrar_observacao.Name = "btn_registrar_observacao";
            this.btn_registrar_observacao.Size = new System.Drawing.Size(183, 35);
            this.btn_registrar_observacao.TabIndex = 142;
            this.btn_registrar_observacao.Text = "Registrar Observação";
            this.btn_registrar_observacao.UseVisualStyleBackColor = false;
            this.btn_registrar_observacao.Visible = false;
            // 
            // txtb_registrar_pgto_valor_total
            // 
            this.txtb_registrar_pgto_valor_total.Location = new System.Drawing.Point(715, 359);
            this.txtb_registrar_pgto_valor_total.Name = "txtb_registrar_pgto_valor_total";
            this.txtb_registrar_pgto_valor_total.Size = new System.Drawing.Size(109, 20);
            this.txtb_registrar_pgto_valor_total.TabIndex = 143;
            this.txtb_registrar_pgto_valor_total.Visible = false;
            // 
            // txtb_registrar_observacao
            // 
            this.txtb_registrar_observacao.Location = new System.Drawing.Point(22, 490);
            this.txtb_registrar_observacao.Multiline = true;
            this.txtb_registrar_observacao.Name = "txtb_registrar_observacao";
            this.txtb_registrar_observacao.Size = new System.Drawing.Size(791, 77);
            this.txtb_registrar_observacao.TabIndex = 144;
            this.txtb_registrar_observacao.Visible = false;
            // 
            // lbl_data_pgto
            // 
            this.lbl_data_pgto.AutoSize = true;
            this.lbl_data_pgto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_data_pgto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_pgto.Location = new System.Drawing.Point(558, 399);
            this.lbl_data_pgto.Name = "lbl_data_pgto";
            this.lbl_data_pgto.Size = new System.Drawing.Size(153, 20);
            this.lbl_data_pgto.TabIndex = 145;
            this.lbl_data_pgto.Text = "Data do Pagamento";
            this.lbl_data_pgto.Visible = false;
            // 
            // txtb_data_pgto
            // 
            this.txtb_data_pgto.Location = new System.Drawing.Point(717, 399);
            this.txtb_data_pgto.Name = "txtb_data_pgto";
            this.txtb_data_pgto.Size = new System.Drawing.Size(109, 20);
            this.txtb_data_pgto.TabIndex = 146;
            this.txtb_data_pgto.Visible = false;
            // 
            // btn_inserir_comprovante
            // 
            this.btn_inserir_comprovante.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_inserir_comprovante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_inserir_comprovante.FlatAppearance.BorderSize = 2;
            this.btn_inserir_comprovante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir_comprovante.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir_comprovante.Location = new System.Drawing.Point(562, 431);
            this.btn_inserir_comprovante.Name = "btn_inserir_comprovante";
            this.btn_inserir_comprovante.Size = new System.Drawing.Size(176, 52);
            this.btn_inserir_comprovante.TabIndex = 147;
            this.btn_inserir_comprovante.Text = "Incluir Comprovante de Pagamento";
            this.btn_inserir_comprovante.UseVisualStyleBackColor = false;
            this.btn_inserir_comprovante.Visible = false;
            // 
            // cbbox_dia_inicio_plano
            // 
            this.cbbox_dia_inicio_plano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_dia_inicio_plano.FormattingEnabled = true;
            this.cbbox_dia_inicio_plano.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbbox_dia_inicio_plano.Location = new System.Drawing.Point(176, 233);
            this.cbbox_dia_inicio_plano.Name = "cbbox_dia_inicio_plano";
            this.cbbox_dia_inicio_plano.Size = new System.Drawing.Size(121, 21);
            this.cbbox_dia_inicio_plano.TabIndex = 148;
            this.cbbox_dia_inicio_plano.Visible = false;
            // 
            // frm_financas_aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 632);
            this.Controls.Add(this.cbbox_dia_inicio_plano);
            this.Controls.Add(this.btn_inserir_comprovante);
            this.Controls.Add(this.txtb_data_pgto);
            this.Controls.Add(this.lbl_data_pgto);
            this.Controls.Add(this.txtb_registrar_observacao);
            this.Controls.Add(this.txtb_registrar_pgto_valor_total);
            this.Controls.Add(this.btn_registrar_observacao);
            this.Controls.Add(this.btn_registrar_Pagamento);
            this.Controls.Add(this.lbl_pgto_valor_total);
            this.Controls.Add(this.btn_relatorio);
            this.Controls.Add(this.lbl_situacao_resultado);
            this.Controls.Add(this.lbl_Situacao);
            this.Controls.Add(this.pcb_imagem_financas_aluno);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar_inclusao);
            this.Controls.Add(this.cbbox_ano_inicio_plano);
            this.Controls.Add(this.txtb_valor_total);
            this.Controls.Add(this.lbl_valor_total);
            this.Controls.Add(this.txtb_valor_mensal);
            this.Controls.Add(this.lbl_valor_mensal);
            this.Controls.Add(this.txtb_parcelas);
            this.Controls.Add(this.lbl_parcelas);
            this.Controls.Add(this.lbl_nome_plano);
            this.Controls.Add(this.txtb_nome_plano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_ano_plano);
            this.Controls.Add(this.cbbox_mes_inicio_plano);
            this.Controls.Add(this.lbl_dia_plano);
            this.Controls.Add(this.lbl_mes_plano);
            this.Controls.Add(this.lbl_codigo_plano);
            this.Controls.Add(this.cbbox_codigo_plano);
            this.Controls.Add(this.btn_inserir_plano);
            this.Controls.Add(this.lbl_nome_aluno);
            this.Controls.Add(this.txtb_nome_aluno);
            this.Controls.Add(this.lbl_financas_do_aluno);
            this.Controls.Add(this.txtb_codigo_aluno);
            this.Controls.Add(this.lbl_cod_aluno);
            this.Controls.Add(this.dtgridview_financas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_financas_aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financas_Aluno";
            this.Load += new System.EventHandler(this.Financas_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem_financas_aluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_financas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_codigo_aluno;
        private System.Windows.Forms.Label lbl_cod_aluno;
        private System.Windows.Forms.Label lbl_financas_do_aluno;
        private System.Windows.Forms.Label lbl_nome_aluno;
        private System.Windows.Forms.TextBox txtb_nome_aluno;
        private System.Windows.Forms.Button btn_inserir_plano;
        private System.Windows.Forms.ComboBox cbbox_codigo_plano;
        private System.Windows.Forms.Label lbl_codigo_plano;
        private System.Windows.Forms.Label lbl_mes_plano;
        private System.Windows.Forms.Label lbl_dia_plano;
        private System.Windows.Forms.ComboBox cbbox_mes_inicio_plano;
        private System.Windows.Forms.Label lbl_ano_plano;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_nome_plano;
        private System.Windows.Forms.Label lbl_nome_plano;
        private System.Windows.Forms.Label lbl_parcelas;
        private System.Windows.Forms.TextBox txtb_parcelas;
        private System.Windows.Forms.Label lbl_valor_mensal;
        private System.Windows.Forms.TextBox txtb_valor_mensal;
        private System.Windows.Forms.Label lbl_valor_total;
        private System.Windows.Forms.TextBox txtb_valor_total;
        private System.Windows.Forms.ComboBox cbbox_ano_inicio_plano;
        private System.Windows.Forms.Button btn_confirmar_inclusao;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_voltar;
        public System.Windows.Forms.PictureBox pcb_imagem_financas_aluno;
        private System.Windows.Forms.Label lbl_Situacao;
        private System.Windows.Forms.Label lbl_situacao_resultado;
        private System.Windows.Forms.DataGridView dtgridview_financas;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Label lbl_pgto_valor_total;
        private System.Windows.Forms.Button btn_registrar_Pagamento;
        private System.Windows.Forms.Button btn_registrar_observacao;
        private System.Windows.Forms.TextBox txtb_registrar_pgto_valor_total;
        private System.Windows.Forms.TextBox txtb_registrar_observacao;
        private System.Windows.Forms.Label lbl_data_pgto;
        private System.Windows.Forms.TextBox txtb_data_pgto;
        private System.Windows.Forms.Button btn_inserir_comprovante;
        private System.Windows.Forms.ComboBox cbbox_dia_inicio_plano;
    }
}