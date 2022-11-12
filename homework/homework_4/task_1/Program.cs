// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int PromptInt(string description)
{
    Console.Write(description);
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if (num < 1)
    {
        return false;
    }
    return true;
}


int Exponentiation(int number, int degree)
{
    int num = number;
    while (degree > 1)
    {
        number *= num;
        degree--;
    }
    return number;
}

void Main()
{
    int a = PromptInt("Enter number 1: ");
    int b = PromptInt("Enter number 2: ");
    if (Validate(b))
    {
        Console.WriteLine($"Number {a} to the power of {b}: {Exponentiation(a, b)}");
    }
    else
    {
        Console.WriteLine("Input error!");
    }
}

Main();