using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string[2];

            for(int i = 0; i < nomes.Length; i++)
            {
                System.Console.WriteLine("Insira um nome: ");
                nomes[i] = Console.ReadLine();
            }

            Array.Sort(nomes);
            Console.WriteLine($"Os nomes estao em ordem alfabetica {nomes[0]} e {nomes[1]}");
        }
    }
}
