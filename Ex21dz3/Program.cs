/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. */

int Input(string text_point, string text_number)
{
    Console.WriteLine("Введите координату {0} точки {1}", text_point, text_number);
    return int.Parse(Console.ReadLine());
}

double Distance3D(int[] mass_a, int[] mass_b)
{
    return Math.Round(Math.Sqrt(Math.Pow(mass_a[0] - mass_b[0], 2) + Math.Pow(mass_a[1] - mass_b[1], 2) +
     Math.Pow(mass_a[2] - mass_b[2], 2)), 2);
}

int[] mass_a = { Input("A", "X"), Input("A", "Y"), Input("A", "Z") };
int[] mass_b = { Input("B", "X"), Input("B", "Y"), Input("B", "Z") };

Console.WriteLine("Расстояние между точками А и B - {0}", Distance3D(mass_a, mass_b));