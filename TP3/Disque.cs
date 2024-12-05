namespace TP3;

/// <summary>
/// Représente un disque avec un nom, un prix, une quantité et un label.
/// </summary>
class Disque : ArticleType
{
    /// <summary>
    /// Obtient ou définit le label du disque.
    /// </summary>
    protected string Label { get; set; }

    /// <summary>
    /// Constucteur de la classe Disque.
    /// </summary>
    /// <param name="nom">Le nom du disque.</param>
    /// <param name="prix">Le prix du disque.</param>
    /// <param name="quantite">La quantité du disque.</param>
    /// <param name="label">Le label du disque.</param>
    public Disque(string nom, double prix, int quantite, string label)
        : base(nom, prix, quantite, TypeArticle.Multimédia)
    {
        Label = label;
    }

    /// <summary>
    /// Retourne une chaîne qui représente l'objet actuel.
    /// </summary>
    /// <returns>Une chaîne qui représente l'objet actuel.</returns>
    public override string ToString() => base.ToString() + $", Label : {Label}";

    /// <summary>
    /// Affiche les détails de l'article sur la console.
    /// </summary>
    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($" - Label : {Label}");
    }
}