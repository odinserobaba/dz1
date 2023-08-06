/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/// <summary>
/// Получить натуральные числа от N до 1
/// </summary>
/// <param name="number">Начало промежутка</param>
void GetNaturalNumbers(int number)
{
    // Условие для корректного вывода
    if (number != 1)
        Console.Write(number + ", ");
    else
        Console.WriteLine(number + " ");
    number--;
    if (number > 0)
        GetNaturalNumbers(number);
}

GetNaturalNumbers(8);