double[,] array = new double[3, 4];



for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i,j] = genRndDouble(0, 10);
        System.Console.Write(Math.Round(array[i,j] , 2) + " ");
    }
    System.Console.WriteLine();
}


double genRndDouble (int a, int b)
{
    Random rnd = new Random();
    double rndDouble = a + rnd.NextDouble() * (b - a);
    return rndDouble;

}
