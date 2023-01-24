System.Console.WriteLine("Введите первое число ");

int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число ");

int b = Convert.ToInt32(Console.ReadLine());

int local(int a, int b) {
    int result = 1;
    for (int i = 1; i <= b; i++) {
        result = result * a;
        
    }
    return result;

}

int res = local(a, b);
System.Console.WriteLine(a + " в степени " + b + " равно " + res);
