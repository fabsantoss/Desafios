using System;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double peso;
            double altura;
            double imc;

            System.Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            System.Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if(imc < 20){
                System.Console.WriteLine($"{nome}");
                System.Console.WriteLine("Abaixo do peso");
            }
            else if ((imc >=20) && (imc <=25))
            {
                System.Console.WriteLine($"{nome}");
                System.Console.WriteLine("Normal");
            }
            else if ((imc >=25) && (imc <=30))
            {
                System.Console.WriteLine($"{nome}");
                System.Console.WriteLine("Exesso de peso");
            }
            else if ((imc >=30) && (imc <=35))
            {
                System.Console.WriteLine($"{nome}");
                System.Console.WriteLine("Obesidade");
            }
            else if (imc >=35)
            {
                System.Console.WriteLine($"{nome}");
                System.Console.WriteLine("Obesidade morbita");
            }
        }
    }
}
