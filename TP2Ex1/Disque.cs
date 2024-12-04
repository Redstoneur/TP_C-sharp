namespace TP2Ex1;

/// <summary>
/// Représente un disque avec un nom, un prix, une quantité et un label.
/// </summary>
/// <param name="nom">Le nom du disque.</param>
/// <param name="prix">Le prix du disque.</param>
/// <param name="quantite">La quantité du disque.</param>
/// <param name="label">Le label du disque.</param>
class Disque(string nom, double prix, int quantite, string label)
    : ArticleType(nom, prix, quantite, TypeArticle.Multimédia)
{
    /// <summary>
    /// Obtient ou définit le label du disque.
    /// </summary>
    protected string Label { get; set; } = label;

    /// <summary>
    /// Retourne une chaîne qui représente l'objet actuel.
    /// </summary>
    /// <returns>Une chaîne qui représente l'objet actuel.</returns>
    public override string ToString() => base.ToString() + $", Label : {Label}";
    
}