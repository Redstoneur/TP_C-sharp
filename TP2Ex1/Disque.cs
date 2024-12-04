namespace TP2Ex1;

class Disque(string nom, double prix, int quantite, string label)
    : ArticleType(nom, prix, quantite, TypeArticle.Multimédia)
{
    protected string Label { get; set; } = label;

    public override string ToString() => base.ToString() + $", Label : {Label}";

    public new void Afficher()
    {
        Console.WriteLine(ToString());
    }
}