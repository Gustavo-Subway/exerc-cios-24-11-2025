using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char l;
            int i, e;

            Console.WriteLine("Digite quantas letras tem a palavra");
            e = int.Parse(Console.ReadLine());

            char[] letras = new char[e];
            string acertou = "não";

            for (i = 0; i < e; i++)
            {
                Console.WriteLine("Digite a {0}º letra da palavra: ", i + 1);
                letras[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Digite uma letra para iniciar a busca");
            l = char.Parse(Console.ReadLine());

            for (i = 0; i < e; ++i)
            {
                if (letras[i] == l)
                {
                    Console.WriteLine("Essa letra tem na palavra");
                    acertou = "sim";
                }

            }
            if (acertou == "não")
            {
                Console.WriteLine("Essa letra não tem na palavra");
                Console.WriteLine("Tente novamente");
                l = char.Parse(Console.ReadLine());

                for (i = 0; i < e; ++i)
                {
                    if (letras[i] == l)
                    {
                        Console.WriteLine("Essa letra tem na palavra");
                        acertou = "sim";
                    }

                }

                if (acertou == "não")
                {
                    Console.WriteLine("Essa letra não tem na palavra");
                    Console.WriteLine("Tente novamente");
                    l = char.Parse(Console.ReadLine());

                    for (i = 0; i < e; ++i)
                    {
                        if (letras[i] == l)
                        {
                            Console.WriteLine("Essa letra tem na palavra");
                            acertou = "sim";
                        }

                    }

                }
            }
            if (acertou == "não")
            {
                Console.WriteLine("Essa letra não tem na palavra");
                Console.WriteLine("Acabram suas tentativas");
            }

                Console.WriteLine();

            Console.Write("A palavra é: ");

            for (i = 0; i < e; i++)
            {
                Console.Write(letras[i]);
            }
            Console.WriteLine();
            for (i = 0; i < e; i++)
            {
                Console.WriteLine("{0}° letra:{1} ", i + 1, letras[i]);
            }

           
        }
    }
}