using System;
using System.Globalization;
using System.Threading;

namespace AutoEscolaTrevoPOO.Models
{
    public class Servico
    {
        public string nomeServico {get;}
        public double valorServico {get;} 
        public double valorMinimo {get;}
        public int codigoServico {get;}
        public double taxaServico {get;}

        public Servico()
        {
            this.nomeServico = _nomeServico;
            this.valorServico = _valorServico;
            this.valorMinimo = _valorMinimo;
            this.codigoServico = _codigoServico;
            this.taxaServico = _taxaserviço;
        }
    }
}
