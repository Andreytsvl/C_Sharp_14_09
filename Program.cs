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

// task 57 Составить частотный словарь эл-тов двумернрого массива. 
// Словарь содержит информацию, сколько раз встречается элемент в массиве.
// Clear();

// Write("Введите количество строк массива ");
// int m = int.Parse(ReadLine());
// Write("Введите количество столбцов массива ");
// int n = int.Parse(ReadLine());

// int[,] array = GetArray(m, n, 0, 10);
// PrintArray(array);
// WriteLine();
// int[] rowA = GetRowArray(array);
// SortArray(rowA);

// WriteLine(string.Join(" ",rowA));
// WriteLine();
// PrintData(rowA);


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

// int[] GetRowArray(int[,] inArray)
// {
//     int[] rowArray = new int[inArray.GetLength(1) * inArray.GetLength(0)];
//     int index = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             rowArray[index] = inArray[i, j];
//             index++;
//         }
//     }
//     return rowArray;
// }

// void SortArray(int[] rowArray)
// {
//     for (int i = 0; i < rowArray.Length; i++) // сортировка пузырьком
//     {
//         for (int j = i + 1; j < rowArray.Length; j++)
//         {
//             if (rowArray[i] > rowArray[j])
//             {
//                 int k = rowArray[i];
//                 rowArray[i] = rowArray[j];
//                 rowArray[j] = k;
//             }
//         }
//     }
// }

// void PrintData(int[] inArray)
// {
//     int el = inArray[0];
//     int count =1;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if(inArray[i]!= el)
//         {
//             WriteLine($"{el} встречается {count} раз");
//             el = inArray[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     WriteLine($"{el} встречается {count} раз");
// }

// task 59 Из двумерного массива целых чисел удалить строку и столбц,
// на пересечении которых расположен первый найденный наименьший элемент.
// Clear();
// Write("Введите количество строк массива ");
// int m = int.Parse(ReadLine());
// Write("Введите количество столбцов массива ");
// int n = int.Parse(ReadLine());

// int[,] array = GetArray(m, n, 10, 99);
// PrintArray(array);
// WriteLine();
// WriteLine($"Минимальный элемент {String.Join(";", GetMinIndex(array))}");
// WriteLine();


// PrintArray(GetResultArray(array, GetMinIndex(array)));

// int[,] GetResultArray(int[,] inArray, int[] index)
// {
//     int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
//     int row = 0;
//     int column = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         if (i == index[0]) continue;
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (j == index[1]) continue;
//             result[row, column] = inArray[i, j];
//             column++;
//         }
//         row++;
//         column = 0;
//     }
//     return result;
// }


// int[] GetMinIndex(int[,] inArray)

// {
//     int[] result = new int[] { 0, 0 };
//     int min = inArray[0, 0];
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (min > inArray[i, j])
//             {
//                 min = inArray[i, j];
//                 result[0] = i;
//                 result[1] = j;
//             }
//         }
//     }
//     return result;
// }

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

// task 61 Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника. 
// По краям - единицы, нижний элемент явл сумммой эл-тов сверху.
// Clear();
// Write("Введите количество строк ");
// int rows = int.Parse(ReadLine());
// PrintTriangle(rows);

// void PrintTriangle(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int c = 0; c <= i - 1; c++)
//         {
//             Write("   ");
//         }
//         for (int c = 0; c <= i; c++)
//         {
//             Write("   ");
//             Write(factorial(i) / (factorial(c) * factorial(i - c)));
//         }
//         WriteLine();
//     }
// }

// int factorial(int n)
// {
//     int f = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         f = f * i;
//     }
//     return f;
// }

// task 54 DZ Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Clear();
// Write("Введите количество строк массива ");
// int m = int.Parse(ReadLine());
// Write("Введите количество столбцов массива ");
// int n = int.Parse(ReadLine());

// int[,] array = GetArray(m, n, 0, 9);
// PrintArray(array);
// WriteLine();
// NewArray(array);
// PrintArray(array);

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

// void NewArray(int[,] inArray)
// {

//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {


//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < inArray.GetLength(1); k++)
//             {
//                 if (inArray[i, k] > inArray[i, j])
//                 {
//                     int temp = inArray[i, j];
//                     inArray[i, j] = inArray[i, k];
//                     inArray[i, k] = temp;
//                 }
//             }
//         }

//     }

// }

// task 56 DZ Напишите программу, которая будет находить строку
// с наименьшей суммой элементов в двумерном массиве
// Clear();

// Write("Введите количество строк массива ");
// int m = int.Parse(ReadLine());
// Write("Введите количество столбцов массива ");
// int n = int.Parse(ReadLine());

// int[,] array = GetArray(m, n, 0, 9);
// PrintArray(array);
// WriteLine();
// int num = NumberRows(array);
// WriteLine($"{num} - строка с наименьшей суммой");

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

// int NumberRows(int[,] inArray)
// {
//     int row = 0;
//     int sum = 0;
//     for (int k = 0; k < inArray.GetLength(1); k++)
//         {
//             sum = sum + inArray[0, k];
//         }
//     for (int i = 1; i < inArray.GetLength(0); i++)
//     {
//         int minSum = 0;
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             minSum = minSum + inArray[i, j];
//         }
//         if (sum>minSum)
//         {
//             sum = minSum;
//             row = i;
//         }
//     }
//     return row;
// }

// task 58 DZ Задайте 2 матрицы. Напишите программу,
// которая будет находить их произведение
// Clear();
// Write("Введите количество строк массива 1 ");
// int m1 = int.Parse(ReadLine());
// Write("Введите количество столбцов массива 1 ");
// int n1 = int.Parse(ReadLine());
// Write("Введите количество строк массива 2 ");
// int m2 = int.Parse(ReadLine());
// Write("Введите количество столбцов массива 2 ");
// int n2 = int.Parse(ReadLine());

// int[,] array1 = GetArray(m1, n1, 0, 10);
// PrintArray(array1);
// WriteLine();
// int[,] array2 = GetArray(m2, n2, 0, 10);
// PrintArray(array2);
// WriteLine();
// if (array1.GetLength(1) != array2.GetLength(0))
// {
//     WriteLine(" такие матрицы нельзя перемножать");
//     return;
// }
// else
// {
// int[,] array3 = GetResultMatrix(array1, array2);
// PrintArray(array3);
// }


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

// int[,] GetResultMatrix(int[,] matrixA, int[,] matrixB)
// {
//     int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
//             }
//         }

//     }
//     return matrixC;
// }

// task 60 DZ Сформировать трёхмерный массив из неповторяющихся двузначных
// чисел. Построчно вывести его, добавляя индексы каждого элемента.
Clear();