// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
Console.Write("Введите величину массива  m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите величину массива  n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [m,n];
FillArray(arr);

void FillArray(int [,] arr)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = new Random().Next(0,10);
        Console.Write(arr[i,j]+" ");
    }
    Console.WriteLine();
}
}
 
// Сортировка массива
for (int i = 0; i < m; i++)
{
int temp = 0;
for (int j = 0; j < n; j++)
{
    for (int k = j + 1; k < n; k++)
    {
        if (arr[i,j] < arr[i,k])
        {
            temp = arr[i,j];
            arr[i,j] = arr[i,k];
            arr[i,k] = temp;
        }
    }
}
}

// Вывод на экран
Console.WriteLine();
Console.WriteLine("Вывод отсортированного массива");
 for (int i = 0; i < m; i++)
 {
     for (int j = 0; j < n; j++)
     {
         Console.Write(arr[i,j]+" ");
     }
     Console.WriteLine();
 }            