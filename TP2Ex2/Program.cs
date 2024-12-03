﻿namespace TP2Ex2;

internal static class Program
{
    private static void Main(string[] args)
    {
        const int nbTirets = 100;

        Console.WriteLine("\n\n" + new string('-', nbTirets));
        Console.WriteLine("--- TP1 ---");
        Console.WriteLine("" + new string('-', nbTirets));

        Console.WriteLine(new string('-', nbTirets));
        Console.WriteLine("Exercice 2 :");

        Tp1Exercice2();
    }

    private static void Tp1Exercice2()
    {
        List<Article> articles =
        [
            new Livre("Livre", 10, 5, true, 200),
            new Disque("Disque", 15, 3, "Label 2023"),
            new Video("Film", 20, 2, 120),
            new Disque("Disque 2", 15, 3, "Label 2023"),
            new Livre("Livre 2", 20, 3, false, 150),
            new Video("Film 2", 25, 2, 90)
        ];

        foreach (var article in articles)
        {
            Console.WriteLine("\n");

            article.PublishDetails();
        }
    }
}