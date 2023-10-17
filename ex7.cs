using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int opcao;
            Console.WriteLine("Menu de opçoões: ");
            Console.WriteLine("1. Novo saláiro");
            Console.WriteLine("2. Férias");
            Console.WriteLine("3. Décimo terceiro");
            Console.WriteLine("4. Sair");
            
            do
            {
                Console.WriteLine("Informe uma das opções acima: ");
                opcao = int.Parse(Console.ReadLine());
                if(opcao == 1)
                {
                    Console.WriteLine("Novo saláiro");
                    double salario,soma;
                    Console.WriteLine("Digite seu sário:");
                    salario = double.Parse(Console.ReadLine());
                    if (salario >= 999.99)
                    {
                        soma = salario * 0.15;
                        Console.WriteLine("Seu novo salário " + soma);
                    }
                    if (salario >= 1000.00 && salario >= 2000.00)
                    {
                        soma = salario * 0.10;
                        Console.WriteLine("Seu novo salário " + soma);
                    }
                    if (salario > 2000.00)
                    {
                        soma = salario * 0.5;
                        Console.WriteLine("Seu novo salário " + soma);
                    }

                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Férias");
                    double ferias, salariof;
                    Console.WriteLine("Digite seu salário");
                    salariof = double.Parse(Console.ReadLine());
                    ferias = salariof + (salariof/ 3);
                    Console.WriteLine("Valor de suas Férias: " + ferias);
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Décimo terceiro");
                    int mes, soma, salario;
                    Console.WriteLine("Informe quantos meses você trabalhou este ano: ");
                    mes = int.Parse(Console.ReadLine());
                    if (mes > 12)
                    {
                        Console.WriteLine("Erro!, valor inválido");
                    }
                    else if(mes <= 12)
                    {
                        Console.WriteLine("Digite seu salário:");
                        salario = int.Parse(Console.ReadLine());
                        soma = salario * mes / 12;
                        Console.WriteLine("Valor do décimo terceiro salário: " + soma);
                    }
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Saiu!");
                }

            }
            while (opcao != 4);
            Console.ReadLine();   
        }
    }
}
