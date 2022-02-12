namespace AutoEscolaTrevoPOO
{
    public partial class frmPrincipalAutenticacao : Form
    {
        public frmPrincipalAutenticacao()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemoverBordaBotao();
            /*PictureBox logoTrevo = new PictureBox();
            logoTrevo.Image = Image.FromFile("C:/Users/gabri/source/repos/AutoEscolaTrevoPOO/AutoEscolaTrevoPOO/imgFront/AutoEscolaTransparente.png");
            logoTrevo.Location = new Point(100, 100);
            logoTrevo.Size = new Size(1024, 668);

            this.Controls.Add(logoTrevo);*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCadastrarServicos frmCadastrarServicos = new frmCadastrarServicos();
            frmCadastrarServicos.ShowDialog();

        }
        
        private void RemoverBordaBotao()
        {
            btnEntrarSenha.FlatStyle = FlatStyle.Flat;
            btnEntrarSenha.FlatAppearance.BorderSize = 0;
        }
    }
}