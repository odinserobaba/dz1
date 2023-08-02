/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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
            arr[i, j] = rnd.Next(min_value, max_value);
    return arr;
}
/// <summary>
/// Печать двумерного массива
/// </summary>
/// <param name="arr">Жвумерный массив</param>
/// <param name="text">Дополнительный текст</param>
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
/// Находит индекс минимального элемента в одномерном массиве
/// </summary>
/// <param name="arr">Одномерный массив</param>
/// <returns>Индекс максимального элемента</returns>
int GetIndexMin(int[] arr)
{
    return Array.IndexOf(arr,arr.Min());
}

int GetArrSum(int[,] arr)
{
    PrinArray(arr,"Исходный массив: ");
    int[] tmp = new int[arr.GetLength(0)];
    int[] tmp1d = new int[arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(0);i++)
    {
        for(int j = 0; j < arr.GetLength(1);j++)
        {
            tmp1d[j]=arr[i,j];
        }
        tmp[i]=tmp1d.Sum();
    }
    Console.WriteLine("Суммы по строкам: ");
    foreach(int i in tmp)
        Console.Write(" "+i);
    return GetIndexMin(tmp);
}


Console.WriteLine("\n"+GetArrSum(GetRandomArray(new int[]{3,4},-10,10)));
