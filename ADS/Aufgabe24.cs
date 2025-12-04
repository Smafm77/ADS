public class TupelAufgabe
{

    public static (String Name, int Age) AltersVergleich((String Name, int Age) t1, (String Name, int Age) t2)
    {
        if (t2.Age < t1.Age)
        {
            return t1;
        }
        else if (t1.Age < t2.Age)
        {
            return t2;
        }
        else
        {
            (String Name, int Age) t3 = (t1.Name + " und " + t2.Name, t1.Age);
            return t3;
        }
    }

}