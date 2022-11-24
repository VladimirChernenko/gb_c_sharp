// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = new Random().Next(-100, 100);
            }
        }
        return matrix;  
}

double Average(double array)
{
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];   
    }
    return result / Convert.ToDouble(array.Length);
}

double[] AverageColumn(int[,] matrix)
{
    int[] column = new int[matrix.GetLength(1)];
    int[] result = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            column[j] = matrix[j, i];  
        }
        result[i] = Average(column);
    }
    return result;
}

void PrintArray(int[] array)
{   
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = CreateMatrix(4,5);
int result_array