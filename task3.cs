/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.*/

using System;

class Program
{
    static void Main()
    {
        int[,] array = 
        {
            {3, 2, 1},
            {9, 4, 6},
            {2, 8, 3}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minRowIndex = FindRowWithMinSum(array);
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex}");
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int minRowIndex = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
