namespace TP3;

public static class Delegate
{
    private static double Somme(double i, double j) => i + j;
    private static double Multiplication(double i, double j) => i * j;
    private static double Soustraction(double i, double j) => i - j;

    private static double Division(double i, double j) => i / j;

    private static double Reduction(double i, double j) => i - (i * j);

    private delegate double DelegateCalcule(double i, double j);

    private static DelegateCalcule[] rem = [Somme, Multiplication, Soustraction, Division, Reduction];

    public static double Calcule(double i, double j, int met) => rem[met](i, j);
}