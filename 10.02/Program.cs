/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии. */

System.Console.WriteLine("--> ");

int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

string Function (int a, int n)
{
    
    if (a <= n) return Function(a + 1, n) + $"{a} ";
    else return String.Empty;
}
System.Console.WriteLine(Function(a, n));