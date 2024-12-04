namespace TP1;

using System;

/// <summary>
/// Représente un article avec un nom, un prix et une quantité.
/// </summary>
/// <param name="nom">Le nom de l'article.</param>
/// <param name="prix">Le prix de l'article.</param>
/// <param name="quantite">La quantité de l'article.</param>
public class Article(string? nom, double prix, int quantite)
{
    /// <summary>
    /// Obtient le nom de l'article.
    /// </summary>
    protected string? Nom { get; } = nom;

    /// <summary>
    /// Obtient le prix de l'article.
    /// </summary>
    protected double Prix { get; } = prix;

    /// <summary>
    /// Obtient ou définit la quantité de l'article.
    /// </summary>
    protected int Quantite { get; set; } = quantite;

    /// <summary>
    /// Retourne une chaîne qui représente l'article actuel.
    /// </summary>
    /// <returns>Une chaîne qui représente l'article actuel.</returns>
    public override string ToString() => $"Nom : {Nom}, Prix : {Prix} €, Quantité : {Quantite}";

    /// <summary>
    /// Affiche les informations de l'article dans la console.
    /// </summary>
    public void Afficher()
    {
        Console.WriteLine(ToString());
    }

    /// <summary>
    /// Ajoute la quantité spécifiée à l'article.
    /// </summary>
    /// <param name="quantite">La quantité à ajouter.</param>
    public void Ajouter(int quantite)
    {
        if (quantite > 0)
            Quantite += quantite;
    }

    /// <summary>
    /// Supprime la quantité spécifiée de l'article.
    /// </summary>
    /// <param name="quantite">La quantité à supprimer.</param>
    public void Retirer(int quantite)
    {
        if (quantite > 0 && Quantite >= quantite)
            Quantite -= quantite;
    }
}