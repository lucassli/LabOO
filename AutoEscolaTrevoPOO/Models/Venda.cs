using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevoPOO.Models
{
    public class Venda
    {
        List<Pagamentos> pagamentos = new List<Pagamentos>();
        
        double valorVenda;
        DateTime dataVenda;
        int numeroParcelas;
        double valorParcela;
        double valorEntrada;
        DateTime dataVencimento;
        FormaPagamento formaPagamento;
        Cliente cliente;
        Pagamento pagamento;
        

        public Venda()
        {
            private double _valorVenda { get; set; }
            private DateTime _dataVencimento { get; set; }
            private int _numeroParcelas { get; set; }
            private double _valorParcela { get; set; }
            private double _valorEntrada { get; set; }
            private DateTime _dataVenda { get; set; }
            private FormaPagamento _formaPagamento { get; set; }
            private ItemServico List<Itens> itens = new List<Itens>();
            private Cliente _cliente { get; set; }
            private Pagamento _pagamento { get; set; }
        }
    }
}
