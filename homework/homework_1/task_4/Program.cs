// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


int[] numbers = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter the number");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int max = numbers[0];
for (int i = 1; i < 3; i++)
{
    if (numbers[i] > max) 
    {
        max = numbers[i];
    }
}
 Console.WriteLine($"Max number: {max}");