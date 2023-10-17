using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double gravidade, terra, venus, mercurio, planeta;
            char cartactere;

            Console.WriteLine("Escolha um planeta:");
            Console.WriteLine("T) Terra");
            Console.WriteLine("V) Vênus");
            Console.WriteLine("M) Mercúrio");
            cartactere = char.Parse(Console.ReadLine());

            switch (cartactere)
            {
                case 'T':
                    Console.WriteLine("informe a velocidade de queda de um corpo em função do tempo: ");
                    terra = double.Parse(Console.ReadLine());
                    gravidade = 9.807;
                    planeta = terra / gravidade;
                    Console.WriteLine("Resultado: " + planeta);
                    break;
                case 'V':
                    Console.WriteLine("informe a velocidade de queda de um corpo em função do tempo: ");
                    venus = double.Parse(Console.ReadLine());
                    gravidade = 8.87;
                    planeta = venus / gravidade;
                    Console.WriteLine("Resultado: " + planeta);
                    break;
                case 'M':
                    Console.WriteLine("informe a velocidade de queda de um corpo em função do tempo: ");
                    mercurio = double.Parse(Console.ReadLine());
                    gravidade = 3.7;
                    planeta = mercurio / gravidade;
                    Console.WriteLine("Resultado: " + planeta);
                    break;
            }
            Console.ReadLine();
        }
    }
}
