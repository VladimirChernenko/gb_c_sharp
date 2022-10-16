// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


int num1, num2;
Console.WriteLine("Enter the numbers");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the numbers");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Max number: {num1}\nMin number: {num2}");
}
else
{
    Console.WriteLine($"Max number: {num2}\nMin number: {num1}");
}