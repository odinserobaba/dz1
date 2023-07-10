// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

void GetDayOff(int number)
{
    if(number==6 || number==7)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}
GetDayOff(number);