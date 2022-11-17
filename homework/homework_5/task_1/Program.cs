// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArray(int len, int min, int max)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num%2 == 0) count += 1;
    }
    return count;
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

void Main()
{
    int[] array1 = CreateArray(10, 100, 1000);
    Console.Write("In array ");
    PrintArray(array1);
    Console.Write($" {CountEvenNumbers(array1)} even numbers.");
}

Main();