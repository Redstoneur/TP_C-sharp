namespace TP2Ex3;

/// <summary>
/// Représente un article vidéo qui peut être loué.
/// </summary>
/// <param name="nom">Le nom de la vidéo.</param>
/// <param name="prix">Le prix de la vidéo.</param>
/// <param name="quantite">La quantité de la vidéo.</param>
/// <param name="duree">La durée de la vidéo.</param>
class Video(string nom, double prix, int quantite, double duree)
    : ArticleType(nom, prix, quantite, TypeArticle.Multimédia), IRentable
{
    /// <summary>
    /// Obtient ou définit la durée de la vidéo.
    /// </summary>
    protected double Duree { get; set; }

    /// <summary>
    /// Calcule le prix de location de la vidéo.
    /// </summary>
    /// <returns>Le prix de location de la vidéo.</returns>
    public double CalculateRent()
    {
        const double rent = 0.1;
        return Delegate.Calcule(Prix, rent, 4);
    }

    /// <summary>
    /// Retourne une chaîne qui représente la vidéo actuelle.
    /// </summary>
    /// <returns>Une chaîne qui représente la vidéo actuelle.</returns>
    public override string ToString() => base.ToString() + $", Duree : {Duree}";

    /// <summary>
    /// Affiche les détails de l'article sur la console.
    /// </summary>
    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($" - Durée : {Duree} minutes");
    }
}