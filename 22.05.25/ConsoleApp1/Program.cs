/* Co to są metedy generyczne?
   metoda generyczna jest to metoda, która działa na typie określonym w momencie wywołania metody. 
   nie musimy pisać osobnych wersji metody dla różnych typów danych. - wystarczy jedna metoda z parametrem
   typu ogólnego.

   składnia metody generycznej

    public T Metoda<T>(T parametr)
    {
        // coś z tym parametram robimy
        return parametr;
    }
    T - to tzw. parametr typu
    Może być więcej niż jeden <T1, T2> np. w słownikach
    można też ograniczyć (where)

    ograniczenia (where) 
    mówią co musi spełniać T. przykłady:
    Ograniczenie            Opis
    where T : class         tylko klasy (nie struktury)
    where T : struct        tylko typy wartościowe
    where T : new()         musi mieć publiczny konstruktor bezparametrowy
    where T : Baza          musi dziedziczyć po klasie Baza
    where T : interface     musi implementować dany interfejs
    
    Zalety metod generycznych:
    Elastyczność - jedna metoda działa na różnych typach danych
    Bezpieczeństwo typów - błąd wykryty przy kompilacji
    Wydajność - nie ma rzutowania ani boxingu
    reużywalność - kod łatwy w utrzymaniu

 */
using System.ComponentModel;
using System.Reflection.Metadata;

public class Program
{
    static void Main(string[] args)
    {
        int x=5, y = 10;
        ZmianBezGeneryka(x, y);
        Console.WriteLine($"{x},{y}");

        Zamien(ref x, ref y);
        Console.WriteLine($"{x}, {y}");

        string a = "Ola", b= "Ala";
        Zamien(ref a, ref b);
        Console.WriteLine($"{a}, {b}");
        
        Console.WriteLine(MaksiumBezGeneryka(10, 50));
        Console.WriteLine("Ala", "Ola");
        Console.WriteLine(Maksimum(ref x, ref y));
        WyswietlTypy("abc", 127);

    }
    static void ZmianBezGeneryka(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public static void Zamien<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    static int MaksiumBezGeneryka(int a, int b)
    {
        return a.CompareTo(b) >=0 ? a : b;
    }
    static T Maksimum<T>(ref T a, ref T b) where T : IComparable<T>
    {
        return a.CompareTo(b) >= 0 ? a : b;

    }
    // uwaga: bez where T : IComparable<T> funkcja nie wiedziała by jak porównać dwa obiekty do kolejnego typu
    public static void WyswietlTypy<T1, T2>(T1 a, T2 b)
    {
        Console.WriteLine($"a: {a} ({typeof(T1)})");
        Console.WriteLine($"a: {b} ({typeof(T2)})");

    }
}