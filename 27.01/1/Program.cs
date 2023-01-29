int[] array = new int[10];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++) {
    array[i] = rnd.Next(100, 1000);
    System.Console.Write(" " + array[i]);
    
};

System.Console.WriteLine();
int col = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0) {
    col = col + 1;
    }
};
System.Console.WriteLine("Количество четных чисел в массиве " + col);



