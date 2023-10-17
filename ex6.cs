using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int x, y;
            Console.WriteLine("Digite a coordenada de X");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a coordenada de Y");
            y = int.Parse(Console.ReadLine());
            if(x == 0 || y == 0)
            {
                Console.WriteLine("Erro, você digitou zero!");
                Console.WriteLine("Fim do programa!");
            }
            while(x != 0 || y !=0) 
            {
                if (x > 0 && y > 0) 
                {
                    Console.WriteLine("primeiro quadrante");
                   break;
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo quadrante");
                    break;
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro quadrante");
                    break;
                }
                if(x > 0 && y < 0)
                {
                    Console.WriteLine("quarto quadrante");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
