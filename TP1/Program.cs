namespace TP1;

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
    /// <param name="args">Un tableau d'arguments de la ligne de commande.</param>
    private static void Main(string[] args)
    {
        const int nbTirets = 100;
        const string titre = "TP1";

        Console.WriteLine(Titre(titre, nbTirets));

        Console.WriteLine("Exercice ARTICLE :");

        ExerciceArticles();

        Console.WriteLine(new string('-', nbTirets));
        Console.WriteLine("Exercice ARTICLE TYPE :");

        ExerciceArticlesType();

        Console.WriteLine(new string('-', nbTirets));
        Console.WriteLine("Tableau ARTICLE TYPE :");

        TableauArticlesType();
    }

    /// <summary>
    /// Démontre la fonctionnalité de la classe Article.
    /// </summary>
    private static void ExerciceArticles()
    {
        Article article1 = new Article("Livre", 15.5, 10);
        article1.Afficher();
        article1.Ajouter(5);
        article1.Afficher();
        article1.Retirer(3);
        article1.Afficher();

        Console.Write("Entrez le nom de l'article : ");
        string? nom = Console.ReadLine();
        Console.Write("Entrez le prix : ");
        double prix = Convert.ToDouble(Console.ReadLine());
        Console.Write("Entrez la quantité : ");
        int quantite = Convert.ToInt32(Console.ReadLine());

        Article article2 = new Article(nom, prix, quantite);
        article2.Afficher();
    }

    /// <summary>
    /// Démontre la fonctionnalité de la classe ArticleType.
    /// </summary>
    private static void ExerciceArticlesType()
    {
        ArticleType article1 = new ArticleType("Chocolat", 3.2, 50, TypeArticle.Alimentaire);
        article1.Afficher();

        Console.Write("Entrez le nom de l'article : ");
        string? nom = Console.ReadLine();
        Console.Write("Entrez le prix : ");
        double prix = Convert.ToDouble(Console.ReadLine());
        Console.Write("Entrez la quantité : ");
        int quantite = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entrez le type (Alimentaire, Droguerie, Habillement, Loisir) : ");
        TypeArticle type = (TypeArticle)Enum.Parse(typeof(TypeArticle),
            Console.ReadLine() ?? throw new InvalidOperationException());

        ArticleType article2 = new ArticleType(nom, prix, quantite, type);
        article2.Afficher();
    }

    /// <summary>
    /// Démontre la fonctionnalité d'un tableau d'objets ArticleType.
    /// </summary>
    private static void TableauArticlesType()
    {
        ArticleType[] articles = new ArticleType[3];
        articles[0] = new ArticleType("Veste", 75.99, 10, TypeArticle.Habillement);
        articles[1] = new ArticleType("Jeu vidéo", 59.99, 5, TypeArticle.Loisir);
        articles[2] = new ArticleType("Savon", 2.50, 30, TypeArticle.Droguerie);

        foreach (var article in articles)
        {
            article.Afficher();
        }
    }
}