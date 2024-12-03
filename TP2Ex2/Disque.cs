namespace TP2Ex2;

class Disque(string nom, double prix, int quantite, string label) : Article(nom, prix, quantite)
{
    protected string Label { get; set; } = label;
    
    public override string ToString() => $"Nom : {Nom}, Prix : {Prix} €, Quantité : {Quantite}, Label : {Label}";
    
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