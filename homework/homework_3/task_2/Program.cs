// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] ArrayCoord(string message)
{
    int[] arrayCoord = new int[3];
    string[] arrayNameCoord = { "x", "y", "z" };
    for (int i = 0; i < 3; i++)
    {
        arrayCoord[i] = Prompt($"{message} {arrayNameCoord[i]}-coordinate ");
    }
    return arrayCoord;
}

double Distance(int[] a, int[] b)
{
    double result = 0;
    for (int i = 0; i < 3; i++)
    {
        result += Math.Pow(a[i] - b[i], 2);
    }
    return Math.Round(Math.Sqrt(result), 2);
}

int[] arrayA = ArrayCoord("Enter point A");
int[] arrayB = ArrayCoord("Enter point B");

Console.WriteLine($"Distance between points A and B: {Distance(arrayA, arrayB)}");