// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int EnterNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = EnterNumber("Enter a number from 1 to 7 inclusive :");

if (num < 8 && num > 0)
{
    if (num == 6 && num == 7)
    {
        Console.WriteLine("Yes.");
    }
    else
    {
        Console.WriteLine("No.");
    }
}
else
{
    Console.WriteLine("The number is not in the range from 1 to 7");
}