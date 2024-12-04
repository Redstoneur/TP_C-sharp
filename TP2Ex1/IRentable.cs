namespace TP2Ex1;

/// <summary>
/// Interface représentant un élément louable.
/// </summary>
interface IRentable
{
    /// <summary>
    /// Calcule le loyer de l'élément.
    /// </summary>
    /// <returns>Le montant du loyer en tant que double.</returns>
    double CalculateRent();
}