/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
/// Сортировка одномерного массива
/// </summary>
/// <param name="arr">Одномерный массив</param>
/// <returns>Одномерный массив</returns>
int[] SortArray1D(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

int[,] SortArray2D(int[,] arr)
{
    PrinArray(arr,"Созданный массив:");
    int[,] temp = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        // Получаем временный двумерный массив
        int[] tmp1d_arr = new int[arr.GetLength(0)];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tmp1d_arr[j] = arr[i, j];
        }
        // Перезаписываем в новый массив
        tmp1d_arr = SortArray1D(tmp1d_arr);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            temp[i, j] = tmp1d_arr[j];
        }

    }
    return temp;
}



PrinArray(SortArray2D(GetRandomArray(new int[]{3,3},-10,10)),"Отсортированный массив: ");