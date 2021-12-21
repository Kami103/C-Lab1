namespace ConsoleApp1;

public class Sumator
{
    private int[] Liczby =
    {
        2, 3, 4, 5, 6, 7, 8
    };

    public Sumator()
    {
    }


    public int Suma()
    {
        int suma = 0;
        for (int i = 0; i < Liczby.Length; i++)
        {
            suma += Liczby[i];
        }

        return suma;
    }

    public int SumaPodziel2()
    {
        int suma = 0;
        for (int i = 0; i < Liczby.Length; i++)
        {
            if (Liczby[i] % 2 == 0)
            {
                suma += Liczby[i];
            }
        }

        return suma;
    }

    public int IleElementow()
    {
        return Liczby.Length;
    }

    public void Wypisz()
    {
        int suma = 0;
        Console.Write("{ ");
        for (int i = 0; i < Liczby.Length; i++)
        {
            Console.Write(Liczby[i]+" ");
        }
        Console.Write("}\n");
    }

    public void Wypisz(int low, int high)
    {
        if (low > high || high > Liczby.Length || low <= 0)
        {
            Console.WriteLine("nie mozna tak");
        }
        else
        {
            Console.Write("{ ");
            for (int i = low; i <= high; i++)
            {
                Console.Write(Liczby[i-1]+" ");
            }
            
            Console.Write("}\n");
        }
    }
}