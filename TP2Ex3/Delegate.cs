namespace TP2Ex3;

/// <summary>
/// A static class containing various mathematical operations.
/// </summary>
public static class Delegate
{
    /// <summary>
    /// Adds two double values.
    /// </summary>
    /// <param name="i">The first value.</param>
    /// <param name="j">The second value.</param>
    /// <returns>The sum of the two values.</returns>
    private static double Somme(double i, double j) => i + j;

    /// <summary>
    /// Multiplies two double values.
    /// </summary>
    /// <param name="i">The first value.</param>
    /// <param name="j">The second value.</param>
    /// <returns>The product of the two values.</returns>
    private static double Multiplication(double i, double j) => i * j;

    /// <summary>
    /// Subtracts the second double value from the first.
    /// </summary>
    /// <param name="i">The first value.</param>
    /// <param name="j">The second value.</param>
    /// <returns>The difference between the two values.</returns>
    private static double Soustraction(double i, double j) => i - j;

    /// <summary>
    /// Divides the first double value by the second.
    /// </summary>
    /// <param name="i">The first value.</param>
    /// <param name="j">The second value.</param>
    /// <returns>The quotient of the two values.</returns>
    private static double Division(double i, double j) => i / j;

    /// <summary>
    /// Reduces the first double value by a percentage of the second.
    /// </summary>
    /// <param name="i">The first value.</param>
    /// <param name="j">The percentage to reduce by.</param>
    /// <returns>The reduced value.</returns>
    private static double Reduction(double i, double j) => i - (i * j);

    /// <summary>
    /// Delegate for mathematical operations.
    /// </summary>
    /// <param name="i">The first value.</param>
    /// <param name="j">The second value.</param>
    /// <returns>The result of the operation.</returns>
    private delegate double DelegateCalcule(double i, double j);

    /// <summary>
    /// Array of delegates for mathematical operations.
    /// </summary>
    private static DelegateCalcule[] rem = { Somme, Multiplication, Soustraction, Division, Reduction };

    /// <summary>
    /// Performs a mathematical operation based on the specified method index.
    /// </summary>
    /// <param name="i">The first value.</param>
    /// <param name="j">The second value.</param>
    /// <param name="met">The index of the method to use (0: Somme, 1: Multiplication, 2: Soustraction, 3: Division, 4: Reduction).</param>
    /// <returns>The result of the operation.</returns>
    public static double Calcule(double i, double j, int met) => rem[met](i, j);
}