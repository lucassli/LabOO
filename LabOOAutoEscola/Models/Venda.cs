namespace LabOOAutoEscola.Models
{
    public class Venda
    {
        Double valorVenda;
        DateTime dataVenda;
        int numeroParcelas;
        Double valorParcela;
        Double valorEntrada;
        DateTime dataVencimento;
        FormaPagamento formaPagamento;

        private Double _valorVenda { get; set; }
        private DateTime _dataVencimento { get; set; }   
        private int _numeroParcelas { get; set; }
        private Double _valorParcela { get; set; }  
        private double _valorEntrada { get; set; }
        private DateTime _dataVenda { get; set; }
        private FormaPagamento _formaPagamento { get; set; }
        private List<Itens> itens = new List<Itens>(); //métodos de acessos a serem definidos após a reunião de formulação das funções
    }
}
