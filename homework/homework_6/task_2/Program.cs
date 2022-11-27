// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// x = (b2 - b1)/(k2 - k1)

double EnterNumber(string message)
{
    Console.Write(message);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

void PrintArray(double[] array)
{   
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
}

double[] InterSection(double[] straight1, double[] straight2)
{
    double[] result = new double[2];
    result[0] = (straight2[1] - straight1[1]) / (straight1[0] - straight2[0]);
    result[1] = straight1[0] * result[0] + straight1[1];
    return result;
}

void Main()
{
    double[] coordinate1 = {EnterNumber("Enter k1: "), EnterNumber("Enter b1: ")};
    double[] coordinate2 = {EnterNumber("Enter k2: "), EnterNumber("Enter b2: ")};
    double[] result = InterSection(coordinate1, coordinate2);
    PrintArray(result);
}

Main();
