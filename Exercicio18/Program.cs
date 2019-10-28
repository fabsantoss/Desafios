using System;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            System.Console.WriteLine("Digite um número que séra o limite superior");
            numero = int.Parse(Console.ReadLine());

            for(int i =1; i < numero; i +=2){
                Console.Write(i + " ");
            }
        }
    }
}
