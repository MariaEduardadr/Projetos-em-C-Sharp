using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int d2=0, d3=0, d5 = 0, d6 = 0, num = 0; 

            while (true) 
            {
                Console.WriteLine("Digite um número");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("Divisilvel Por Dois");
                    d2++;
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Divisilvel Por Três");
                    d3++;
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Divisilvel Por Cinco");
                    d5++;
                }
                else if (num % 6 == 0)
                {
                    Console.WriteLine("Divisilvel Por Seis");
                    d6++;
                }
                else 
                {
                    Console.WriteLine(" Número não é divisível pelos valores");

                }
                Console.WriteLine("Quantidade de números divisíveis por 2 " + d2);
                Console.WriteLine("Quantidade de números divisíveis por 3 " + d3);
                Console.WriteLine("Quantidade de números divisíveis por 5 " + d5);
                Console.WriteLine("Quantidade de números divisíveis por 6 " + d6);

                Console.ReadLine();
            }
        } 
    }
}
