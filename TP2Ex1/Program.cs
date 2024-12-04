namespace TP2Ex1;

/// <summary>
/// La classe principale du programme pour TP2Ex1.
/// </summary>
internal static class Program
{
    /// <summary>
    /// Génère une chaîne de titre formatée avec des tirets autour.
    /// </summary>
    /// <param name="titre">Le titre à formater.</param>
    /// <param name="nbTirets">Le nombre de tirets à utiliser pour la bordure.</param>
    /// <returns>Une chaîne formatée avec le titre entouré de tirets.</returns>
    private static string Titre(string titre, int nbTirets)
    {
        string tirets = new string('-', nbTirets);
        string titreEntoure = $"--- {titre} ---";
        titreEntoure += new string('-', nbTirets - titreEntoure.Length);

        return $"{tirets}\n{titreEntoure}\n{tirets}";
    }

    /// <summary>
    /// Le point d'entrée principal de l'application.
    /// </summary>
    /// <param name="args">Les arguments de la ligne de commande.</param>
    private static void Main(string[] args)
    {
        const int nbTirets = 100;
        const string titre = "TP2";

        Console.WriteLine(Titre(titre, nbTirets));

        Console.WriteLine("Exercice 1 :\n");

        Tp1Exercice1();
    }

    /// <summary>
    /// Exécute le premier exercice de TP2.
    /// </summary>
    private static void Tp1Exercice1()
    {
        Console.WriteLine("Création d'une liste d'articles ...");
        List<Article> articles =
        [
            new Livre("Livre", 10, 5, true, 200),
            new Disque("Disque", 15, 3, "Label 2023"),
            new Video("Film", 20, 2, 120),
            new Disque("Disque 2", 15, 3, "Label 2023"),
            new Livre("Livre 2", 20, 3, false, 150),
            new Video("Film 2", 25, 2, 90)
        ];

        Console.WriteLine("Liste des articles :\n");
        foreach (var article in articles)
        {
            article.Afficher();

            if (article is IRentable rentable)
            {
                Console.WriteLine($"Le prix de la location est de {rentable.CalculateRent()} €");
            }

            Console.WriteLine("");
        }
    }
}