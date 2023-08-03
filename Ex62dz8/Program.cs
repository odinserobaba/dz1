/*
*Задача 62**. * Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void PrinArray(int[,] arr, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
            Console.Write(arr[i, j] +" ");
        }
            
        Console.WriteLine();
    }
}

int[,] tmp = new int[4,4];
PrinArray(tmp,"Исходный массив");
int start=0;
int stop=tmp.GetLength(1);
int tmp_number=1;

for(int x=0;x<2;x++)
{
    // Right
    for(int j=start; j<stop;j++)
    {
        int i =start;
        tmp[i,j]=tmp_number;
        tmp_number++;
    }
    // PrinArray(tmp,"Право");
    // Down
    for(int i=start+1;i<stop;i++)
    {
        int j =stop-1;
        tmp[i,j]=tmp_number;
        tmp_number++;
    }
    // PrinArray(tmp,"Вниз");
    // Left
    for(int j=stop-2;j>=start;j--)
    {
        int i =stop-1;
        tmp[i,j]=tmp_number;
        tmp_number++;
    }
    // PrinArray(tmp,"Лево");
    // Up
    for(int i=stop-2;i>start;i--)
    {
        int j =start;
        tmp[i,j]=tmp_number;
        tmp_number++;
    }
    // PrinArray(tmp,"Первый проход");
    start++;
    stop--;
}
PrinArray(tmp,"Спиральное заполнение массива");
