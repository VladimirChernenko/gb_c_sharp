// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int EnterNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

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

bool Validate(double[,] matrix, int position)
{
    if (position > 0 && matrix.GetLength(0) * matrix.GetLength(1) >= position) return true;
    else return false;
}

double PositionMatrixNumber(double[,] matrix, int position)
{
    int positionString = position / matrix.GetLength(1) - 1;
    int positionColumn = position % matrix.GetLength(1) - 1;
    if (positionString < 0) positionString = 0;
    if (positionColumn < 0) positionColumn = 0;
    return Math.Round(matrix[positionString, positionColumn], 2);
}

void Main()
{
    int stringMatrix = new Random().Next(1, 6);
    int columnMatrix = new Random().Next(1, 6);
    int position = EnterNumber("Position number in matrix: ");
    double[,] matrix = CreateMatrix(stringMatrix, columnMatrix);
    double resultNumber = PositionMatrixNumber(matrix, position);
    PrintMatrix(matrix);
    if (Validate(matrix, position)) Console.Write($"{resultNumber}");
    else Console.Write("There is no such number in the array");
}

Main();