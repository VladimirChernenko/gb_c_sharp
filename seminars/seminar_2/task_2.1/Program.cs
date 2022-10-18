// 2.1. Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int num = new Random().Next(10, 10000);
int num1 = num;

int numMax = 0;

while (num1 > 0)
{
    if (num1 % 10 > numMax)
    {
        numMax = num1 % 10;
    }
    num1 /= 10;
}

Console.WriteLine($"largest digit of the number {num}: {numMax}");
