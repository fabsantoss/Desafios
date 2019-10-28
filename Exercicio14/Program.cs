using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            string verbo;

            System.Console.WriteLine("Digite um verbo no infinitivo");
            verbo = Console.ReadLine();

            if ( verbo.EndsWith("ar"))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Verbo na primeira conjução");
                System.Console.WriteLine();
            }
            else if ( verbo.EndsWith("er"))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Verbo na segunda conjução");
                System.Console.WriteLine();
            }
            else if ( verbo.EndsWith("ir"))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Verbo na terceira conjução");
                System.Console.WriteLine();
            }
            else 
            {
                System.Console.WriteLine("Este verbo não se encontra no infinitivo");
            }
        }
    }
}
