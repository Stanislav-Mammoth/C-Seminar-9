// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Write("Введите величину массива  m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите величину массива  n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [m,n];
int [,] newarr = new int [m,n];
FillArray(arr);
FillArray(newarr);
void FillArray(int [,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = new Random().Next(1,11); //[1,11)
        Console.Write(arr[i,j]+ " ");     
    }
    Console.WriteLine();
}
Console.WriteLine();
}

//Произведение матриц
Console.WriteLine("Произведение двух матриц");
int[,] multimatrix = new int[m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(0); k++)
        {
            multimatrix[i,j] = multimatrix[i,j] + arr[i,k]*newarr[k,j];
        }
        
               
        Console.Write(multimatrix[i,j]+ " ");     
    }
    Console.WriteLine();
}
Console.WriteLine();

