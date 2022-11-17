// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] CreateArray(int len, int min, int max)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
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

int DifferenceMinMaxArray(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]> max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return max - min;
}

void Main()
{
    int[] array = CreateArray(10, 1 , 1000);
    int result = DifferenceMinMaxArray(array);
    Console.Write("In array ");
    PrintArray(array);
    Console.Write($" difference between minimum and maximum: {result}");
}

Main();