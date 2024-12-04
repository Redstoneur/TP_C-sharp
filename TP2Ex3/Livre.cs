﻿namespace TP2Ex3;

/// <summary>
/// Représente un livre qui est louable.
/// </summary>
/// <param name="nom">Le nom du livre.</param>
/// <param name="prix">Le prix du livre.</param>
/// <param name="quantite">La quantité du livre.</param>
/// <param name="isBn">Indique si le livre a un ISBN.</param>
/// <param name="nbPages">Le nombre de pages du livre.</param>
class Livre(string nom, double prix, int quantite, bool isBn, int nbPages)
    : ArticleType(nom, prix, quantite, TypeArticle.Papeterie), IRentable
{
    /// <summary>
    /// Obtient ou définit une valeur indiquant si le livre a un ISBN.
    /// </summary>
    protected bool IsBn { get; set; } = isBn;

    /// <summary>
    /// Obtient ou définit le nombre de pages du livre.
    /// </summary>
    protected int NbPages { get; set; } = nbPages;

    /// <summary>
    /// Calcule le loyer du livre.
    /// </summary>
    /// <returns>Le montant du loyer, qui est de 5% du prix.</returns>
    public double CalculateRent()
    {
        const double rent = 0.05;
        return Delegate.Calcule(Prix, rent, 4);
    }

    /// <summary>
    /// Retourne une chaîne qui représente le livre actuel.
    /// </summary>
    /// <returns>Une chaîne qui représente le livre actuel.</returns>
    public override string ToString() => base.ToString() + $", IsBn : {IsBn}, NbPages : {NbPages}";

    /// <summary>
    /// Affiche les détails de l'article sur la console.
    /// </summary>
    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($" - ISBN : {IsBn}");
        Console.WriteLine($" - Nombre de pages : {NbPages}");
    }
}