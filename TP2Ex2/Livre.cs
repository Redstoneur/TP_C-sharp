﻿namespace TP2Ex2;

class Livre(string nom, double prix, int quantite, TypeArticle type, bool isBn, int nbPages)
    : ArticleType(nom, prix, quantite, type), IRentable
{
    protected bool IsBn { get; set; } = isBn;
    protected int NbPages { get; set; } = nbPages;

    public double CalculateRent()
    {
        return Prix * 0.05; // Exemple : 5% du prix
    }

    public override string ToString() => base.ToString() + $", IsBn : {IsBn}, NbPages : {NbPages}";

    public new void Afficher()
    {
        Console.WriteLine(ToString());
    }
    
    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($" - ISBN : {IsBn}");
        Console.WriteLine($" - Nombre de pages : {NbPages}");
    }
}