// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

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

int SumAllNumber(int number1, int number2)
{
    if (number1 == number2) return number2;
    else return SumAllNumber(number1 + 1, number2) + number1;
}



void Main()
{
    int number1 = Prompt("Enter started number: ");
    int number2 = Prompt("Enter end number: ");
    if(ComparisonNumber(number2, number1))
    {
        int number = number1;
        number1 = number2;
        number2 = number;
    } 
    Console.Write($"Sum of all number between [{number1}, {number2}]: {SumAllNumber(number1, number2)}");
}

Main();