// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Write("Введите величину массива  m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите величину массива  n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [m,n];
FillArray(arr);

void FillArray(int [,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = new Random().Next(1,21); //[1,21)
        Console.Write(arr[i,j]+ " ");     
    }
    Console.WriteLine();
}
}
Console.WriteLine();

//Нахождение строки с минимальной суммой
int [] sum = new int[n];
int min = 0;
int minIndex = 0;
for ( int i = 0; i < arr.GetLength(0); i++)
{    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
       sum[i] = sum[i] + arr[i,j];                              
    }
     if (sum[i] <= sum[0] ) 
    {
        min = sum[i];
        minIndex = i;      
    }     
}

//Вывод на экран
Console.WriteLine("Строка с минимальной суммой");
for (int j = 0; j < arr.GetLength(1); j++)
{
    Console.Write(arr[minIndex,j] + " "); 
}

        



    