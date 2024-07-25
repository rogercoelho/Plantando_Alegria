namespace Plantando_Alegria.Forms
{
    partial class frm_controle_de_planos
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
            this.lbl_titulo_2 = new System.Windows.Forms.Label();
            this.lbl_titulo_1 = new System.Windows.Forms.Label();
            this.btn_consulta_planos = new System.Windows.Forms.Button();
            this.btn_cadastro__planos = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo_2
            // 
            this.lbl_titulo_2.AutoSize = true;
            this.lbl_titulo_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_2.Location = new System.Drawing.Point(233, 49);
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
            this.lbl_titulo_1.Location = new System.Drawing.Point(276, 18);
            this.lbl_titulo_1.Name = "lbl_titulo_1";
            this.lbl_titulo_1.Size = new System.Drawing.Size(232, 31);
            this.lbl_titulo_1.TabIndex = 17;
            this.lbl_titulo_1.Text = "Plantando Alegria";
            // 
            // btn_consulta_planos
            // 
            this.btn_consulta_planos.BackColor = System.Drawing.Color.White;
            this.btn_consulta_planos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_consulta_planos.FlatAppearance.BorderSize = 2;
            this.btn_consulta_planos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta_planos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta_planos.Location = new System.Drawing.Point(293, 105);
            this.btn_consulta_planos.Name = "btn_consulta_planos";
            this.btn_consulta_planos.Size = new System.Drawing.Size(190, 35);
            this.btn_consulta_planos.TabIndex = 23;
            this.btn_consulta_planos.Text = "Consulta de Planos";
            this.btn_consulta_planos.UseVisualStyleBackColor = false;
            this.btn_consulta_planos.Click += new System.EventHandler(this.btn_consulta_planos_Click);
            // 
            // btn_cadastro__planos
            // 
            this.btn_cadastro__planos.BackColor = System.Drawing.Color.White;
            this.btn_cadastro__planos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cadastro__planos.FlatAppearance.BorderSize = 2;
            this.btn_cadastro__planos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastro__planos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro__planos.Location = new System.Drawing.Point(293, 156);
            this.btn_cadastro__planos.Name = "btn_cadastro__planos";
            this.btn_cadastro__planos.Size = new System.Drawing.Size(190, 35);
            this.btn_cadastro__planos.TabIndex = 24;
            this.btn_cadastro__planos.Text = "Cadastro de Planos";
            this.btn_cadastro__planos.UseVisualStyleBackColor = false;
            this.btn_cadastro__planos.Click += new System.EventHandler(this.btn_cadastro__planos_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(681, 403);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(107, 35);
            this.btn_voltar.TabIndex = 26;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_controle_de_planos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::Plantando_Alegria.Properties.Resources.logomarca_branca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadastro__planos);
            this.Controls.Add(this.btn_consulta_planos);
            this.Controls.Add(this.lbl_titulo_2);
            this.Controls.Add(this.lbl_titulo_1);
            this.Name = "frm_controle_de_planos";
            this.Text = "Controle de Planos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_2;
        private System.Windows.Forms.Label lbl_titulo_1;
        private System.Windows.Forms.Button btn_consulta_planos;
        private System.Windows.Forms.Button btn_cadastro__planos;
        private System.Windows.Forms.Button btn_voltar;
    }
}