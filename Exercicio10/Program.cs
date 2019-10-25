using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            System.Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            if ((num % 3) !=0){
                Console.WriteLine("Esse número não é multiplo de 3");
            } 
            else {
                Console.WriteLine("Esse número é multiplo de 3");
            }
        }
    }
}
