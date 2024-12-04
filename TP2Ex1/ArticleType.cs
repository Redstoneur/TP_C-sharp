﻿namespace TP2Ex1;

using System;

/// <summary>
/// Représente un type d'article qui hérite de la classe Article.
/// </summary>
/// <param name="nom">Le nom de l'article.</param>
/// <param name="prix">Le prix de l'article.</param>
/// <param name="quantite">La quantité de l'article.</param>
/// <param name="typeArticle">Le type de l'article.</param>
public class ArticleType(string? nom, double prix, int quantite, TypeArticle typeArticle) : Article(nom, prix, quantite)
{
    /// <summary>
    /// Obtient le type de l'article.
    /// </summary>
    protected TypeArticle Type { get; } = typeArticle;

    /// <summary>
    /// Retourne une chaîne qui représente l'objet actuel.
    /// </summary>
    /// <returns>Une chaîne qui représente l'objet actuel.</returns>
    public override string ToString() => base.ToString() + $", Type : {Type}";
    
}