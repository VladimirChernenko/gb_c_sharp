// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void ArraySort(int[] array)
{
    int len = array.Length;
    for (int i = 0;  i < len; i++)
    {
        int min;
        for (int j = 1; j < len; j++)
        {
            if(array[j - 1] < array[j])
            {
                min = array[j - 1];
                array[j - 1] = array[j];
                array[j] = min;
            }   
        }
        len--;
    }
}

void MatrixSortString(int[,] matrix)
{   
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[i, j];
        }
        ArraySort(array);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = array[j];
        }
    }
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

void Main()
{
    int[,] matrix = CreateMatrix(6, 7);
    PrintMatrix(matrix);
    Console.WriteLine("-------------------------");
    MatrixSortString(matrix);
    PrintMatrix(matrix);
}

Main();