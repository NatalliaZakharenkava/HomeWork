int[] array = new int[8];

void FillArray(int[] curt) {
    int lenght = curt.Length;
    int i = 0;
    while (i < lenght)  {
        curt[i] = new Random().Next(1, 8);
        i++;
    }
};

void PrintArray(int[] cobein) {
    int count = cobein.Length;
    int position = 0;
    while (position < count) {
        System.Console.WriteLine(cobein[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);
