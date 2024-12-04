namespace TP2Ex3;

class Disque(string nom, double prix, int quantite, string label)
    : ArticleType(nom, prix, quantite, TypeArticle.Multimédia)
{
    protected string Label { get; set; } = label;
    
    public override string ToString() => base.ToString() + $", Label : {Label}";
    
    public new void Afficher()
    {
        Console.WriteLine(ToString());
    }
    
    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($" - Label : {Label}");
        
    }
}