namespace ConsoleApp1;

public class Liczba
{
    private char[] tablica = new char[1];

    public Liczba(string liczbaS)
    {
        tablica = liczbaS.ToCharArray();
    }

    public void Show()
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i]);
        }

        Console.WriteLine();
    }

    public void Mnożenie(int n)
    {
        string liczbaS = "";
        for (int i = 0; i < tablica.Length; i++)
        {
            liczbaS = liczbaS + tablica[i];
        }

        float liczbaD = float.Parse(liczbaS);
        liczbaD = n * liczbaD;
        liczbaS = liczbaD.ToString();
        tablica = liczbaS.ToCharArray();
    }

    public int Silnia(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * Silnia(n - 1);
        }

    }
}