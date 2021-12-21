using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wybierz nr zadania:");
        int nr =Int16.Parse(Console.ReadLine());
        Console.Clear();
        switch (nr)
        {
            case 1:
                Zadanie1();
                break;
            case 2:
                Zadanie2();
                break;
            case 3:
                Zadanie3();
                break;
            case 4:
                Zadanie4();
                break;
            default:
                Console.WriteLine("Zły numer.");
                break;
        }
    }
    public static void Zadanie1()
    {
        Console.WriteLine("Zadanie nr 1");
        Console.WriteLine("------------");
        Licz l1 = new Licz(5);
        l1.Wypisz();
        Console.WriteLine("liczba + 5: " + l1.Dodaj(5));
        Console.WriteLine("liczba  - 3: " + l1.Odejmij(3));
    }
    public static void Zadanie2()
    {
        Console.WriteLine("Zadanie nr 2");
        Console.WriteLine("------------");
        Sumator s1 = new Sumator();
        s1.Wypisz();
        Console.WriteLine("suma: " + s1.Suma());
        Console.WriteLine("suma elementów podzielnych przez 2: " + s1.SumaPodziel2());
        Console.WriteLine("ilość elementów: " + s1.IleElementow());
        Console.WriteLine("tablica z zakresu <3,7> ");
        s1.Wypisz(3, 6);
        Console.WriteLine("tablica z zakresu <6,2> ");
        s1.Wypisz(6, 2);
        Console.WriteLine("tablica z zakresu <0,3> ");
        s1.Wypisz(0, 6);
        Console.WriteLine("tablica z zakresu <3,9> ");
        s1.Wypisz(3, 9);
    }
    public static void Zadanie3()
    {
        Console.WriteLine("Zadanie nr 3");
        Console.WriteLine("------------");
        Console.WriteLine("Próba ustawinia daty na 30.4.2011:");
        Data d1 = new Data(30, 4, 2011);
        d1.ShowData();
        Console.WriteLine("Próba ustawinia daty na 31.4.2011:");
        d1.SetDay(31);
        d1.ShowData();
        Console.WriteLine("Próba ustawinia daty na 19.4.2011:");
        d1.SetDay(19);
        d1.ShowData();
        Console.WriteLine("Próba ustawinia daty na 19.16.2011:");
        d1.SetMonth(16);
        d1.ShowData();
        Console.WriteLine("Próba ustawinia daty na 19.6.2011:");
        d1.SetMonth(6);
        d1.ShowData();
        Console.WriteLine("Próba ustawinia daty na 19.6.2021:");
        d1.SetYear(2021);
        d1.ShowData();
        Console.WriteLine("Próba ustawinia daty na 19.6.2021:");
        d1.SetYear(-2001);
        d1.ShowData();
        Console.WriteLine("Próba ustawinia daty na 29.12.2021:");
        Data d2 = new Data(29, 12, 2021);
        d2.ShowData();
        Console.WriteLine("Tydzień do przodu:");
        d2.NextWeek();
        d2.ShowData();
        Console.WriteLine("Tydzień do tyłu:");
        d2.PreviousWeek();
        d2.ShowData();
        Console.WriteLine("Próba ustawinia daty na 24.2.2001:");
        Data d3 = new Data(24, 2, 2001);
        Console.WriteLine("Tydzień do przodu:");
        d3.NextWeek();
        d3.ShowData();
        Console.WriteLine("Tydzień do tyłu:");
        d3.PreviousWeek();
        d3.ShowData();
    }
    public static void Zadanie4()
    {
        Console.WriteLine("Zadanie nr 4");
        Console.WriteLine("------------");
        Console.WriteLine("liczba:");
        Liczba l1 = new Liczba("123.42245");
        l1.Show();
        Console.WriteLine("liczba * 6:");
        l1.Mnożenie(6);
        l1.Show();
        Console.WriteLine("Silnia 3: " + l1.Silnia(3));
    }
}