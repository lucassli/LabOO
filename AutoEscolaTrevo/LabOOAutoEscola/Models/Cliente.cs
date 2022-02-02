namespace LabOOAutoEscola.Models
{
    public class Cliente
    {
        string nome;
        DateTime dataNascimento;
        int numeroIdentididade;
        int cpf;
        Boolean status;

        public Boolean Status { get; set; }
        public int Cpf { get; set; }
        public int NumeroIdentidade { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
    }
}
