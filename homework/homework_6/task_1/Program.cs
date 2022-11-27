// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int EnterNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int CountPositiveNumber(int m)
{
    int num;
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        num = EnterNumber("Enter number: ");
        if (num > 0)
        {
            count ++;
        }
    }
    return count;
}

void Main()
{
    int count = EnterNumber("How many digits do you want to enter: ");
    int result = CountPositiveNumber(count);
    Console.WriteLine($"You entered {result} positive numbers.");
}

Main();