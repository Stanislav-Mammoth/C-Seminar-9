// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] arr = new int [4];
void FillArray (int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000); // [100, 1000)
    Console.Write($" {arr[i]}");
}
}

void EvenNumbers (int [] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
{
     if (arr[i] % 2 == 0) result++;
}   
Console.WriteLine($"\n Количество четных чисел в массиве: {result}");
}
FillArray(arr);
EvenNumbers(arr);

 