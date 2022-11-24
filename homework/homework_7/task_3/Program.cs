// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = new Random().Next(-10, 10);
            }
        }
        return matrix;  
}

double Average(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];   
    }
    return (Convert.ToDouble(result)) / Convert.ToDouble(array.Length);
}

double[] AverageColumn(int[,] matrix)
{
    int[] column = new int[matrix.GetLength(0)];
    double[] result = new double[matrix.GetLength(1)];
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

void PrintArray(double[] array)
{   
    Console.Write($"{Math.Round(array[0], 2)}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {Math.Round(array[i], 2)}");
    }
    Console.WriteLine();
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


int[,] matrix = CreateMatrix(3,5);
double[] result_array = AverageColumn(matrix);
PrintMatrix(matrix);
PrintArray(result_array);