namespace Plantando_Alegria.Forms
{
    partial class frm_consultar_alunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_nome_aluno = new System.Windows.Forms.Label();
            this.txtb_nome_aluno = new System.Windows.Forms.TextBox();
            this.txtb_codigo = new System.Windows.Forms.TextBox();
            this.lbl_cod_aluno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_cpf = new System.Windows.Forms.TextBox();
            this.lbl_titulo_2 = new System.Windows.Forms.Label();
            this.lbl_titulo_1 = new System.Windows.Forms.Label();
            this.dtgrid_resultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.White;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_limpar.FlatAppearance.BorderSize = 2;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(509, 479);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(130, 35);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(144, 479);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(130, 35);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Volltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pesquisar.FlatAppearance.BorderSize = 2;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(296, 479);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.lbl_nome_aluno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_aluno.Location = new System.Drawing.Point(131, 130);
            this.lbl_nome_aluno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome_aluno.Name = "lbl_nome_aluno";
            this.lbl_nome_aluno.Size = new System.Drawing.Size(140, 22);
            this.lbl_nome_aluno.TabIndex = 8;
            this.lbl_nome_aluno.Text = "Nome do Aluno";
            // 
            // txtb_nome_aluno
            // 
            this.txtb_nome_aluno.Location = new System.Drawing.Point(296, 130);
            this.txtb_nome_aluno.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtb_nome_aluno.Name = "txtb_nome_aluno";
            this.txtb_nome_aluno.Size = new System.Drawing.Size(330, 20);
            this.txtb_nome_aluno.TabIndex = 1;
            // 
            // txtb_codigo
            // 
            this.txtb_codigo.Location = new System.Drawing.Point(296, 99);
            this.txtb_codigo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtb_codigo.Name = "txtb_codigo";
            this.txtb_codigo.Size = new System.Drawing.Size(330, 20);
            this.txtb_codigo.TabIndex = 0;
            // 
            // lbl_cod_aluno
            // 
            this.lbl_cod_aluno.AutoSize = true;
            this.lbl_cod_aluno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cod_aluno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_aluno.Location = new System.Drawing.Point(131, 99);
            this.lbl_cod_aluno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cod_aluno.Name = "lbl_cod_aluno";
            this.lbl_cod_aluno.Size = new System.Drawing.Size(150, 22);
            this.lbl_cod_aluno.TabIndex = 7;
            this.lbl_cod_aluno.Text = "Codigo do Aluno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPF do Aluno";
            // 
            // txtb_cpf
            // 
            this.txtb_cpf.Location = new System.Drawing.Point(296, 160);
            this.txtb_cpf.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtb_cpf.Name = "txtb_cpf";
            this.txtb_cpf.Size = new System.Drawing.Size(330, 20);
            this.txtb_cpf.TabIndex = 2;
            // 
            // lbl_titulo_2
            // 
            this.lbl_titulo_2.AutoSize = true;
            this.lbl_titulo_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_2.Location = new System.Drawing.Point(211, 40);
            this.lbl_titulo_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo_2.Name = "lbl_titulo_2";
            this.lbl_titulo_2.Size = new System.Drawing.Size(317, 25);
            this.lbl_titulo_2.TabIndex = 18;
            this.lbl_titulo_2.Text = "Escola de Circo e Produções";
            // 
            // lbl_titulo_1
            // 
            this.lbl_titulo_1.AutoSize = true;
            this.lbl_titulo_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo_1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_1.Location = new System.Drawing.Point(254, 9);
            this.lbl_titulo_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo_1.Name = "lbl_titulo_1";
            this.lbl_titulo_1.Size = new System.Drawing.Size(232, 31);
            this.lbl_titulo_1.TabIndex = 17;
            this.lbl_titulo_1.Text = "Plantando Alegria";
            // 
            // dtgrid_resultado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgrid_resultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgrid_resultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgrid_resultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_resultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrid_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_resultado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrid_resultado.GridColor = System.Drawing.Color.Black;
            this.dtgrid_resultado.Location = new System.Drawing.Point(79, 196);
            this.dtgrid_resultado.MultiSelect = false;
            this.dtgrid_resultado.Name = "dtgrid_resultado";
            this.dtgrid_resultado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_resultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrid_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_resultado.Size = new System.Drawing.Size(632, 259);
            this.dtgrid_resultado.TabIndex = 19;
            this.dtgrid_resultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_resultado_CellContentClick);
            // 
            // frm_consultar_alunos
            // 
            this.AcceptButton = this.btn_pesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::Plantando_Alegria.Properties.Resources.logomarca_branca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(737, 570);
            this.ControlBox = false;
            this.Controls.Add(this.dtgrid_resultado);
            this.Controls.Add(this.lbl_titulo_2);
            this.Controls.Add(this.lbl_titulo_1);
            this.Controls.Add(this.txtb_cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.lbl_nome_aluno);
            this.Controls.Add(this.txtb_nome_aluno);
            this.Controls.Add(this.txtb_codigo);
            this.Controls.Add(this.lbl_cod_aluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frm_consultar_alunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantando Alegria - Consultar Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_nome_aluno;
        private System.Windows.Forms.TextBox txtb_nome_aluno;
        private System.Windows.Forms.TextBox txtb_codigo;
        private System.Windows.Forms.Label lbl_cod_aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_cpf;
        private System.Windows.Forms.Label lbl_titulo_2;
        private System.Windows.Forms.Label lbl_titulo_1;
        private System.Windows.Forms.DataGridView dtgrid_resultado;
    }
}