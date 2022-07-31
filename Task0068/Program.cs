// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
///m = 3, n = 2 -> A(m,n) = 29


int function(int m, int n)
    {
        if (n == 0) return m + 1;
        if (m == 0) return function(n - 1, m);
        return function(n - 1, function(n, m - 1));
    }

Console.Write("Введите значение M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите величину N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(function(m, n));
        
 
