namespace Plantando_Alegria.Forms
{
    partial class frm_historico
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
            this.dtgrid_historico = new System.Windows.Forms.DataGridView();
            this.lbl_historico_alteracoes = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_historico)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_historico
            // 
            this.dtgrid_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_historico.Location = new System.Drawing.Point(12, 83);
            this.dtgrid_historico.Name = "dtgrid_historico";
            this.dtgrid_historico.Size = new System.Drawing.Size(1077, 382);
            this.dtgrid_historico.TabIndex = 0;
            // 
            // lbl_historico_alteracoes
            // 
            this.lbl_historico_alteracoes.AutoSize = true;
            this.lbl_historico_alteracoes.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_historico_alteracoes.Location = new System.Drawing.Point(336, 9);
            this.lbl_historico_alteracoes.Name = "lbl_historico_alteracoes";
            this.lbl_historico_alteracoes.Size = new System.Drawing.Size(427, 26);
            this.lbl_historico_alteracoes.TabIndex = 1;
            this.lbl_historico_alteracoes.Text = "Plantando Alegria - Historico de Alterações";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(504, 521);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(70, 35);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_historico
            // 
            this.AcceptButton = this.btn_voltar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 568);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_historico_alteracoes);
            this.Controls.Add(this.dtgrid_historico);
            this.Name = "frm_historico";
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Historico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_historico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgrid_historico;
        private System.Windows.Forms.Label lbl_historico_alteracoes;
        private System.Windows.Forms.Button btn_voltar;
    }
}