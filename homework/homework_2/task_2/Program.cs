// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 46
// 782 -> 72
// 918 -> 98


int num1 = new Random().Next(100, 1000);
int num2 = new Random().Next(-999, -99);
int i = new Random().Next(0, 2);
int[] arr = {num1, num2};


int answer = arr[i] / 100 * 10 + arr[i] % 10;
Console.WriteLine($"The number {arr[i]} without the second digit: {answer}");