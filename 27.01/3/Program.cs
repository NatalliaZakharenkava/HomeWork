double[] array = new double[5];
Random rnd = new Random();



for (int i = 0; i < array.Length; i++) {
    array[i] = rnd.Next(1, 10);
    System.Console.Write(array[i] + " ");
  };

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++) {
    if (max < array[i]) {
        max = array[i];
    }
    if (min > array[i]) {
        min = array[i];
    }
};

double MaxMin = max - min;

System.Console.WriteLine(" \nРазница между максимальным и минимальным числом " + MaxMin);



