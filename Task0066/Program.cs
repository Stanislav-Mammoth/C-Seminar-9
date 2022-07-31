// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int function (int x, int y)
{
    if(x == y-1) return 0;        
  
    return x + function(x-1,y);
   
}
Console.Write("Введите значение M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите величину N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных чисел в промежутке {m } и {n } равна: ");
Console.Write(function (n,m));
function (n,m);

