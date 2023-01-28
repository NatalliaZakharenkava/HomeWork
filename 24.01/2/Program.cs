System.Console.WriteLine("--> ");

int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
   int Sum(int n, int sum) 
   {  while (n > 0) {
        sum += n % 10;
        n /= 10;
    }
    return sum;
    };

  sum = Sum(n, sum);

System.Console.WriteLine("сумма " + sum);

