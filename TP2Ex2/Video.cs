namespace TP2Ex2;

/// <summary>
/// Représente un article vidéo qui peut être loué.
/// </summary>
class Video : ArticleType, IRentable
{
    /// <summary>
    /// Obtient ou définit la durée de la vidéo.
    /// </summary>
    protected double Duree { get; set; }

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="Video"/>.
    /// </summary>
    /// <param name="nom">Le nom de la vidéo.</param>
    /// <param name="prix">Le prix de la vidéo.</param>
    /// <param name="quantite">La quantité de la vidéo.</param>
    /// <param name="duree">La durée de la vidéo.</param>
    public Video(string nom, double prix, int quantite, double duree)
        : base(nom, prix, quantite, TypeArticle.Multimédia)
    {
        Duree = duree;
    }

    /// <summary>
    /// Calcule le prix de location de la vidéo.
    /// </summary>
    /// <returns>Le prix de location de la vidéo.</returns>
    public double CalculateRent()
    {
        return Prix * 0.1; // Exemple : 10% du prix
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