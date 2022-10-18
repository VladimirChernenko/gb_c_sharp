// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


int num = new Random().Next(10, 100);
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