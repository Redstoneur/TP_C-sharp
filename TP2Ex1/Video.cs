namespace TP2Ex1;

class Video(string nom, double prix, int quantite, double duree) : Article(nom, prix, quantite), IRentable
{
    protected double Duree { get; set; } = duree;
    
    public double CalculateRent()
    {
        return base.Prix * 0.1; // Exemple : 10% du prix
    }

    public override string ToString() => $"Nom : {Nom}, Prix : {Prix} €, Quantité : {Quantite}, Durée : {Duree} minutes";
    
    public new void Afficher()
    {
        Console.WriteLine(ToString());
    }
}