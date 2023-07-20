/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
double[] GetArray(int volume)
{
    double[] arr = new double[volume];
    var rand = new Random();
    for (int i = 0; i < volume; i++)
        arr[i] = Math.Round(rand.NextDouble(), 2);
    return arr;
}
Console.WriteLine("Введите длину массива: ");
int volume = int.Parse(Console.ReadLine());
var arr = GetArray(volume);

Console.WriteLine($"Сгенерированный массив из {volume} элементов: ");
for (int i = 0; i < volume; i++)
    Console.WriteLine(arr[i]);

double delta = arr.Max() - arr.Min();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {delta} ");