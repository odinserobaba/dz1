/// Задача № 2: напишите программу , которая на вход принимает два числа
/// и выдает, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число:");
string s1 = Console.ReadLine();
int number1 = int.Parse(s1);
Console.WriteLine("Первое число: {0}", number1.ToString());
Console.WriteLine("Введите второе число:");
string s2 = Console.ReadLine();
int number2 = int.Parse(s2);
Console.WriteLine("Второе число: {0}", number2.ToString());

if (number1 > number2)
    Console.WriteLine("Первое число {0} больше второго {1} ", number1.ToString(), number2.ToString());
else if (number1 > number2)
    Console.WriteLine("Первое число {0} равно второму {1} ", number1.ToString(), number2.ToString());
else
    Console.WriteLine("Второе число {1} больше первого {0} ", number1.ToString(), number2.ToString());


