// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int PromptInt(string description)
{
    Console.Write(description);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

void Main()
{
    int result = PromptInt("Enter number: ");
    Console.WriteLine($"The sum of the digits {result}: {SumNumber(result)}");
}

Main();