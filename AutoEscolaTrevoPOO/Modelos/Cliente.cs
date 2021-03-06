using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

namespace AutoEscolaTrevoPOO.Models
{
    public class Cliente
    {
        List<Venda> venda =  new List<Venda>();
        
        string nomeCliente;
        DateTime dataNascimento;
        string numeroIdentididade;
        string cpf;
        bool status;
        string dataExpedicaoIdentidade;

        public Cliente()
        {
            private bool _status { get; set; }
            private string _cpf { get; set; }
            private string _numeroIdentidade { get; set; }
            private string _nomeCliente { get; set; }
            private string _dataNascimento { get; set; }
        }
    }
}
