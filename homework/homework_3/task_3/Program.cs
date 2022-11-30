// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool ValidateNumber(int number)
{
    if (number > 0)
    {
        return true;
    }
    return false;
}

void SequenceCube(int num)
{
    Console.Write(1);
    for (int i = 2; i <= num; i++)
    {
        Console.Write($", {Math.Pow(i, 3)}");
    }
}

int num = Prompt("Enter integer greater then zero: ");
if (ValidateNumber(num))
{
    SequenceCube(num);
}
else
{
    Console.WriteLine("Input Error.");
}