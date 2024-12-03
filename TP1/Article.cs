namespace TP1;

using System;

public class Article(string? nom, double prix, int quantite)
{
    protected string? Nom { get; } = nom;
    protected double Prix { get; } = prix;
    protected int Quantite { get; set; } = quantite;

    public override string ToString() => $"Nom : {Nom}, Prix : {Prix} €, Quantité : {Quantite}";

    public void Afficher()
    {
        Console.WriteLine(ToString());
    }

    public void Ajouter(int quantite)
    {
        if (quantite > 0)
            Quantite += quantite;
    }

    public void Retirer(int quantite)
    {
        if (quantite > 0 && Quantite >= quantite)
            Quantite -= quantite;
    }
}