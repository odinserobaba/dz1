/*
Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/// <summary>
/// Вычисления функции Аккермана
/// </summary>
/// <param name="n"></param>
/// <param name="m"></param>
/// <returns></returns>
int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    {
        if ((n != 0) && (m == 0))
            return Akk(n - 1, 1);
        else
            return Akk(n - 1, Akk(n, m - 1));
    }
}
/// <summary>
/// Вычисления функции Аккермана более эффективная
/// </summary>
/// <param name="n"></param>
/// <param name="m"></param>
/// <returns></returns>
int Akk_effective(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
            m = 1;
        else
            m = Akk_effective(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}
Console.WriteLine(Akk(2, 3));
Console.WriteLine(Akk_effective(2, 3));