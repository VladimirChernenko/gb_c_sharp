// 4.1. Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да


int EnterNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int count = new Random().Next(1, 101);
int div = EnterNumber("Enter a number ");
int num;

for (int i = 0; i < count; i++)
{
    num = new Random().Next(1, 101);
    if (num % div == 0)
    {
        Console.WriteLine($"{num} -> Yes!");
        break;
    }
    Console.WriteLine($"{num} -> No!");
}