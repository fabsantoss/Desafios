using System;
using System.Linq;
using Zoologico.Models.Animais;
using Zoologico.Interfaces;
namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            var encerrouPrograma = false;
            #region Loop Principal
            do
            {
                #region  Menu Principal
                var codigo = 0;
                Console.Clear();
                System.Console.WriteLine("*******************************");
                System.Console.WriteLine("| Seja Bem-vindo ao Zoológico |");
                System.Console.WriteLine("*******************************");

                foreach ( var item in Deposito.Animais.Values)
                {
                    System.Console.WriteLine($"{"",5}{++codigo}. {item.GetType().Name}");
                }
                #endregion
                System.Console.Write($"\n{"",2}Digite o código do animal:");

                try
                {
                    var opcaoUsuario = int.Parse(Console.ReadLine());
                    var animal = Deposito.Animais[opcaoUsuario];
                    ClassificarAnimal(animal);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Por favor, digite um código válido");
                    Console.ReadLine();
                }
            } while (!encerrouPrograma);
            #endregion
        }

        public static void ClassificarAnimal(Animal animal)
        {
            var classe = animal.GetType();
            var @interface = classe.GetInterfaces().FirstOrDefault();

            if ((typeof(IAquatico)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina :::");
            }
            else if ((typeof(IArboricula)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Casa na Árvore::: ");
            }
            else if ((typeof(IBranquiado)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para  o Aquário::: ");
            }
            else if ((typeof(IPolar)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina gelada::: ");
            }
            else if ((typeof(ITerrestre)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para os Pasto ou Cavernas de Pedras ::: ");
            }
            else if ((typeof(IVoador)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Gaiola::: ");
            }

            Console.ReadLine();


        }
    }
}
