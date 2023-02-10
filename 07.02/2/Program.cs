/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов. */
System.Console.WriteLine("Введите размер массива ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, m];
int min = int.MaxValue;
int line = 0;

System.Console.WriteLine("Массив: ");
RandomArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < min) {
        min = sum;
        line++;
    }
}

System.Console.WriteLine(" \nМинимальная сумма " + min + " в строке: " + line);
void RandomArray(int[,] array)
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
        System.Console.WriteLine("");
        System.Console.Write("(");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.Write(")");
    }

}
