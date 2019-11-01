using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0 ;

            System.Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());
            int [] posicoes  = new int [num];

            posicoes = new int[num];
            for (int i= 0; i < num; i = i + 2 )
            {
                System.Console.WriteLine("Digite o primeiro número");
                posicoes[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i < num; i++);
        }
    }
}
