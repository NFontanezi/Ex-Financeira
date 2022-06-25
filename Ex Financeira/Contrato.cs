using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
   public abstract class Contrato
    {

        private Guid IdContrato { get { return ObterIDCodigo(); } }

        public string Contratante { get; set; }
        public decimal Valor { get; set; }
        public int Prazo { get; set; }

        public abstract void ExibirInfo();

        public abstract Guid ObterIDCodigo();

        public abstract decimal CalcularPrestacao();


    }

}
