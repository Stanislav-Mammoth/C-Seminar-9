// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//y=k1x+b1 y=k2x+b2   

double b1;
double k1;
double b2;
double k2;
double x;
double y;
Console.Write("Введите k1 для первой прямой: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1 для первой прямой: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2 для второй прямой: ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2 для второй прямой: ");
b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2 && b1 == b2) Console.Write("Прямые совпадают!");
else if (k1 == k2) Console.Write("Прямые паралельны!");
else
{
    x = Math.Round((b2-b1)/(k1-k2),1);
    y = Math.Round((k1*x+b1),1);
    Console.WriteLine($"точка пересечения ({x}; {y})");
}




