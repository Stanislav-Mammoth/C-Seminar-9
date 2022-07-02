// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] arr = new int [4];
void FillArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {   
        arr[i] = new Random().Next(-100, 100); // [100, 1000)
        Console.Write($" {arr[i]}");
    }
}

void SumOddNumbers(int[]arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {   
        if (i % 2 != 0)
        {
        result = result + arr[i];
        }  
    }
    Console.WriteLine($"\n Сумма нечетных элементов: {result}");
}

FillArray(arr);
SumOddNumbers(arr);