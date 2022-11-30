// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool ComparisonNumber(int number1, int number2)
{
    if (number1 < number2 )
    {
        return true;
    }
    return false;
}

int ConvertEven(int number)
{
    if (number%2 == 1)  number++;
    return number;
}   

void PrintNumberUp(int number1, int number2)
{
    int number = number1;
    if(number == number2) Console.Write($"{number}");
    else 
    {
        Console.Write($"{number} ");
        PrintNumberUp(number1 + 2, number2);
    }
}

void PrintNumberDown(int number1, int number2)
{
    int number = number1;
    if(number == number2) Console.Write($"{number}");
    else 
    {
        Console.Write($"{number} ");
        PrintNumberDown(number1 - 2, number2);
    }
}

void Main()
{
    int number1 = Prompt("Enter started number: ");
    int number2 = Prompt("Enter end number: ");
    number1 = ConvertEven(number1);
    number2 = ConvertEven(number2);
    if(ComparisonNumber(number1, number2)) PrintNumberUp(number1, number2);
    else PrintNumberDown(number1, number2);
}

Main();