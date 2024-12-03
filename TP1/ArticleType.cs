namespace TP1;

using System;

public enum TypeArticle
{
    Alimentaire,
    Droguerie,
    Habillement,
    Loisir
}

public class ArticleType(string? nom, double prix, int quantite, TypeArticle typeArticle)
{
    private string? Nom { get; } = nom;
    private double Prix { get; } = prix;
    private int Quantite { get; set; } = quantite;

    private TypeArticle Type { get; } = typeArticle;

    public void Afficher()
    {
        Console.WriteLine($"Nom : {Nom}, Prix : {Prix} €, Quantité : {Quantite}, Type : {Type}");
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