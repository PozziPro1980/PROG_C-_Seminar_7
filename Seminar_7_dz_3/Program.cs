// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введиие кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введиие кол-во столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,]   array= new int[rows,colums];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
       array[i,j] = new Random().Next(1,10);
       Console.Write(array[i,j]+ " ");
   } 
   Console.WriteLine();
}
Console.WriteLine("__________________");

double sum = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      sum += array[i,j];
   } 
   double average = Math.Round(sum/array.GetLength(0), 2);
   sum = 0;
   Console.Write(average+ " ");
}   