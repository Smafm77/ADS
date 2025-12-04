using System.Globalization;

public class Aufgabe31
{

    public static void Array()
    {
        int[][,] array = new int[5][,];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new int[6, 7];
            Console.Write(array[i] + " Wert: [ ");
            for (int j = 0; j < array[i].GetLength(0); j++)
            {
                for (int k = 0; k < array[i].GetLength(1); k++)
                {
                    int wert = i * 10000 + j * 100 + k;
                    array[i][j, k] = wert;
                    Console.Write(array[i][j, k] + " ");
                }
            }
                  Console.WriteLine(" ]");

        }
    }
}