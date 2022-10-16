// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Enter the number");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 >= 2)
{
    Console.Write($"2");
    for (int i = 4; num1 >= i; i += 2)
    {
        Console.Write($", {i}");
    }
}
