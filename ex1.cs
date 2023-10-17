using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade, tempo;
            char tipo;

            Console.WriteLine("informe sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("informe quanto tempo você possui a habilitação:");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o tipo de categoria B ou C:");
            tipo = char.Parse(Console.ReadLine());

            if(idade >= 21)
            {
                if( tipo == 'b' && tempo >= 2)
                {
                    Console.WriteLine("Você possui todos requisitos para tirar carteira habilitação tipo D");
                }
                else if(tipo == 'c' && tempo >= 1)
                {
                    Console.WriteLine("Você possui todos requisitos para tirar carteira habilitação tipo D");
                }
                else
                {
                    Console.WriteLine("Você NÃO possui todos requisitos para tirar carteira habilitação tipo D");
                }
            }
             else
            {
                Console.WriteLine("Você NÃO tem idade suficiente para tirar carteira habilitação tipo D");
            }

            Console.ReadLine();
        }
    }
}
