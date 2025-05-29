using System.Numerics;
public class Program {

    delegate double ObliczPierwiastek(double x, double y);
    delegate double ObliczPotege(double x, double y);

    private static void Main(string[] args) {
        //zadanie 1
        ObliczPierwiastek pierwiastek = delegate (double x, double y)
        {
            return Math.Pow(x, y / 3);
        };
        Console.WriteLine(pierwiastek(3, 4));
        ObliczPotege pot = delegate (double x, double y)
        {
            return Math.Pow(x, y);
        };
        Console.WriteLine(pot(2, 5));

        //zadanie 2
        Console.WriteLine(PoleRombu(1, 4));
        Console.WriteLine(PoleRombu(1.2,4.2));

        //zadanie 3
        Console.WriteLine(WpiszWKonsoli("12"));
        Console.WriteLine(WpiszWKonsoli(12));

        //zadanie 4
        Console.WriteLine(ObliczPoteg(2, 5));
        Console.WriteLine(ObliczPoteg(2.5, 5.5));

    }
    //zadanie 2
    public static T PoleRombu<T>(T a, T h) where T : INumber<T>
    {
        return a * h;
    }

    //zadanie 3
    public static T WpiszWKonsoli<T>(T wpisz)
    {
        return wpisz;
    }

    //zadanie 4
    static double ObliczPoteg<T1, T2>(T1 a, T2 b)
    {
        double podstawa = Convert.ToDouble(a);
        double wykladnik = Convert.ToDouble(b);

        return Math.Pow(podstawa, wykladnik);
    }
}