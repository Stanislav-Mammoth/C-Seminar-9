//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfNumber (int number)
{
int result = 0;
do
{
    result = result + number % 10;
    number = number / 10;
    if (number / 10 == 0)
    {
        result = result + number % 10;
         break;
    }
} while (true);
return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfNumber(number);
    
Console.WriteLine($"Сумма цифр в числе: {result}");



//Попробовал через string, почему то не получилось(

// Console.Write("Введите число: ");
// string number = Convert.ToString(Console.ReadLine());
// int result = 0;

// for (int i = 0; i < number.Length; i++)
// {
//     result = result + Convert.ToInt32(number[i]);
    
// }
// Console.WriteLine(result);