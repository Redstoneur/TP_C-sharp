namespace TP2Ex3;

class Video(string nom, double prix, int quantite, TypeArticle type, double duree)
    : ArticleType(nom, prix, quantite, type), IRentable
{
    protected double Duree { get; set; } = duree;

    public double CalculateRent()
    {
        const double rent = 0.1;
        return Delegate.Calcule(Prix, rent, 4);
    }

    public override string ToString() => base.ToString() + $", Duree : {Duree}";

    public new void Afficher()
    {
        Console.WriteLine(ToString());
    }

    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($" - Durée : {Duree} minutes");
    }
}