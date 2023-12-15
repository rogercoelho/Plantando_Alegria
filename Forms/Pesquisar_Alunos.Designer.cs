namespace Plantando_Alegria.Forms
{
    partial class frm_pesquisar_alunos
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
            this.lbl_pesquisa_alunos = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.chkbox_resultado = new System.Windows.Forms.CheckedListBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_nome_aluno = new System.Windows.Forms.Label();
            this.txtb_nome_aluno = new System.Windows.Forms.TextBox();
            this.txtb_codigo = new System.Windows.Forms.TextBox();
            this.lbl_cod_aluno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_cpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_pesquisa_alunos
            // 
            this.lbl_pesquisa_alunos.AutoSize = true;
            this.lbl_pesquisa_alunos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisa_alunos.Location = new System.Drawing.Point(74, 19);
            this.lbl_pesquisa_alunos.Name = "lbl_pesquisa_alunos";
            this.lbl_pesquisa_alunos.Size = new System.Drawing.Size(388, 26);
            this.lbl_pesquisa_alunos.TabIndex = 6;
            this.lbl_pesquisa_alunos.Text = "Plantando Alegria - Pesquisa de Alunos";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_limpar.FlatAppearance.BorderSize = 2;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(376, 442);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(130, 35);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // chkbox_resultado
            // 
            this.chkbox_resultado.FormattingEnabled = true;
            this.chkbox_resultado.HorizontalScrollbar = true;
            this.chkbox_resultado.Location = new System.Drawing.Point(11, 164);
            this.chkbox_resultado.Name = "chkbox_resultado";
            this.chkbox_resultado.Size = new System.Drawing.Size(495, 244);
            this.chkbox_resultado.TabIndex = 10;
            this.chkbox_resultado.SelectedIndexChanged += new System.EventHandler(this.chkbox_resultado_SelectedIndexChanged);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(11, 442);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(130, 35);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Volltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pesquisar.FlatAppearance.BorderSize = 2;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(163, 442);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(190, 35);
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.Text = "Pesquisar Aluno";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_nome_aluno
            // 
            this.lbl_nome_aluno.AutoSize = true;
            this.lbl_nome_aluno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_nome_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_aluno.Location = new System.Drawing.Point(19, 88);
            this.lbl_nome_aluno.Name = "lbl_nome_aluno";
            this.lbl_nome_aluno.Size = new System.Drawing.Size(125, 20);
            this.lbl_nome_aluno.TabIndex = 8;
            this.lbl_nome_aluno.Text = "Nome do Aluno";
            // 
            // txtb_nome_aluno
            // 
            this.txtb_nome_aluno.Location = new System.Drawing.Point(175, 88);
            this.txtb_nome_aluno.Name = "txtb_nome_aluno";
            this.txtb_nome_aluno.Size = new System.Drawing.Size(330, 20);
            this.txtb_nome_aluno.TabIndex = 1;
            // 
            // txtb_codigo
            // 
            this.txtb_codigo.Location = new System.Drawing.Point(175, 61);
            this.txtb_codigo.Name = "txtb_codigo";
            this.txtb_codigo.Size = new System.Drawing.Size(330, 20);
            this.txtb_codigo.TabIndex = 0;
            // 
            // lbl_cod_aluno
            // 
            this.lbl_cod_aluno.AutoSize = true;
            this.lbl_cod_aluno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_cod_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_aluno.Location = new System.Drawing.Point(19, 61);
            this.lbl_cod_aluno.Name = "lbl_cod_aluno";
            this.lbl_cod_aluno.Size = new System.Drawing.Size(134, 20);
            this.lbl_cod_aluno.TabIndex = 7;
            this.lbl_cod_aluno.Text = "Codigo do Aluno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPF do Aluno";
            // 
            // txtb_cpf
            // 
            this.txtb_cpf.Location = new System.Drawing.Point(175, 120);
            this.txtb_cpf.Name = "txtb_cpf";
            this.txtb_cpf.Size = new System.Drawing.Size(330, 20);
            this.txtb_cpf.TabIndex = 2;
            // 
            // frm_pesquisar_alunos
            // 
            this.AcceptButton = this.btn_pesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 489);
            this.ControlBox = false;
            this.Controls.Add(this.txtb_cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_pesquisa_alunos);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.chkbox_resultado);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.lbl_nome_aluno);
            this.Controls.Add(this.txtb_nome_aluno);
            this.Controls.Add(this.txtb_codigo);
            this.Controls.Add(this.lbl_cod_aluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_pesquisar_alunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantando Alegria - Pesquisar Alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pesquisa_alunos;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.CheckedListBox chkbox_resultado;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_nome_aluno;
        private System.Windows.Forms.TextBox txtb_nome_aluno;
        private System.Windows.Forms.TextBox txtb_codigo;
        private System.Windows.Forms.Label lbl_cod_aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_cpf;
    }
}