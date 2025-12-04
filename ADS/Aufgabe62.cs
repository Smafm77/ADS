public class Aufgabe62
{
    public float[] Convert1(object[,] arr)
    {
        int anzahl = arr.Length;
        float[] eindim = new float[anzahl];
        int i = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                switch (arr[j, k])
                {
                    case float float_element:
                        eindim[i] = float_element;
                        i++;
                        break;
                    case int int_element:
                        if (int_element >= 0)
                        {
                            eindim[i] = (float)(int_element + 0.5);
                            i++;
                            break;
                        }
                        eindim[i] = (float)(int_element - 0.6);
                        i++;
                        break;
                    case string string_element:
                        eindim[i] = 0;
                        i++;
                        break;
                    default:
                        eindim[i] = 100;
                        i++;
                        break;
                }
            }
        }
        return eindim;
    }
    public float[] Convert2(object[][] arr)
    {
        int anzahl = 0;
        for (int x = 0; x < arr.Length; x++)
        {
            anzahl += arr[x].Length;
        }
        float[] eindim = new float[anzahl];
        int i = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            for (int k = 0; k < arr[j].Length; k++)
            {
                switch (arr[j][k])
                {
                    case float float_element:
                        eindim[i] = float_element;
                        i++;
                        break;
                    case int int_element:
                        if (int_element >= 0)
                        {
                            eindim[i] = (float)(int_element + 0.5);
                            i++;
                            break;
                        }
                        eindim[i] = (float)(int_element - 0.6);
                        i++;
                        break;
                    case string string_element:
                        eindim[i] = 0;
                        i++;
                        break;
                    default:
                        eindim[i] = 100;
                        i++;
                        break;
                }
            }
        }
        return eindim;
    }
}