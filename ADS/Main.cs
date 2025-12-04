namespace ADS
{
    public class ADS
    {

        static void Main()
        {
            /*
            (String Name, int Age) p1 = (Name: "Max", Age: 20);
            (String Name, int Age) p2 = (Name: "Moritz", Age: 23);
            (String Name, int Age) p3 = (TupelAufgabe.AltersVergleich(p1, p2));

            EnumAufgabe.Monate summer = (EnumAufgabe.Monate)32 + 64 + 128;
            EnumAufgabe.Monate free = (EnumAufgabe.Monate)128 + 256 + 512;
            EnumAufgabe.Monate summerFree = summer & free;
            EnumAufgabe.Monate niceMonths = summer | free;

            Aufgabe26.Person p4 = new Aufgabe26.Person("Max", 20, "Mustermann Straße 15");
            Aufgabe26.Person p5 = p4;
            p1.Name = "Moritz";
            p2.Age = 23;
            Console.WriteLine($"{p4}");
            Console.WriteLine($"{p5}");
            Aufgabe31.Array();
            Fraction fraction = new Fraction(8, 4);
            Console.WriteLine(fraction.ToString());
            fraction.ShortenFraction();
            Console.WriteLine(fraction.ToString());
            */

            /* 
            Schreiben Sie eine Klasse Test, die das Interface IElementWithKey implementiert und erzeugen Sie 10 Objekte
            mit ChangeableKey von 1 bis 10. Testen Sie damit die Methoden ExtractFirst, Insert und verändern Sie die
            ChangeableKeys um IncreaseKey zu testen.
            */
            var minpq = new MinPriorityQueue<Test>(20);
            Console.WriteLine(minpq.ToString());
            for (int i = 1; i <= 10; i++)
            {
                minpq.Insert(new Test(i, i));
                Console.WriteLine(minpq.ToString());
            }

            minpq.ExtractFirst();
            Console.WriteLine(minpq.ToString());
            Test tmin = new(11, 11);
            minpq.Insert(tmin);
            Console.WriteLine(minpq.ToString());
            tmin.ChangeableKey = 1;
            Console.WriteLine(minpq.ToString());

            var maxpq = new MaxPriorityQueue<Test>(20);
            Console.WriteLine(maxpq.ToString());
            for (int i = 1; i <= 10; i++)
            {
                maxpq.Insert(new Test(i, i));
                Console.WriteLine(maxpq.ToString());
            }

            maxpq.ExtractFirst();
            Console.WriteLine(maxpq.ToString());
            Test tmax = new(11, 11);
            maxpq.Insert(tmax);
            Console.WriteLine(maxpq.ToString());
            tmax.ChangeableKey = 12;
            Console.WriteLine(maxpq.ToString());


        }
    }
}