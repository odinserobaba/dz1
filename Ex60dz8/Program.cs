/*
Задача 60. . ..Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/// <summary>
/// Получить массив случайных элементов
/// </summary>
/// <param name="dim"> Размерность массива</param>
/// <param name="min_value"> Левая граница</param>
/// <param name="max_value"> Правая границ</param>
/// <returns> Результирующий массив</returns>
int[,,] GetRandomArray(int[] dim, int min_value, int max_value)
{
    Random rnd = new Random();
    int[,,] arr = new int[dim[0], dim[1], dim[2]];
    for (int i = 0; i < dim[0]; i++)
        for (int j = 0; j < dim[1]; j++)
            for (int k = 0; k < dim[2]; k++)
                arr[i, j, k] = rnd.Next(min_value, max_value);
    return arr;
}

void PrinArray(int[,,] arr, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
                Console.Write(arr[i, j,k] + $"({i},{j},{k}) ");
        }
            
        Console.WriteLine();
    }
}
// PrinArray(new int[,,]{{{1,2},{3,4}},{{5,6},{7,8}},{{9,10},{11,12}}}," Тестовый вывод массива: ");
PrinArray(GetRandomArray(new int[]{3,3,3},-10,10),"Вывод случайного трехмерного массива:");