namespace LabOOAutoEscola.Models
{
    public class PagamentoCarne:Pagamento
    {
        Double valorPago;
        Double multaAtraso;

        private Double _multaAtraso { get; set; }
        private Double _valorPago { get; set; }

    }
}
