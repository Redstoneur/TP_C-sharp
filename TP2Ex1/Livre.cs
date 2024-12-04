namespace TP2Ex1;

class Livre(string nom, double prix, int quantite, bool isBn, int nbPages)
    : ArticleType(nom, prix, quantite, TypeArticle.Papeterie), IRentable
{
    protected bool IsBn { get; set; } = isBn;
    protected int NbPages { get; set; } = nbPages;

    public double CalculateRent()
    {
        return Prix * 0.05; // Exemple : 5% du prix
    }

    public override string ToString() => base.ToString() + $", IsBn : {IsBn}, NbPages : {NbPages}";

    public new void Afficher()
    {
        Console.WriteLine(ToString());
    }
}