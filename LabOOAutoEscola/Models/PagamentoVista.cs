namespace LabOOAutoEscola.Models
{
    public class PagamentoaVista:Pagamento
    {
        Double valorPago;
        Double valorDesconto;

        private Double _valorPago { get; set; } 
        private Double _valorDesconto { get; set; }
    }
}
