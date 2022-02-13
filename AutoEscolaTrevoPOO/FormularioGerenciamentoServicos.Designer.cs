namespace AutoEscolaTrevoPOO
{
    partial class FormularioGerenciamentoServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioGerenciamentoServicos));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarServico = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarServico = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditarServico = new System.Windows.Forms.Button();
            this.btnExcluirServico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciar Serviços";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarServico
            // 
            this.btnCadastrarServico.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarServico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarServico.FlatAppearance.BorderSize = 0;
            this.btnCadastrarServico.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarServico.Location = new System.Drawing.Point(32, 160);
            this.btnCadastrarServico.Name = "btnCadastrarServico";
            this.btnCadastrarServico.Size = new System.Drawing.Size(200, 48);
            this.btnCadastrarServico.TabIndex = 5;
            this.btnCadastrarServico.Text = "+  Cadastrar Serviço";
            this.btnCadastrarServico.UseVisualStyleBackColor = false;
            this.btnCadastrarServico.Click += new System.EventHandler(this.btnCadastrarServico_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(32, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 36);
            this.textBox1.TabIndex = 6;
            // 
            // btnBuscarServico
            // 
            this.btnBuscarServico.BackColor = System.Drawing.Color.Black;
            this.btnBuscarServico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarServico.FlatAppearance.BorderSize = 0;
            this.btnBuscarServico.ForeColor = System.Drawing.Color.White;
            this.btnBuscarServico.Location = new System.Drawing.Point(552, 272);
            this.btnBuscarServico.Name = "btnBuscarServico";
            this.btnBuscarServico.Size = new System.Drawing.Size(200, 48);
            this.btnBuscarServico.TabIndex = 7;
            this.btnBuscarServico.Text = "Buscar Serviço";
            this.btnBuscarServico.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(728, 384);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnEditarServico
            // 
            this.btnEditarServico.BackColor = System.Drawing.Color.Black;
            this.btnEditarServico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarServico.FlatAppearance.BorderSize = 0;
            this.btnEditarServico.ForeColor = System.Drawing.Color.White;
            this.btnEditarServico.Location = new System.Drawing.Point(792, 616);
            this.btnEditarServico.Name = "btnEditarServico";
            this.btnEditarServico.Size = new System.Drawing.Size(200, 48);
            this.btnEditarServico.TabIndex = 9;
            this.btnEditarServico.Text = "Editar Serviço";
            this.btnEditarServico.UseVisualStyleBackColor = false;
            this.btnEditarServico.Click += new System.EventHandler(this.btnEditarServico_Click);
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.BackColor = System.Drawing.Color.Black;
            this.btnExcluirServico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluirServico.FlatAppearance.BorderSize = 0;
            this.btnExcluirServico.ForeColor = System.Drawing.Color.White;
            this.btnExcluirServico.Location = new System.Drawing.Point(792, 688);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(200, 48);
            this.btnExcluirServico.TabIndex = 10;
            this.btnExcluirServico.Text = "Excluir Serviço";
            this.btnExcluirServico.UseVisualStyleBackColor = false;
            // 
            // FormularioGerenciamentoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnExcluirServico);
            this.Controls.Add(this.btnEditarServico);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarServico);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCadastrarServico);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioGerenciamentoServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioGerenciamentoServicos";
            this.Load += new System.EventHandler(this.FormularioGerenciamentoServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCadastrarServico;
        private TextBox textBox1;
        private Button btnBuscarServico;
        private DataGridView dataGridView1;
        private Button btnEditarServico;
        private Button btnExcluirServico;
    }
}