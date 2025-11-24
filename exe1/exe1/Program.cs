using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letras = new char[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a {0}º letra para formar uma palavra: ", i + 1);
                letras[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("A palavra é: ");

            for (i = 0; i < 10; i++)
            {
                Console.Write(letras[i]);
            }
            Console.WriteLine();
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}° letra:{1} ", i + 1, letras[i]);
            }
        }
    }
}