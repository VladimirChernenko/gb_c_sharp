// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int str, int column)
{
    int[,] matrix = new int[str, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int StringMinSumMatrix(int[,] matrix)
{
    int index = 0;
    int sum = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minSum += matrix[0, i];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum)
        {
            index = i;
            minSum = sum;
        }
    }
    return index;
}

void Main()
{
    int[,] matrix = CreateMatrix(5, 7);
    PrintMatrix(matrix);
    Console.WriteLine($"Matrix row index with minimum sum: {StringMinSumMatrix(matrix)}");
}

Main();