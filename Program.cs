using System;
using static System.Console;
// task 55 Задайте двумерный массив , напишите программу,
// которая поменяет местами строки и столбцы массива.
// Clear();

// Write("Введите количество строк массива ");
// int m = int.Parse(ReadLine());
// Write("Введите количество столбцов массива ");
// int n = int.Parse(ReadLine());

// if (n != m)
// {
//     WriteLine("Такой массив изменить нельзя");
//     return;
// }
// int[,] array = GetArray(m, n, 0, 10);
// PrintArray(array);
// WriteLine();
// int [,] newArray = CangeArray(array);
// PrintArray(newArray );

// int[,] GetArray(int rows, int columns, int min, int max)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// int[,] CangeArray(int[,] inArray)
// {
//     int[,] result = new int[inArray.GetLength(0), inArray.GetLength(0)];
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(0); j++)
//         {
//             result[j, i] = inArray[i, j];
//         }
//     }
//     return result;
// }

// task 55 
// 
Clear();