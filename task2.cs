/*Задайте двумерный массив. 
Напишите программу, которая 
поменяет местами первую и 
последнюю строку массива.*/

using System;

class Program
{
    static void Main()
    {
        int[,] array = 
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        SwapFirstAndLastRow(array);

        Console.WriteLine("Массив после замены строк:");
        PrintArray(array);
    }

    static void SwapFirstAndLastRow(int[,] array)
    {
        int lastRow = array.GetLength(0) - 1;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int temp = array[0, i];
            array[0, i] = array[lastRow, i];
            array[lastRow, i] = temp;
        }
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
