// Задача 47. Задайте двумерный массив размером m × n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введиие кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введиие кол-во столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

double[,]   array= new double[rows,colums];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
       array[i,j] = new Random().NextDouble() + new Random().Next(-9,10);
       array[i,j] = Math.Round(array[i,j], 2);
       Console.Write(array[i,j]+ " ");
   } 
   Console.WriteLine();
}
