// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Enter the number");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2  > 0)
{
    Console.WriteLine($"Number {num1} is odd");
}
else
{
    System.Console.WriteLine($"Number {num1} is even");
}

