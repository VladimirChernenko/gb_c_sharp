// Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

double[,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = new Random().NextDouble() * new Random().Next(-10, 10);
            }
        }
        return matrix;  
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

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double SumMaxNumMatrixStr(double[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[i, j];
        }
        sum += MaxNumber(array);
    }
    return sum;
}

double SumMinNumMatrixColumn(double[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            array[j] = matrix[j, i];
        }
        sum += MinNumber(array);
    }
    return sum;
}

void Main()
{
    double[,] matrix = CreateMatrix(5, 7);
    PrintMatrix(matrix);
    double max = SumMaxNumMatrixStr(matrix);
    double min = SumMinNumMatrixColumn(matrix);
    Console.WriteLine($"Answer: {Math.Round(max - min, 2)}.");
}

Main();