 //Задача 62: Заполните спирально массив 4 на 4.
          
Console.Write("Введите величину массива  n = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите величину массива  m = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
 
int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int turns = m;
 
 //Заполнение массива по порядку
for (int i = 0; i < matrix.Length; i++)
{
    matrix[row, col] = i + 1;
        if (--turns == 0)
          {
            turns = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
          }
 
        col = col + dx;
        row = row + dy;
}

 //Вывод на экран
 for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
          {
            Console.Write(matrix[i, j] + " ");
          }
    Console.WriteLine();
}