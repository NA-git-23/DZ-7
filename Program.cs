// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void PrintArray(double[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//  for (int j = 0; j < matr.GetLength(1); j++)
//  {
//   Random rnd = new Random();
//   matr[i,j] = Convert.ToDouble(rnd.Next(-10, 10)/10.0);
//   Console.Write($"{matr[i,j]} ");
//   }
// Console.WriteLine();
// }
// }

// double[,] matrix = new double[3, 4];
// PrintArray(matrix);
// Console.WriteLine();



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите двумерный массив: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matr = new int[m, n];
 
// for (int i = 0; i < matr.GetLength(0); i++) 
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//         matr [i, j] = Convert.ToInt32(new Random().Next(0,21));  
// }
 
// for (int i = 0; i < matr.GetLength(0); i++) 
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//         Console.Write(matr[i,j] + "\t  ");
//         Console.WriteLine();
// }
 
//  Console.WriteLine("Введите позицию элемента");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m && b>n)
//  Console.WriteLine("такого числа нет");
//  else
//  {
//  object c = matr.GetValue(a,b);
//  Console.WriteLine(c);
//  }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void PrintArray(int[,] matr)
// {

// for (int i = 0; i < matr.GetLength(0); i++)
// {
//  for (int j = 0; j < matr.GetLength(1); j++)
//  {
//     matr[i,j] = new Random().Next(1,10);
//  Console.Write($"{matr[i, j]} ");
//   }
// Console.WriteLine();
// }
// }

// void PrintArray(double [,] matr)
// {


// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// Console.Write(matrix);



