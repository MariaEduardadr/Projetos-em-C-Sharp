using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int opacao;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("MENU DE OPÇÕS");
            Console.WriteLine("1. Somar dois números");
            Console.WriteLine("2. Subtrair dois números");
            Console.WriteLine("3. Multiplicação de dois números");
            Console.WriteLine("4. Divisão de dois números");
            Console.WriteLine("--------------------------------");
            // espaço
            Console.WriteLine("     ");
            //espaço
            Console.WriteLine("Informe uma das opçõs acima:");
            opacao = int.Parse(Console.ReadLine());

            if(opacao == 1)
            {
                Console.WriteLine("1. Somar dois números");
                int num1, num2, result;
                Console.WriteLine("informe um número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe outro número");
                num2 = int.Parse(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine( num1 + " + " + num2 + " é igual a: " +result);
            }
            else if(opacao == 2)
            {
                Console.WriteLine("2. Subtrair dois números");
                int num1, num2, result;
                Console.WriteLine("informe um número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe outro número");
                num2 = int.Parse(Console.ReadLine());
                result = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " é igual a: " + result);
            }
            else if (opacao == 3)
            {
                Console.WriteLine("3. Multiplicação de dois números");
                int num1, num2, result;
                Console.WriteLine("informe um número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe outro número");
                num2 = int.Parse(Console.ReadLine());
                result = num1 * num2;
                Console.WriteLine(num1 + " X " + num2 + " é igual a: " + result);
            }
            else if (opacao == 4)
            {
                Console.WriteLine("4. Divisão de dois números");    
                int num1, num2, result;
                Console.WriteLine("informe um número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe outro número");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
                if(result != 0)
                {
                    Console.WriteLine(num1 + " / " + num2 + " é igual a: " + result);
                }
                else
                {
                    Console.WriteLine("Erro divisão por zero!");
                }
            }
            else
            {
                Console.WriteLine("ERRO!");
            }

            Console.ReadLine();
        }
    }
}
