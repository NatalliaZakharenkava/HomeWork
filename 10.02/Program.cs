/*  Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.  */

 System.Console.WriteLine("--> ");

int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

string Function (int a, int n)
{
    
    if (a <= n) return Function(a + 1, n) + $"{a} ";
    else return String.Empty;
}
System.Console.WriteLine(Function(a, n)); 

/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */

/* System.Console.WriteLine("Введите первое число: ");

int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");

int n = Convert.ToInt32(Console.ReadLine());

int ResultSum(int m, int n)
{
   if (m == n) return n;
   else return n + ResultSum(m, n - 1);
}
System.Console.WriteLine(ResultSum(m, n)); */

/* Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n. */


/*      System.Console.WriteLine("Введите первое число: ");
     int m = Convert.ToInt32(Console.ReadLine());
     System.Console.WriteLine("Введите второе число: ");
     int n = Convert.ToInt32(Console.ReadLine());

     int Function(int m, int n)
     {
        if (n == 0) return Function(m - 1, 1);
        else if (m == 0) return n + 1;
        else return Function(m - 1, Function(m, n - 1));
     }
     System.Console.WriteLine(Function(m, n)); */