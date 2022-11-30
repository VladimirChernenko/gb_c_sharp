// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool ValidateNumber(int number)
{
    if (number >= 0)
    {
        return true;
    }
    return false;
}


int Ackerman(int number1, int number2)
{
    if(number1 == 0) return number2 + 1;
    else if (number2 == 0) return Ackerman(number1 - 1, 1);
    else  return Ackerman(number1 - 1, Ackerman(number1, number2 -1));
}

void Main()
{
    int number1 = Prompt("Enter positive number1: ");
    int number2 = Prompt("Enter positive number2: ");
    if (ValidateNumber(number1) && ValidateNumber(number2))
    {
        Console.WriteLine($"{Ackerman(number1, number2)}");
    }
    else Console.WriteLine("You can't enter negative numbers");

}

Main();