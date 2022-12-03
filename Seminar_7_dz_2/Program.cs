// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введиие кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введиие кол-во столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,]   array= new int[rows,colums];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
       array[i,j] = new Random().Next(0,100);
       Console.Write(array[i,j]+ " ");
   } 
   Console.WriteLine();
}

Console.WriteLine("Введиие позицию по строке: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введиие позицию по столбцу: ");
int b = Convert.ToInt32(Console.ReadLine());

if ((a < array.GetLength(0)) && (b < array.GetLength(1)))
{
    Console.WriteLine(array[a,b]);
}
else
{
    Console.WriteLine("Такого числа в массиве нет.");
}