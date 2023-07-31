/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int[] GetShape()
{
    Console.WriteLine("Введите размерность массива (MxN)");
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"Размерность введенного массива ({m}x{n})");
    int[] dim = new int[2] { m, n };
    return dim;
}
double[,] GetRandomArray(int[] dim, double min_value, double max_value)
{
    Random rnd = new Random();
    double[,] arr = new double[dim[0], dim[1]];
    for (int i = 0; i < dim[0]; i++)
        for (int j = 0; j < dim[1]; j++)
            arr[i, j] = Math.Round(rnd.NextDouble() * (max_value - min_value) + min_value, 2);
    return arr;
}

void PrinArray(double[,] arr,int[] dim,string text)
{
    Console.WriteLine(text);
    for(int i = 0; i < dim[0];i++)
    {
        for (int j = 0;j<dim[1];j++)
            Console.Write(arr[i,j]+" ");
        Console.WriteLine();
    }
}
// double[,] arr = GetRandomArray(GetShape(), -10, 10);
// foreach (var i in arr)
//     Console.WriteLine(i);
int[] shape = GetShape();
PrinArray(GetRandomArray(shape,-10,10),shape,"Полученный массив: ");
