using System;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            int animal;

            Console.Clear();
            System.Console.WriteLine("*******************************");
            System.Console.WriteLine("| Seja bem-vindo ao Zoológico |");
            System.Console.WriteLine("*******************************");
            System.Console.WriteLine("*******************************");
            System.Console.WriteLine("****  1- Tubarão Martelo   ****");
            System.Console.WriteLine("***   2- Tucano             ***");
            System.Console.WriteLine("**    3- Arara               **");
            System.Console.WriteLine("**    4- Leão                **");
            System.Console.WriteLine("**    5- Orangotango         **");
            System.Console.WriteLine("**    6- Chimpanzé           **");
            System.Console.WriteLine("**    7- Pinguim             **");
            System.Console.WriteLine("***   8- Tartaruga          ***");
            System.Console.WriteLine("****  9- Golfinho          ****");

            System.Console.WriteLine("Digite o número correspondente ao animal:");
            animal = int.Parse(Console.ReadLine());

            if(animal == 1)
            {
                System.Console.WriteLine("Este animal deve ir para o aquário");
            }
            else if (animal == 2)
            {
                System.Console.WriteLine("Este animal deve ir para a gaiola");
            }
            else if (animal == 3)
            {
                System.Console.WriteLine("Este animal deve ir para a gaiola");
            }
            else if (animal == 4)
            {
                System.Console.WriteLine("Este animal deve ir para o pasto");
            }
            else if (animal == 5)
            {
                System.Console.WriteLine("Este animal deve ir para casa em arvore");
            }
            else if (animal == 6)
            {
                System.Console.WriteLine("Este animal deve ir para a gaiola");
            }
            else if ( animal == 7)
            {
                System.Console.WriteLine("Este animal deve ir para piscina gelada");
            }
            else if (animal == 8)
            {
                System.Console.WriteLine("Este animal deve ir pode ir tanto para aquário quanto para a piscina ");
            }
            else if ( animal == 9)
            {
                System.Console.WriteLine("Este animal deve ir para aquário");
            }
        }
    }
}
