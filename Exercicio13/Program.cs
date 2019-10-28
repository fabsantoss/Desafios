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
            lado1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor do lado 2:");
            lado2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor do lado 3:");
            lado3 = int.Parse(Console.ReadLine());

            if ((lado1 < lado2 + lado3) && (lado2<lado1+lado3) && (lado3 < lado1 + lado2))
            {
                System.Console.WriteLine("Estes valores forma um Triangulo");

                if ((lado1 == lado2) && (lado2 == lado3)){
                System.Console.WriteLine("Este valores forma um Equilátero"); 
                } else if ((lado1 == lado2) && ( lado2 == lado3) && (lado1 == lado3)) {
                    System.Console.WriteLine("Esse valor forma um isoceles");
                } else {
                    System.Console.WriteLine(" esse valor forma um triangulo escaleno");
                }
            } else {
                System.Console.WriteLine("Este valores não forma um triangulo");
            }
        }
    }
}
