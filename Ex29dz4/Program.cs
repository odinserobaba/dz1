/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int li=0;
int[] mass = new int[8];
Console.WriteLine("Введите массив из 8 целочисленных элементов!");
while(li<8)
{
    try
    {
        mass[li]= int.Parse(Console.ReadLine());
        li++;
    }
    catch
    {
        Console.WriteLine("Ошибка, это не число!");
        continue;
    }
}
for(int i=0;i<8;i++)
    Console.Write(mass[i]+" ");