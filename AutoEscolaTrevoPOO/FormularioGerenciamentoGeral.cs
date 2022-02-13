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
    public partial class FormularioGerenciamentoGeral : Form
    {
        public FormularioGerenciamentoGeral()
        {
            InitializeComponent();
        }

        private void btnGerenciarServico_Click(object sender, EventArgs e)
        {
            ExibirNovoFormularioGerenciarServicos();
        }

        private void FormularioGerenciamentoGeral_Load(object sender, EventArgs e)
        {

        }

        private FormularioGerenciamentoServicos ExibirNovoFormularioGerenciarServicos()
        {
            FormularioGerenciamentoServicos frmGerenciamentoServicos = new FormularioGerenciamentoServicos();
            frmGerenciamentoServicos.ShowDialog();
            return frmGerenciamentoServicos;
        }
    }
}
