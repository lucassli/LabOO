namespace LabOOAutoEscola.Models
{
    public class Cliente
    {
        string nomeCliente;
        DateTime dataNascimento;
        string numeroIdentididade;
        string cpf;
        Boolean status;

        private Boolean _status { get; set; }
        private string _cpf { get; set; }
        private string _numeroIdentidade { get; set; }
        private string _nomeCliente { get; set; }
        private string _dataNascimento { get; set; }
    }
}
