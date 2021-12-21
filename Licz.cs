namespace ConsoleApp1;

public class Licz
{
    public float wartosc;

    public Licz()
    {
        wartosc = 0;
    }

    public Licz(float wartosc)
    {
        this.wartosc = wartosc;
    }

    public float Dodaj(float a)
    {
        return wartosc += a;
    }

    public float Odejmij(float a)
    {
        return wartosc -= a;
    }

    public void Wypisz()
    {
        Console.WriteLine("liczba: " + this.wartosc);
    }
}