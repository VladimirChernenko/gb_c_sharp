// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// int num1, num2;
// Console.WriteLine("Enter the numbers");
// num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the numbers");
// num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine($"Max number: {num1}\nMin number: {num2}");
// }
// else
// {
//     Console.WriteLine($"Max number: {num2}\nMin number: {num1}");
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// int[] numbers = new int[3];
// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine("Enter the number");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }
// int max = numbers[0];
// for (int i = 1; i < 3; i++)
// {
//     if (numbers[i] > max) 
//     {
//         max = numbers[i];
//     }
// }
//  Console.WriteLine($"Max number: {max}");




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Enter the number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 > 0)
// {
//     Console.WriteLine($"Number {num1} is odd");
// }
// else
// {
//     System.Console.WriteLine($"Number {num1} is even");
// }




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.WriteLine("Enter the number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 >= 2)
// {
//     Console.Write($"2");
//     for (int i = 4; num1 >= i; i += 2)
//     {
//         Console.Write($", {i}");
//     }
// }