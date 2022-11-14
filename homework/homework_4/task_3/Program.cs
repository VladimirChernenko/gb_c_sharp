// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int PromptInt(string description)
{
    Console.Write(description);
    return Convert.ToInt32(Console.ReadLine());
}

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
    Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
}

void Main()
{
    int min = PromptInt("Enter thr min_number: ");
    int max = PromptInt("Enter the max_number: ");
    int len = PromptInt("Enter the length of array: ");
    int[] array = CreateArray(len, min, max);
    PrintArray(array);
}

Main();