/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void PrinArray(int[,] arr, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
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
int[,] GetRandomArray(int[] dim, int min_value, int max_value)
{
    Random rnd = new Random();
    int[,] arr = new int[dim[0], dim[1]];
    for (int i = 0; i < dim[0]; i++)
        for (int j = 0; j < dim[1]; j++)
            arr[i, j] = rnd.Next(min_value,max_value) ;
    return arr;
}

void GetAvr(int[,] arr)
{
    int[,] tmp_arr= new int[arr.GetLength(1),arr.GetLength(0)];
    int[] tmp_avr = new int[arr.GetLength(1)];
    for(int i=0; i<arr.GetLength(0);i++)
        for(int j=0; j<arr.GetLength(1);j++)
            tmp_arr[i,j] = arr[j,i];
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < tmp_arr.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < tmp_arr.GetLength(1); j++) 
                {
                    sum += tmp_arr[i, j];
                }
                Console.Write(sum/tmp_arr.GetLength(0) + " ");
            }
}
int[,] arr = GetRandomArray(new int[2]{4,4},-10,10);
PrinArray(arr,"Исходный массив: ");
GetAvr(arr);
Console.WriteLine("");