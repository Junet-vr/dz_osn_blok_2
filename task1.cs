/*Напишите программу, которая на 
вход принимает позиции элемента в 
двумерном массиве, и возвращает 
значение этого элемента или же 
указание, что такого элемента нет.*/

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

        Console.Write("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца: ");
        int col = Convert.ToInt32(Console.ReadLine());

        if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
        {
            Console.WriteLine($"Значение элемента: {array[row, col]}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет.");
        }
    }
}
