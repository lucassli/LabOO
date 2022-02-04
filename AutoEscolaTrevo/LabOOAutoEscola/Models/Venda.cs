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
        FormasPagamento formasPagamento;

        public Double _valorVenda { get; set; }
        public DateTime _dataVencimento { get; set; }   
        public int _numeroParcelas { get; set; }
        public Double _valorParcela { get; set; }  
        public double _valorEntrada { get; set; }
        public DateTime _dataVenda { get; set; }
        public FormasPagamento _formasPagamento { get; set; }
        public List<Itens> itens = new List<Itens>(); //métodos de acessos a serem definidos após a reunião de formulação das funções
    }
}
