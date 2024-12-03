namespace TP2Ex1;

class Disque(string nom, double prix, int quantite, TypeArticle type, string label)
    : ArticleType(nom, prix, quantite, type)
{
    protected string Label { get; set; } = label;

    public override string ToString() => base.ToString() + $", Label : {Label}";

    public new void Afficher()
    {
        Console.WriteLine(ToString());
    }
}