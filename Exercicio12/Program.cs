using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
        int [] numeros = new int[3];

        for(int i = 0; i < numeros.Length; i++)
        {
            System.Console.WriteLine("Escreva um número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);
        Console.WriteLine($"Os números estao em ordem crescente {numeros[0]}, {numeros[1]} e {numeros[2]} ");

        }
    }
}
