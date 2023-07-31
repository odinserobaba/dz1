/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
void PrinArray(double[,] arr, int[] dim, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < dim[0]; i++)
    {
        for (int j = 0; j < dim[1]; j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
}
/// <summary>
/// Получить массив случайных элементов
/// </summary>
/// <param name="dim"> Размерность массива</param>
/// <param name="min_value"> Левая граница</param>
/// <param name="max_value"> Правая границ</param>
/// <returns> Результирующий массив</returns>
double[,] GetRandomArray(int[] dim, double min_value, double max_value)
{
    Random rnd = new Random();
    double[,] arr = new double[dim[0], dim[1]];
    for (int i = 0; i < dim[0]; i++)
        for (int j = 0; j < dim[1]; j++)
            arr[i, j] = Math.Round(rnd.NextDouble() * (max_value - min_value) + min_value, 2);
    return arr;
}

/// <summary>
/// Получить элемент по номеру
/// </summary>
/// <param name="arr"> Массив</param>
/// <param name="number"> Номер элемента с 0</param>
void GetElement(double[,] arr, int number)
{
    PrinArray(arr, new int[2] { 3, 3 }, "Исходный массив :");
    int rank = arr.Rank;
    Console.WriteLine($"Размерность массива {arr.GetLength(0)}x{arr.GetLength(1)} количество элементов - {arr.GetLength(0) * arr.GetLength(1)}");
    // Считаем номер элемента с 0
    if(number<0 || number>=(arr.GetLength(0) * arr.GetLength(1)))
        Console.WriteLine("Элемента с таким номером нет!");
    else
    {
        int i = number/arr.GetLength(0);
        int j = number - i*arr.GetLength(0);
        Console.WriteLine($" {i}  {j}");
        Console.WriteLine($"Элемента с номером {number}  - {arr[i,j]}");

    }
}
GetElement(GetRandomArray(new int[2] { 3, 3 }, -10, 10),0);