using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            int dia;
            double maior = 0, menor = double.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe à temperatura do dia: ");
                dia = int.Parse(Console.ReadLine());

                if (dia > maior)
                {
                    maior = dia;
                }
                if (dia < menor)
                {
                    menor = dia;
                }
            }
            Console.WriteLine("maior temperatura ocorreu no dia " + maior);
            Console.WriteLine("menor temperatura ocorreu no dia " + menor);

            Console.ReadLine();
        }
    }
}
