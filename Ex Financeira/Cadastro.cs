using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
   
   public class  Cadastro 
    {

        public static string ObterContratante()
        {

            Console.Write("Informe o nome do contratante: ");
            return Uteis.ValidarString();
        }
        public static string ObterCPF()
        {

            Console.Write("Informe CPF: ");
            return Uteis.ValidarString();
        }
        public static string ObterCNPJ()
        {

            Console.Write("Informe CNPJ: ");
            return Uteis.ValidarString();
        }
        public static string ObterInscricao()
        {

            Console.Write("Informe a Inscriçao Estadual: ");
            return Uteis.ValidarString();
        }
        public static decimal ObterValor()
        {

            Console.Write("Informe Valor: ");
            return Uteis.ValidarNumero();
        }
        public static int ObterPrazo()
        {

            Console.Write("Informe Prazo (numero de meses): ");
            return (int)Uteis.ValidarNumero();
        }
        public static DateTime ObterDataNasc()
        {
            DateTime data;
            bool dataValida = false;
            do
            {
                Console.Write("Informe Data de Nascimento (DD/MM/AAAA): ");
                dataValida = DateTime.TryParse(Console.ReadLine(), out data);
                if (dataValida)
                { break; }
                Console.Write("Data Invalida");
                Console.ReadKey();
            } while (!dataValida);

                return data;
            
        }
    }
}


