namespace LabOOAutoEscola.Models
{
    public class Servico
    {
        string nomeServico;
        Double valorServico;
        Double valorMinimo;
        int codigoServico;
        Double taxaServico;

        private string _nomeServico { get; set; }
        private double _valorServico { get; set; }
        private double _valorMinimo { get; set; }
        private int _codigoServico { get; set; }
        private double _taxaServico { get; set; }
    }
}
