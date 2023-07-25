/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[] GetCoefficient(string text = "")
{
    double[] arr = new double[2];
    Console.WriteLine($"Введите коэффициенты {text} прямой K и B");
    arr[0] = double.Parse(Console.ReadLine());
    arr[1] = double.Parse(Console.ReadLine());
    Console.WriteLine($"Введенные коэффициенты K = {arr[0]} и B = {arr[1]}");
    return arr;
}

double[] GetPoint(double[] first, double[] second)
{
    double x = (double)((second[1] - first[1]) / (first[0] - second[0]));
    double y = first[0] * x + first[1];
    return new double[] { x, y };
}
double[] line1 = GetCoefficient("первой");
double[] line2 = GetCoefficient("второй");
double[] point = GetPoint(line1, line2);
Console.WriteLine($"Точка пересечения прямых ( {point[0]} : {point[1]} )");