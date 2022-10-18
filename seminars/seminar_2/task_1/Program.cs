// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


int EnterNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = EnterNumber("Enter the number 100-999 ");
if (num > 99 && num < 1000)
{
    Console.WriteLine($"The last digit of the number {num}: {num % 10}.");
}
else
{
    Console.WriteLine($"Incorrect input");
}

