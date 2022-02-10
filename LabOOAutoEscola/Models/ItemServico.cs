namespace LabOOAutoEscola.Models
{
    public class ItemServico
    {
        Double valorItem;
        string nomeItem;
        Double taxaServico;
        int quantidade;

        private double _valorItem { get; set; }
        private string _nomeItem { get; set; }
        private double _taxaServico { get; set; }
        private int _quantidade { get; set; }
        private List<Servico> servicos = new List<Servico>(); //métodos de acessos a serem definidos após a reunião de formulação das funções
}
}
