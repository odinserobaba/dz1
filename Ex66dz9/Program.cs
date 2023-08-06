/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int sum = 0;
/// <summary>
/// Ф-ция нахождения суммы натуральных элементов от M до N
/// </summary>
/// <param name="sum"></param>
/// <param name="M"></param>
/// <param name="N"></param>
/// <param name="counter"></param>
void GetNaturalSum(ref int sum, int M, int N, int counter)
{
    if ((N >= counter) && (counter >= M))
    {
        sum += counter;
        counter++;
        GetNaturalSum(ref sum, M, N, counter);
    }
}
/// <summary>
/// Ф-ция нахождения суммы натуральных элементов от M до N без передачи параметра по ссылке
/// </summary>
/// <param name="M">M</param>
/// <param name="N">N</param>
/// <returns>Сумма натуральных элементов от M до N</returns>
int GetNaturalSumNotRef(int M, int N)
{
    if(M>N)
        return 0;
    
    return M+GetNaturalSumNotRef(M+1,N);
}


GetNaturalSum(ref sum, 1, 15, 1);
Console.WriteLine(sum);
Console.WriteLine(GetNaturalSumNotRef(1,15));