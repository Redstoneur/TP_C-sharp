namespace TP3;

class Livre(string nom, double prix, int quantite, bool isBn, int nbPages)
    : ArticleType(nom, prix, quantite, TypeArticle.Papeterie), IRentable
{
    protected bool IsBn { get; set; } = isBn;
    protected int NbPages { get; set; } = nbPages;

    public double CalculateRent()
    {
        const double rent = 0.05;
        return Delegate.Calcule(Prix, rent, 4);
    }

    public override string ToString() => base.ToString() + $", IsBn : {IsBn}, NbPages : {NbPages}";

    public new void Afficher()
    {
        Console.WriteLine(ToString());
    }

    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($" - ISBN : {IsBn}");
        Console.WriteLine($" - Nombre de pages : {NbPages}");
    }
}