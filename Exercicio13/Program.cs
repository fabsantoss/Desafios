using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1;
            int lado2;
            int lado3;

            System.Console.WriteLine("Digite o valor do lado 1:");
            Console.ReadLine();
            System.Console.WriteLine("Digite o valor do lado 2:");
            Console.ReadLine();
            System.Console.WriteLine("Digite o valor do lado 3:");
            Console.ReadLine();

            if ((lado1<lado2 + lado3) && (lado2<lado1+lado3) && (lado3<lado1+lado2))
            {
                System.Console.WriteLine("Estes valores foram um triangulo");
            }
        }
    }
}
