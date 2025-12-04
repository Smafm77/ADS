public class Aufgabe26
{
    public struct Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public String Adress { get; set; }
        public Person(String name, int age, String adress)
        {
            Name = name;
            Age = age;
            Adress = adress;
        }
        public override string ToString()
        {
            return $"({Name},{Age},{Adress})";
        }
    }
}
  