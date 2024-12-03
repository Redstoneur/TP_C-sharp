namespace TP2Ex3;

using System;

public class ArticleType(string? nom, double prix, int quantite, TypeArticle typeArticle) : Article(nom, prix, quantite)
{
    protected TypeArticle Type { get; } = typeArticle;

    public override string ToString() => base.ToString() + $", Type : {Type}";

    public void Afficher()
    {
        Console.WriteLine(ToString());
    }
    
    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($" - Type : {Type}");
    }
}