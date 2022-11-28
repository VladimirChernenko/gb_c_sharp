// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int str, int column)
{
    int[,] matrix = new int[str, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 5);
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

bool ValidateMultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
        return true;
    return false;
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int sum = 0;
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int x = 0; x < matrix2.GetLength(0); x++)
            {
                sum += matrix1[i, x] * matrix2[x, j];
            }
            resultMatrix[i, j] = sum; 
            sum = 0;
        }
        
    }
    return resultMatrix;
}

void Main()
{
    int[,] matrix1 = CreateMatrix(2,2);
    int[,] matrix2 = CreateMatrix(2,2);
    int[,] multiMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (ValidateMultiplicationMatrix(matrix1, matrix2))
    {
        multiMatrix = MultiplicationMatrix(matrix1, matrix2);
    }
    PrintMatrix(matrix1);
    Console.WriteLine("----------------------------");
    PrintMatrix(matrix2);
    Console.WriteLine("----------------------------");
    PrintMatrix(multiMatrix);
}

Main();