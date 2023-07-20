/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] GetArray(int volume)
{
    int[] arr = new int[volume];
    var rand = new Random();
    for (int i = 0; i < volume; i++)
        arr[i] = rand.Next(-100,100);
    return arr;
}
Console.WriteLine("Введите длину массива: ");
int volume = int.Parse(Console.ReadLine());
var arr = GetArray(volume);

Console.WriteLine($"Сгенерированный массив из {volume} элементов: ");
int sum = 0;

for (int i = 0; i < volume; i++)
{
    Console.WriteLine(arr[i]);
    if (i % 2 != 0)
        sum += arr[i];
}
Console.WriteLine($"Количество элементов стоящих на нечётных позициях: {sum} ");
