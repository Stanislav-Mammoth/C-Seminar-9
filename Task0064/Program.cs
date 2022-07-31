//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void function (int x)
{
    if(x == 0) return;        
    Console.Write($"{x }"+" ");
    function (x - 1);
}

Console.Write("Введите величину N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа от {n } до 1.");
function (n);