// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int [,] arr = new int [4,4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        arr[i,j]= new Random().Next(1,11); //[1,10] 
        Console.Write(arr[i,j]+" ");
    }
    Console.WriteLine();
}


Console.Write("Введите позицию элемента по горизонтали: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента по вертикали: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a <= 4 && b <= 4  ) Console.WriteLine(arr[a,b]);
else Console.WriteLine("Нет такого элемента");
