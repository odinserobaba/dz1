/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
/// Получить строку по индексу
/// </summary>
/// <param name="arr">Массив </param>
/// <param name="number">Индекс </param>
/// <returns></returns>
int[] GetLineArray(int[,] arr,int number)
{
    try
    {
        int[] tmp = new int[arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            tmp[i] = arr[number,i];
        }
        return tmp;
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Возникло исключение! {ex}");
        return new int[]{-1};
    }
    
}
/// <summary>
/// Получить столбец по индексу
/// </summary>
/// <param name="arr">Массив </param>
/// <param name="number">Индекс </param>
/// <returns></returns>
int[] GetRowArray(int[,] arr,int number)
{
    try
    {
        int[] tmp = new int[arr.GetLength(0)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            tmp[i] = arr[i,number];
        }
        return tmp;
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Возникло исключение! {ex}");
        return new int[]{-1};
    }
}
/// <summary>
/// Попарное умножение двух одномерных массивов
/// </summary>
/// <param name="first"></param>
/// <param name="second"></param>
/// <returns></returns>
int MultArray(int[] first,int[] second)
{
    int[] tmp = new int[first.GetLength(0)];
    for(int i = 0;i<first.GetLength(0);i++)
        tmp[i]=first[i]*second[i];
    return tmp.Sum();
}

/// <summary>
/// Произведение двух матриц
/// </summary>
/// <param name="first"></param>
/// <param name="second"></param>
/// <returns></returns>
int[,] MultMatrix(int[,] first, int[,] second)
{
    int[,] tmp = new int[first.GetLength(0),first.GetLength(1)];
    for(int i = 0;i<first.GetLength(0);i++)
        for(int j = 0;j<first.GetLength(1);j++)
            tmp[i,j]=MultArray(GetLineArray(first,i),GetRowArray(second,j));
    return tmp;
}
/*
int[,] arr2d= GetRandomArray(new int[]{3,4},-10,10);
int[] arrline = GetLineArray(arr2d,2);
int[] arrrow = GetRowArray(arr2d,2);
PrinArray(arr2d,"");

Console.WriteLine($"Полученный массив строка {2} : ");
foreach(int i in arrline)
    Console.Write(" "+i);
Console.WriteLine();

Console.WriteLine($"Полученный массив столбец {2} : ");
foreach(int i in arrrow)
    Console.Write(" "+i);
Console.WriteLine();

Console.WriteLine($"Умножение [1,2,3,4] * [1,1,1,1]: {MultArray(new int[]{1,2,3,4},new int[]{1,1,1,1})}");
*/
int[,] tmp_matrix1 = new int[,]{{2,4},{3,2}};
int[,] tmp_matrix2 = new int[,]{{3,4},{3,3}};

PrinArray(tmp_matrix1,"Первая матрица");
PrinArray(tmp_matrix2,"Вторая матрица");
// Произведение по условию задачи
PrinArray(MultMatrix(tmp_matrix1,tmp_matrix2),"Произведение матриц по условию задачи :");

Console.WriteLine(" Произведение случайных матриц.");

int[,] tmp_random_matrix1 = GetRandomArray(new int[]{5,5},-10,10);
int[,] tmp_random_matrix2 = GetRandomArray(new int[]{5,5},-10,10);

PrinArray(tmp_random_matrix1,"Первая матрица");
PrinArray(tmp_random_matrix2,"Вторая матрица");
// Произведение по условию задачи
PrinArray(MultMatrix(tmp_random_matrix2,tmp_random_matrix2),"Произведение случайных матриц :");