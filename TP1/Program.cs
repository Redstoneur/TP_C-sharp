namespace TP1;

internal static class Program
{
    private static void Main(string[] args)
    {
        const int nbTirets = 100;

        Console.WriteLine("\n" + new string('-', nbTirets));
        Console.WriteLine("--- TP1 ---");
        Console.WriteLine(new string('-', nbTirets));

        Console.WriteLine("Exercice ARTICLE :");

        ExerciceArticles();

        Console.WriteLine(new string('-', nbTirets));
        Console.WriteLine("Exercice ARTICLE TYPE :");

        ExerciceArticlesType();

        Console.WriteLine(new string('-', nbTirets));
        Console.WriteLine("Tableau ARTICLE TYPE :");

        TableauArticlesType();
    }

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