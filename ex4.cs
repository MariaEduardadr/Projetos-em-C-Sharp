using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double preco, imosto, preco_final;
            string estado;

            Console.WriteLine("Digite o valor do produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o estado de destino do produto: ");
            estado = Console.ReadLine();

            if(estado == "MG" || estado == "mg")
            {
                imosto = preco * 7/100 ;
                preco_final = preco + imosto;
                Console.WriteLine("Valor total de imposto para o estado de MG: " + preco_final);
            }
            else if (estado == "SP" || estado == "sp")
            {
                imosto = preco * 12 / 100;
                preco_final = preco + imosto;
                Console.WriteLine("Valor total de imposto para o estado de SP: " + preco_final);

            }
            else if (estado == "RJ" || estado == "rj")
            {
                imosto = preco * 15 / 100;
                preco_final = preco + imosto;
                Console.WriteLine("Valor total de imposto para o estado de RJ: " + preco_final);
            }
            else if (estado == "ES" || estado == "es")
            {
                imosto = preco * 8 / 100;
                preco_final = preco + imosto;
                Console.WriteLine("Valor total de imposto para o estado de ES: " + preco_final);
            }
            else
            {
                Console.WriteLine("ERRO!");
                Console.WriteLine("Estado inválido");
            }


            Console.ReadLine();
        }
    }
}
