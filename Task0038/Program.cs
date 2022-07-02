// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int [] arr = new int [5];
void FillArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100); // [0, 100)
        Console.Write($"{arr[i]} ");
    }
}

void DiffMaxMin(int[]arr)
{
    int result;
    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    result = max - min;
    Console.WriteLine($"\nРазница между максимальным и минимальным элементов массива: {result}");
}
FillArray(arr);
DiffMaxMin(arr);
