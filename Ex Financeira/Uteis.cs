using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public static class Uteis
    {
        public static string ValidarString()
        {
            bool validastr = false;
            string str;
            do
            {   str=Console.ReadLine();
                if (!String.IsNullOrEmpty(str) ||!String.IsNullOrEmpty(str))
                {   validastr = true; 
                    break;
                }
                Console.WriteLine("Invalido");
            }
            while (!validastr);
            return str;
        }
        public static decimal ValidarNumero()
        {
            decimal valorI;
            bool opcaoValida = false;
            do
            {
                string valor = Console.ReadLine();
                opcaoValida = decimal.TryParse(valor, out valorI) && valorI > 0;
                if (opcaoValida)
                {
                    break;
                }
                Console.WriteLine("Invalido");
            }
            while (!opcaoValida);
            return valorI;
        }
    }
}
