﻿namespace Plantando_Alegria.Forms
{
    partial class frm_pesquisar_planos
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
            this.lbl_pesquisa_planos = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.chkbox_resultado = new System.Windows.Forms.CheckedListBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_nome_plano = new System.Windows.Forms.Label();
            this.txtb_nome_plano = new System.Windows.Forms.TextBox();
            this.txtb_codigo_plano = new System.Windows.Forms.TextBox();
            this.lbl_cod_plano = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_pesquisa_planos
            // 
            this.lbl_pesquisa_planos.AutoSize = true;
            this.lbl_pesquisa_planos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisa_planos.Location = new System.Drawing.Point(74, 12);
            this.lbl_pesquisa_planos.Name = "lbl_pesquisa_planos";
            this.lbl_pesquisa_planos.Size = new System.Drawing.Size(385, 26);
            this.lbl_pesquisa_planos.TabIndex = 58;
            this.lbl_pesquisa_planos.Text = "Plantando Alegria - Pesquisa de Planos";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_limpar.FlatAppearance.BorderSize = 2;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(377, 397);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(130, 35);
            this.btn_limpar.TabIndex = 57;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // chkbox_resultado
            // 
            this.chkbox_resultado.FormattingEnabled = true;
            this.chkbox_resultado.HorizontalScrollbar = true;
            this.chkbox_resultado.Location = new System.Drawing.Point(12, 121);
            this.chkbox_resultado.Name = "chkbox_resultado";
            this.chkbox_resultado.Size = new System.Drawing.Size(495, 244);
            this.chkbox_resultado.TabIndex = 56;
            this.chkbox_resultado.SelectedIndexChanged += new System.EventHandler(this.chkbox_resultado_SelectedIndexChanged);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(12, 397);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(130, 35);
            this.btn_voltar.TabIndex = 55;
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
            this.btn_pesquisar.Location = new System.Drawing.Point(164, 397);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(190, 35);
            this.btn_pesquisar.TabIndex = 54;
            this.btn_pesquisar.Text = "Pesquisar Plano";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_nome_plano
            // 
            this.lbl_nome_plano.AutoSize = true;
            this.lbl_nome_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_nome_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_plano.Location = new System.Drawing.Point(19, 81);
            this.lbl_nome_plano.Name = "lbl_nome_plano";
            this.lbl_nome_plano.Size = new System.Drawing.Size(122, 20);
            this.lbl_nome_plano.TabIndex = 53;
            this.lbl_nome_plano.Text = "Nome do Plano";
            // 
            // txtb_nome_plano
            // 
            this.txtb_nome_plano.Location = new System.Drawing.Point(175, 81);
            this.txtb_nome_plano.Name = "txtb_nome_plano";
            this.txtb_nome_plano.Size = new System.Drawing.Size(330, 20);
            this.txtb_nome_plano.TabIndex = 52;
            // 
            // txtb_codigo_plano
            // 
            this.txtb_codigo_plano.Location = new System.Drawing.Point(175, 54);
            this.txtb_codigo_plano.Name = "txtb_codigo_plano";
            this.txtb_codigo_plano.Size = new System.Drawing.Size(330, 20);
            this.txtb_codigo_plano.TabIndex = 51;
            // 
            // lbl_cod_plano
            // 
            this.lbl_cod_plano.AutoSize = true;
            this.lbl_cod_plano.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_cod_plano.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_plano.Location = new System.Drawing.Point(19, 54);
            this.lbl_cod_plano.Name = "lbl_cod_plano";
            this.lbl_cod_plano.Size = new System.Drawing.Size(131, 20);
            this.lbl_cod_plano.TabIndex = 50;
            this.lbl_cod_plano.Text = "Codigo do Plano";
            // 
            // frm_pesquisar_planos
            // 
            this.AcceptButton = this.btn_pesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_pesquisa_planos);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.chkbox_resultado);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.lbl_nome_plano);
            this.Controls.Add(this.txtb_nome_plano);
            this.Controls.Add(this.txtb_codigo_plano);
            this.Controls.Add(this.lbl_cod_plano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_pesquisar_planos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantando Alegria - Pesquisar Planos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pesquisa_planos;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.CheckedListBox chkbox_resultado;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_nome_plano;
        private System.Windows.Forms.TextBox txtb_nome_plano;
        private System.Windows.Forms.TextBox txtb_codigo_plano;
        private System.Windows.Forms.Label lbl_cod_plano;
    }
}