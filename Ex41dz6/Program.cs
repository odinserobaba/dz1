/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int GetCountArray()
{
    Console.WriteLine("Введите количество элементов: ");
    return int.Parse(Console.ReadLine());
}
int[] GetArray(int count)
{
    Console.WriteLine($"Введите массив из  элементов {count}");
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
        arr[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Введеный массив:");
    for (int i = 0; i < count; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
    return arr;
}

void GetAboveZero(int[] arr)
{
    int count=0;
    for(int i=0;i<arr.Length;i++)
        if(arr[i]>0)
            count++;
    Console.WriteLine($"Количество элементов больше нуля : {count}");
}
GetAboveZero(GetArray(GetCountArray()));