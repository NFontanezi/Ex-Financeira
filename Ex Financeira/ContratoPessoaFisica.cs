namespace Financeira
{
    public class ContratoPessoaFisica : Contrato
    {

        public string CPF { get; set; }

        public DateTime DataNasc { get; set; }

      public static  List<ContratoPessoaFisica> ListaPF { get; set; } = new();

        public int idade;
        public int Idade { get { return CalcularIdade(); } }
        public override Guid ObterIDCodigo()
        {
            return Guid.NewGuid();
        }


        public override decimal CalcularPrestacao()
        {
            var prestacao = Valor / Prazo;
            if (Idade <= 30)
                return prestacao += 1;
            else if (Idade <= 40)
                return prestacao += 2;
            else if (Idade <= 50)
                return prestacao += 3;
            else 
                return prestacao +=4;

        }
        public int CalcularIdade()
        {
            idade = DateTime.Now.Year - DataNasc.Year;

            if (DateTime.Now.DayOfYear < DataNasc.DayOfYear)
            {
                idade--;
            }

            return idade;
        }

        public void SalvarListaPF(ContratoPessoaFisica pessoa)
        {
            ListaPF.Add(pessoa);
        }
        public static void  ExibirListaPF()
        { if (ListaPF == null)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("\n\t#######Contratos PF#####");
                foreach (ContratoPessoaFisica contrato in ListaPF)
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
            Console.WriteLine($"CPF : {CPF}");
            Console.WriteLine($"Valor : {Valor:C2}");
            Console.WriteLine($"Prazo : {Prazo}");
            Console.WriteLine($"Valor Prestação: {CalcularPrestacao():C2}");
            Console.WriteLine($"Idade : {Idade}");
            //Console.ReadKey();
        }
    }

}
