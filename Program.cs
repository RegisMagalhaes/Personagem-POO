using System;

namespace POO_Personagem
{
    class Program
    {
        static void Main(string[] args)
        {

            //Regis crie um programa que mostre na tela dados de atributos de objetos diferentes
            Personagem heroi1 = new Personagem();
            Console.WriteLine("Digite o nome do Personagem: ");
            heroi1.nome = Console.ReadLine();

            Personagem heroi2 = new Personagem();
            Console.WriteLine("Digite o nome do Personagem: ");
            heroi2.nome = Console.ReadLine();

            Console.WriteLine($"Os nomes dos herois são {heroi1.nome} e {heroi2.nome}");

        }
    }
}
