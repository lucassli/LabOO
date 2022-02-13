using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEscolaTrevoPOO
{
    public partial class FormularioGerenciamentoServicos : Form
    {
        public FormularioGerenciamentoServicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioCadastrarServicos();
        }

        private void btnEditarServico_Click(object sender, EventArgs e)
        {

        }

        private void FormularioGerenciamentoServicos_Load(object sender, EventArgs e)
        {

        }

        private FormularioCadastrarServicos ExibirNovoFormularioCadastrarServicos()
        {
            FormularioCadastrarServicos frmCadServicos = new FormularioCadastrarServicos();
            frmCadServicos.ShowDialog();
            return frmCadServicos;
        }
    }
}
