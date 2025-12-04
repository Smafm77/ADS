public class EnumAufgabe
{
    [Flags]
    public enum Monate
    {
        Januar = 0b_0000_0000_0001, //1
        Februar = 0b_0000_0000_0010, //2
        Maerz = 0b_0000_0000_0100, //4
        April = 0b_0000_0000_1000, //8
        Mai = 0b_0000_0001_0000, //16
        Juni = 0b_0000_0010_0000, //32
        July = 0b_0000_0100_0000, //64
        August = 0b_0000_1000_0000, //128
        September = 0b_0001_0000_0000, //256
        Oktober = 0b_0010_0000_0000, //512
        November = 0b_0100_0000_0000, //1024
        Dezember = 0b_1000_0000_0000 //2048
    }
  
}