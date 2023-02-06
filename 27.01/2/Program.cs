int[] array = new int[6];
Random rnd = new Random();
int Sum = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = rnd.Next(1, 20);
    System.Console.Write(" " + array[i]);
    if (i % 2 != 0) {
    Sum = array[i] + Sum;
};

};

System.Console.WriteLine(" Сумма элементов на нечетных позициях " +  Sum);