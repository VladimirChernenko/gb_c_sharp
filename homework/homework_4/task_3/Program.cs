// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] CreateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
}


PrintArray(CreateArray(8));