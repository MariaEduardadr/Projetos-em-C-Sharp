using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double vale_a, vale_t, metros;
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Predeiro " + (i + 1) + ":");
                Console.WriteLine("Digite o valor do vale-alimentação: ");
                vale_a = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do vale-transporte: ");
                vale_t = 2 * double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos metros o predeiro produziu: ");
                metros = double.Parse(Console.ReadLine());
                if (metros <= 10)
                {
                    Console.WriteLine("O valor a ser pago é: " + vale_a + vale_t + 10 * metros);
                }
                else if (metros < 20)
                {
                    Console.WriteLine("O valor a ser pago é: " + vale_a + vale_t + 11.50 * metros);
                }
                else if (metros > 20)
                {
                    Console.WriteLine("O valor a ser pago é: " + vale_a + vale_t + 13 * metros);
                }

            }
            Console.ReadLine();
        }
    }
}
