namespace AutoEscolaTrevoPOO
{
    partial class FormularioGerenciamentoGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioGerenciamentoGeral));
            this.pcbServico = new System.Windows.Forms.PictureBox();
            this.btnGerenciarServico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbServico)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbServico
            // 
            this.pcbServico.Image = ((System.Drawing.Image)(resources.GetObject("pcbServico.Image")));
            this.pcbServico.Location = new System.Drawing.Point(440, 24);
            this.pcbServico.Name = "pcbServico";
            this.pcbServico.Size = new System.Drawing.Size(144, 120);
            this.pcbServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbServico.TabIndex = 0;
            this.pcbServico.TabStop = false;
            // 
            // btnGerenciarServico
            // 
            this.btnGerenciarServico.BackColor = System.Drawing.Color.Black;
            this.btnGerenciarServico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGerenciarServico.FlatAppearance.BorderSize = 0;
            this.btnGerenciarServico.ForeColor = System.Drawing.Color.White;
            this.btnGerenciarServico.Location = new System.Drawing.Point(412, 176);
            this.btnGerenciarServico.Name = "btnGerenciarServico";
            this.btnGerenciarServico.Size = new System.Drawing.Size(200, 48);
            this.btnGerenciarServico.TabIndex = 5;
            this.btnGerenciarServico.Text = "Gerenciar Serviços";
            this.btnGerenciarServico.UseVisualStyleBackColor = false;
            this.btnGerenciarServico.Click += new System.EventHandler(this.btnGerenciarServico_Click);
            // 
            // FormularioGerenciamentoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnGerenciarServico);
            this.Controls.Add(this.pcbServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioGerenciamentoGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioGerenciamentoGeral";
            this.Load += new System.EventHandler(this.FormularioGerenciamentoGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pcbServico;
        private Button btnGerenciarServico;
    }
}