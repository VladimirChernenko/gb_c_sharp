// 3.1. Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 


int EnterNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int sum = 0;
double average;
for (int i = 0; i < 5; i++)
{
    sum += EnterNumber("Enter a number ");
}
average = sum / 5.0;
Console.WriteLine($"Summa: {sum}, average: {average}.");