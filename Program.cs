using System;

namespace olaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
              string nome;

            //<---Inicio(Digite--->//
            Console.Write("Digite Seu Nome: ");
            nome = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine($"Olá, {nome}!");
            //<---Fim(Digite)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->//
            
        }
    }
}
