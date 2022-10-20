// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6


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

int num = EnterNumber("Enter the number from -2147483648 to 2147483647 :");
int num1 = CheckingNegativeNumber(num);
int len = 1;

while (num1 > 0)
{
    len *= 10;
    num1 /= 10;
}
if (len <= 100)
{
    Console.WriteLine($"{num} doesn't have third digit!");
}

else
{
    int result = num % (len / 100) / (len / 1000);
    result = CheckingNegativeNumber(result);
    Console.WriteLine($"The number {num} has the third digit: {result}.");
}