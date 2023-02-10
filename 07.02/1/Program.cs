int[,] array = new int[3, 4];

RandomNumbers(array);
System.Console.WriteLine();
PrintArray(array);


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int l = 0; l < array.GetLength(1) - 1; l++)
        {
            if (array[i, l] < array[i, l + 1]) {
                int buf = 0;
                buf = array[i, l];
                array[i, l] = array[i, l + 1];
                array[i, l + 1] = buf;
            }
        }
    }
}

System.Console.WriteLine();
PrintArray(array);

void RandomNumbers (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine("");
    }
}