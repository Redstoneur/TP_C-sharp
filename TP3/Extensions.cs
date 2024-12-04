namespace TP3;

public static class Extensions
{
    public static void AfficherTous(this List<ArticleType> articles)
    {
        Console.WriteLine("Articles :");
        foreach (var article in articles)
        {
            Console.WriteLine($" -> {article}");
        }
    }
}