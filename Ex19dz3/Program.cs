/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/
Console.WriteLine("Введите пятизначное число");
string num  = Console.ReadLine();
Console.WriteLine("Введенное число {0} длина {1}",num,num.Length);

int median = 3;
var str_ar = num.ToArray();
bool f= true;
for(int i=0;i<median;i++)
{
    if(str_ar[i]!=str_ar[str_ar.Length-i-1])
        f= false;
}
if(f)
    Console.WriteLine("Число {0} является палиндромом.",num);
else
    Console.WriteLine("Число {0} не является палиндромом.",num);