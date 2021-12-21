namespace ConsoleApp1;

public class Data
{
    private int day;
    private int month;

    private string[] monthName = new string[]
    {
        "Styczeń",
        "Luty",
        "Marzec",
        "Kwiecień",
        "Maj",
        "Czerwiec",
        "Lipiec",
        "Sierpień",
        "Wrzesień",
        "Październik",
        "Listopad",
        "Grudzień"
    };

    private int[] DaysOf = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    private int year;

    public Data(int day, int month, int year)
    {
        if (month < 1 || month > 12 || day < 1)
        {
            Console.WriteLine("Nieprawidłowa data");
        }
        else if (DaysOf[month - 1] < day)
        {
            Console.WriteLine(monthName[month - 1] + " nie ma " + day + " dni");
        }
        else
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }

    public Data()
    {
        this.day = 1;
        this.month = 1;
        this.year = 2022;
    }

    public void SetDay(int day)
    {
        if (day < 0 || day > DaysOf[this.month - 1])
        {
            Console.WriteLine(monthName[this.month - 1] + " nie ma " + day + " DNI");
        }
        else
        {
            this.day = day;
        }
    }

    public void SetMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Nie ma takiego miesiąca");
        }
        else if (day > DaysOf[month - 1])
        {
            Console.WriteLine(monthName[month - 1] + " nie ma " + day + " DNI");
        }
        else
        {
            this.month = month;
        }
    }

    public void SetYear(int year)
    {
        if (year <= 0)
        {
            Console.WriteLine("Nieprawidłowa data");
        }
        else
        {
            this.year = year;
        }
    }

    public void NextWeek()
    {
        if (this.day + 7 > DaysOf[this.month - 1])
        {
            if (this.month == 12)
            {
                this.day = 7 - (DaysOf[this.month - 1] - this.day);
                this.month = 1;
                this.year++;
            }
            else
            {
                this.day = 7 - (DaysOf[this.month - 1] - this.day);
                this.month++;
            }
        }
        else
        {
            this.day = this.day + 7;
        }
    }

    public void PreviousWeek()
    {
        if (this.day < 8)
        {
            if (this.month == 1)
            {
                this.day = -(this.day - DaysOf[this.month - 1]);
                this.month = 12;
                this.year--;
            }
            else
            {
                this.day = DaysOf[this.month - 2] - (7 - this.day);
                this.month--;
            }
        }
        else
        {
            this.day = this.day - 7;
        }
    }

    public void ShowData()
    {
        Console.WriteLine(day + " " + monthName[month - 1] + " " + year);
    }
}