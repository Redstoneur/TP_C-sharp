﻿namespace TP2Ex1;

class Video(string nom, double prix, int quantite, TypeArticle type, double duree)
    : ArticleType(nom, prix, quantite, type), IRentable
{
    protected double Duree { get; set; } = duree;

    public double CalculateRent()
    {
        return base.Prix * 0.1; // Exemple : 10% du prix
    }

    public override string ToString() => base.ToString() + $", Duree : {Duree}";

    public new void Afficher()
    {
        Console.WriteLine(ToString());
    }
}