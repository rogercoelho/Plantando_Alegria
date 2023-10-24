namespace Plantando_Alegria.Forms
{
    partial class frm_ficha_planos
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
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txtb_valor_total_plano = new System.Windows.Forms.TextBox();
            this.txtb_valor_mensal_plano = new System.Windows.Forms.TextBox();
            this.txtb_qtd_aulas_total = new System.Windows.Forms.TextBox();
            this.txtb_qtd_aulas_semana = new System.Windows.Forms.TextBox();
            this.txtb_nome_plano = new System.Windows.Forms.TextBox();
            this.txtb_codigo_plano = new System.Windows.Forms.TextBox();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.btn_adicionar_plano = new System.Windows.Forms.Button();
            this.lbl_valor_mensal = new System.Windows.Forms.Label();
            this.lbl_qtd_aulas_total = new System.Windows.Forms.Label();
            this.lbl_qtd_aulas_semana = new System.Windows.Forms.Label();
            this.lbl_nome_plano = new System.Windows.Forms.Label();
            this.lbl_ficha_planos = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_cod_plano = new System.Windows.Forms.Label();
            this.lbl_situacao_plano = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txtb_situacao_plano = new System.Windows.Forms.TextBox();
            this.cbbox_situacao_plano = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_limpar.FlatAppearance.BorderSize = 2;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(266, 345);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(79, 35);
            this.btn_limpar.TabIndex = 85;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txtb_valor_total_plano
            // 
            this.txtb_valor_total_plano.Enabled = false;
            this.txtb_valor_total_plano.Location = new System.Drawing.Point(305, 233);
            this.txtb_valor_total_plano.Name = "txtb_valor_total_plano";
            this.txtb_valor_total_plano.Size = new System.Drawing.Size(315, 20);
            this.txtb_valor_total_plano.TabIndex = 84;
            // 
            // txtb_valor_mensal_plano
            // 
            this.txtb_valor_mensal_plano.Enabled = false;
            this.txtb_valor_mensal_plano.Location = new System.Drawing.Point(305, 200);
            this.txtb_valor_mensal_plano.Name = "txtb_valor_mensal_plano";
            this.txtb_valor_mensal_plano.Size = new System.Drawing.Size(315, 20);
            this.txtb_valor_mensal_plano.TabIndex = 83;
            // 
            // txtb_qtd_aulas_total
            // 
            this.txtb_qtd_aulas_total.Enabled = false;
            this.txtb_qtd_aulas_total.Location = new System.Drawing.Point(305, 169);
            this.txtb_qtd_aulas_total.Name = "txtb_qtd_aulas_total";
            this.txtb_qtd_aulas_total.Size = new System.Drawing.Size(315, 20);
            this.txtb_qtd_aulas_total.TabIndex = 82;
            // 
            // txtb_qtd_aulas_semana
            // 
            this.txtb_qtd_aulas_semana.Enabled = false;
            this.txtb_qtd_aulas_semana.Location = new System.Drawing.Point(305, 139);
            this.txtb_qtd_aulas_semana.Name = "txtb_qtd_aulas_semana";
            this.txtb_qtd_aulas_semana.Size = new System.Drawing.Size(315, 20);
            this.txtb_qtd_aulas_semana.TabIndex = 81;
            // 
            // txtb_nome_plano
            // 
            this.txtb_nome_plano.Enabled = false;
            this.txtb_nome_plano.Location = new System.Drawing.Point(305, 110);
            this.txtb_nome_plano.Name = "txtb_nome_plano";
            this.txtb_nome_plano.Size = new System.Drawing.Size(315, 20);
            this.txtb_nome_plano.TabIndex = 80;
            // 
            // txtb_codigo_plano
            // 
            this.txtb_codigo_plano.Enabled = false;
            this.txtb_codigo_plano.Location = new System.Drawing.Point(305, 81);
            this.txtb_codigo_plano.Name = "txtb_codigo_plano";
            this.txtb_codigo_plano.Size = new System.Drawing.Size(315, 20);
            this.txtb_codigo_plano.TabIndex = 79;
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_valor_total.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_total.Location = new System.Drawing.Point(11, 233);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(156, 20);
            this.lbl_valor_total.TabIndex = 78;
            this.lbl_valor_total.Text = "Valor Total do Plano";
            // 
            // btn_adicionar_plano
            // 
            this.btn_adicionar_plano.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_adicionar_plano.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_adicionar_plano.FlatAppearance.BorderSize = 2;
            this.btn_adicionar_plano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar_plano.Location = new System.Drawing.Point(392, 341);
            this.btn_adicionar_plano.Name = "btn_adicionar_plano";
            this.btn_adicionar_plano.Size = new System.Drawing.Size(147, 35);
            this.btn_adicionar_plano.TabIndex = 77;
            this.btn_adicionar_plano.Text = "Adicionar Plano";
            this.btn_adicionar_plano.UseVisualStyleBackColor = false;
            // 
            // lbl_valor_mensal
            // 
            this.lbl_valor_mensal.AutoSize = true;
            this.lbl_valor_mensal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_valor_mensal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_mensal.Location = new System.Drawing.Point(11, 200);
            this.lbl_valor_mensal.Name = "lbl_valor_mensal";
            this.lbl_valor_mensal.Size = new System.Drawing.Size(171, 20);
            this.lbl_valor_mensal.TabIndex = 76;
            this.lbl_valor_mensal.Text = "Valor Mensal do Plano";
            // 
            // lbl_qtd_aulas_total
            // 
            this.lbl_qtd_aulas_total.AutoSize = true;
            this.lbl_qtd_aulas_total.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_qtd_aulas_total.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd_aulas_total.Location = new System.Drawing.Point(11, 169);
            this.lbl_qtd_aulas_total.Name = "lbl_qtd_aulas_total";
            this.lbl_qtd_aulas_total.Size = new System.Drawing.Size(269, 20);
            this.lbl_qtd_aulas_total.TabIndex = 75;
            this.lbl_qtd_aulas_total.Text = "Quantidade Total de Aulas do Plano";
            // 
            // lbl_qtd_aulas_semana
            // 
            this.lbl_qtd_aulas_semana.AutoSize = true;
            this.lbl_qtd_aulas_semana.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_qtd_aulas_semana.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd_aulas_semana.Location = new System.Drawing.Point(11, 139);
            this.lbl_qtd_aulas_semana.Name = "lbl_qtd_aulas_semana";
            this.lbl_qtd_aulas_semana.Size = new System.Drawing.Size(240, 20);
            this.lbl_qtd_aulas_semana.TabIndex = 74;
            this.lbl_qtd_aulas_semana.Text = "Quantidade de Aulas na semana";
            // 
            // lbl_nome_plano
            // 
            this.lbl_nome_plano.AutoSize = true;
            this.lbl_nome_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_nome_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_plano.Location = new System.Drawing.Point(11, 110);
            this.lbl_nome_plano.Name = "lbl_nome_plano";
            this.lbl_nome_plano.Size = new System.Drawing.Size(122, 20);
            this.lbl_nome_plano.TabIndex = 73;
            this.lbl_nome_plano.Text = "Nome do Plano";
            // 
            // lbl_ficha_planos
            // 
            this.lbl_ficha_planos.AutoSize = true;
            this.lbl_ficha_planos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ficha_planos.Location = new System.Drawing.Point(105, 8);
            this.lbl_ficha_planos.Name = "lbl_ficha_planos";
            this.lbl_ficha_planos.Size = new System.Drawing.Size(352, 26);
            this.lbl_ficha_planos.TabIndex = 72;
            this.lbl_ficha_planos.Text = "Plantando Alegria - Ficha de Planos";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(15, 345);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(70, 35);
            this.btn_voltar.TabIndex = 71;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lbl_cod_plano
            // 
            this.lbl_cod_plano.AutoSize = true;
            this.lbl_cod_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_cod_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_plano.Location = new System.Drawing.Point(12, 81);
            this.lbl_cod_plano.Name = "lbl_cod_plano";
            this.lbl_cod_plano.Size = new System.Drawing.Size(131, 20);
            this.lbl_cod_plano.TabIndex = 70;
            this.lbl_cod_plano.Text = "Codigo do Plano";
            // 
            // lbl_situacao_plano
            // 
            this.lbl_situacao_plano.AutoSize = true;
            this.lbl_situacao_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_situacao_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situacao_plano.Location = new System.Drawing.Point(11, 264);
            this.lbl_situacao_plano.Name = "lbl_situacao_plano";
            this.lbl_situacao_plano.Size = new System.Drawing.Size(139, 20);
            this.lbl_situacao_plano.TabIndex = 86;
            this.lbl_situacao_plano.Text = "Situacao do Plano";
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.BorderSize = 2;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(103, 345);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(79, 35);
            this.btn_editar.TabIndex = 87;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txtb_situacao_plano
            // 
            this.txtb_situacao_plano.Enabled = false;
            this.txtb_situacao_plano.Location = new System.Drawing.Point(305, 266);
            this.txtb_situacao_plano.Name = "txtb_situacao_plano";
            this.txtb_situacao_plano.Size = new System.Drawing.Size(315, 20);
            this.txtb_situacao_plano.TabIndex = 88;
            // 
            // cbbox_situacao_plano
            // 
            this.cbbox_situacao_plano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbox_situacao_plano.FormattingEnabled = true;
            this.cbbox_situacao_plano.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbbox_situacao_plano.Location = new System.Drawing.Point(305, 266);
            this.cbbox_situacao_plano.Name = "cbbox_situacao_plano";
            this.cbbox_situacao_plano.Size = new System.Drawing.Size(121, 21);
            this.cbbox_situacao_plano.TabIndex = 90;
            this.cbbox_situacao_plano.Visible = false;
            // 
            // frm_ficha_planos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 410);
            this.ControlBox = false;
            this.Controls.Add(this.cbbox_situacao_plano);
            this.Controls.Add(this.txtb_situacao_plano);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_situacao_plano);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txtb_valor_total_plano);
            this.Controls.Add(this.txtb_valor_mensal_plano);
            this.Controls.Add(this.txtb_qtd_aulas_total);
            this.Controls.Add(this.txtb_qtd_aulas_semana);
            this.Controls.Add(this.txtb_nome_plano);
            this.Controls.Add(this.txtb_codigo_plano);
            this.Controls.Add(this.lbl_valor_total);
            this.Controls.Add(this.btn_adicionar_plano);
            this.Controls.Add(this.lbl_valor_mensal);
            this.Controls.Add(this.lbl_qtd_aulas_total);
            this.Controls.Add(this.lbl_qtd_aulas_semana);
            this.Controls.Add(this.lbl_nome_plano);
            this.Controls.Add(this.lbl_ficha_planos);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_cod_plano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_ficha_planos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantando Alegria - Ficha de Planos";
            this.Load += new System.EventHandler(this.frm_ficha_planos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_limpar;
        public System.Windows.Forms.TextBox txtb_valor_total_plano;
        public System.Windows.Forms.TextBox txtb_valor_mensal_plano;
        public System.Windows.Forms.TextBox txtb_qtd_aulas_total;
        public System.Windows.Forms.TextBox txtb_qtd_aulas_semana;
        public System.Windows.Forms.TextBox txtb_nome_plano;
        public System.Windows.Forms.TextBox txtb_codigo_plano;
        private System.Windows.Forms.Label lbl_valor_total;
        private System.Windows.Forms.Button btn_adicionar_plano;
        private System.Windows.Forms.Label lbl_valor_mensal;
        private System.Windows.Forms.Label lbl_qtd_aulas_total;
        private System.Windows.Forms.Label lbl_qtd_aulas_semana;
        private System.Windows.Forms.Label lbl_nome_plano;
        private System.Windows.Forms.Label lbl_ficha_planos;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_cod_plano;
        private System.Windows.Forms.Label lbl_situacao_plano;
        private System.Windows.Forms.Button btn_editar;
        public System.Windows.Forms.TextBox txtb_situacao_plano;
        private System.Windows.Forms.ComboBox cbbox_situacao_plano;
    }
}