// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
        arr[i,j] = new Random().Next(1,11); //[1,11)
        Console.Write(arr[i,j]+ " ");     
    }
    Console.WriteLine();
}
}

double average;

for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
{
    sum = sum + arr[i,j];
    
}
average = Math.Round(sum/m,1); 
Console.WriteLine($"Среднее значение {j+1} стобца {average}");
}



