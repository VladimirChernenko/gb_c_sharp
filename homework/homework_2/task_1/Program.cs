// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int EnterNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int CheckingNegativeNumber(int num)
{
        if (num < 0)
    {
        return -num;
    }
    return num;
}


int num = EnterNumber("Enter the number 100-999 or (-999)-(-100) :");
if ((num > 99 && num < 1000) || (num > -1000 && num < -99))
{
    int answer = num % 100 / 10;
    answer = CheckingNegativeNumber(answer);
    Console.WriteLine($"Second digit of the number {num}: {answer}");
}
else
{
    Console.WriteLine($"Non three digit number");
}