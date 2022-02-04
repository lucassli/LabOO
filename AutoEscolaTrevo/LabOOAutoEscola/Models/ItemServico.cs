namespace LabOOAutoEscola.Models
{
    public class ItemServico
    {
        private double _valorItem { get; set; }
        private string _nomeItem { get; set; }
        private double _taxaServico { get; set; }
        private int quantidade { get; set; }
        private List<Servico> servicos = new List<Servico>(); //métodos de acessos a serem definidos após a reunião de formulação das funções
}
}
