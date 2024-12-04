﻿namespace TP3;

using System;

public class Article(string? nom, double prix, int quantite): Publication
{
    public string? Nom { get; } = nom;
    public double Prix { get; } = prix;
    public int Quantite { get; protected set; } = quantite;

    public override string ToString() => $"Nom : {Nom}, Prix : {Prix} €, Quantité : {Quantite}";

    public void Afficher()
    {
        Console.WriteLine(ToString());
    }

    public void Ajouter(int quantite)
    {
        if (quantite > 0)
            Quantite += quantite;
    }

    public void Retirer(int quantite)
    {
        if (quantite > 0 && Quantite >= quantite)
            Quantite -= quantite;
    }
    
    public override void PublishDetails()
    {
        Console.WriteLine($"Nom : {Nom} :");
        Console.WriteLine($" - Prix : {Prix} €");
        Console.WriteLine($" - Quantité : {Quantite}");
    }
}