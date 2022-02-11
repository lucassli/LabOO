namespace AutoEscolaTrevoPOO
{
    partial class frmPrincipalAutenticacao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalAutenticacao));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBoxEntradaSenha = new System.Windows.Forms.TextBox();
            this.btnEntrarSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Black;
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(664, 875);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(94, 29);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 624);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtBoxEntradaSenha
            // 
            this.txtBoxEntradaSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxEntradaSenha.Location = new System.Drawing.Point(304, 368);
            this.txtBoxEntradaSenha.Name = "txtBoxEntradaSenha";
            this.txtBoxEntradaSenha.Size = new System.Drawing.Size(416, 34);
            this.txtBoxEntradaSenha.TabIndex = 3;
            this.txtBoxEntradaSenha.Text = "Insira a Senha de Acesso";
            this.txtBoxEntradaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEntrarSenha
            // 
            this.btnEntrarSenha.BackColor = System.Drawing.Color.Black;
            this.btnEntrarSenha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEntrarSenha.FlatAppearance.BorderSize = 0;
            this.btnEntrarSenha.ForeColor = System.Drawing.Color.White;
            this.btnEntrarSenha.Location = new System.Drawing.Point(465, 424);
            this.btnEntrarSenha.Name = "btnEntrarSenha";
            this.btnEntrarSenha.Size = new System.Drawing.Size(94, 29);
            this.btnEntrarSenha.TabIndex = 4;
            this.btnEntrarSenha.Text = "Entrar";
            this.btnEntrarSenha.UseVisualStyleBackColor = false;
            this.btnEntrarSenha.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmPrincipalAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnEntrarSenha);
            this.Controls.Add(this.txtBoxEntradaSenha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipalAutenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Pagamentos da Autoescola Trevo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEntrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtBoxEntradaSenha;
        private Button btnEntrarSenha;
    }
}