using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

namespace AutoEscolaTrevoPOO.Models
{
    public class Servico
    {
        List<ItemServico> itenservico = new List<ItemServico>();
        
        string nomeServico;
        double valorServico;
        double valorMinimo;
        int codigoServico;
        double taxaServico;

        public Servico()
        {
            private string _nomeServico { get; set; }
            private double _valorServico { get; set; }
            private double _valorMinimo { get; set; }
            private int _codigoServico { get; set; }
            private double _taxaServico { get; set; }
        }
    }
}
