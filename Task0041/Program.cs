// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите величину массива M: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[M];
Console.WriteLine("Введите элементы массива: ");
FillArray(arr);

void FillArray(int[]arr)
{
for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int amount = 0;
for (int i = 0; i < arr.Length; i++)
if (arr[i] > 0)
{
    amount++;
}
 
Console.WriteLine($"Количество элементов больше 0: {amount}");



