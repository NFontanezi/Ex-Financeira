using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public class ContratoPessoaJuridica : Contrato
    {
        public ContratoPessoaJuridica(string cNPJ, string inscricaoEstadual,
         string contratante, decimal valor, int prazo)
        {
            CNPJ = cNPJ;
            InscricaoEstadual = inscricaoEstadual;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }

        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }

        public static List<ContratoPessoaJuridica> ListaPJ { get; set; } = new();

        public override Guid ObterIDCodigo()
        {
            return Guid.NewGuid();
        }
        public override decimal CalcularPrestacao()
        {
            decimal prestacao = Valor / Prazo + 3;
            return prestacao;

        }
        public void SalvarListaPJ(ContratoPessoaJuridica pessoa)
        {
            ListaPJ.Add(pessoa);
        }

        public static void ExibirListaPJ()
        {
            if (ListaPJ == null)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("\n\t#######Contratos PJ#####");
                foreach (ContratoPessoaJuridica contrato in ListaPJ)
                {
                    contrato.ExibirInfo();
                }
            }
        }
    
    public override void ExibirInfo()
    {
        Console.WriteLine($"=====================================");
        Console.WriteLine($"Codigo : {ObterIDCodigo()}");
        Console.WriteLine($"Contratante : {Contratante}");
        Console.WriteLine($"CNPJ : {CNPJ}");
        Console.WriteLine($"Inscrição : {InscricaoEstadual}");
        Console.WriteLine($"Valor : {Valor:C2}");
        Console.WriteLine($"Prazo : {Prazo}");
        Console.WriteLine($"Prazo : {CalcularPrestacao():C2}");
        // Console.ReadKey();

    }

}
}
