// Task 0.
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Console.WriteLine("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Square number: {num*num}");




// Task 1.
// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

// Console.WriteLine("Number 1");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Number 2");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x*x == y) {Console.WriteLine("True");}
// else {Console.WriteLine("False");}


// Task 2.
// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Enter a number from 1 to 7");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x < 1 || x > 7)
// {
//     Console.WriteLine("Error");
// }
// if (x == 1)
// {
//     Console.WriteLine("Monday");
// }
// if (x == 2)
// {
//     Console.WriteLine("Tuesday");
// }
// if (x == 3)
// {
//     Console.WriteLine("Wednesday");
// }
// if (x == 4)
// {
//     Console.WriteLine("Thursday");
// }
// if (x == 5)
// {
//     Console.WriteLine("Friday");
// }
// if (x == 6)
// {
//     Console.WriteLine("Saturday");
// } 
// if (x == 7)
// {
//     Console.WriteLine("Sunday");
// }




// Task 3.
// 3. Напишите программу вычисления функции:
//  f(a) = a^3

// Console.WriteLine("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Square number: {num*num*num}");




// Task 4.
// 4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine()), x = -num;
// if (num > 0)
// {
//     while (x < num)
//     {
//         Console.Write($"{x}, ");
//         x++;
//     }
//     Console.Write($"{x}");
// }
// else
// {
//     while (x > num)
//     {
//         Console.Write($"{x}, ");
//         x--;
//     }
//     Console.Write($"{x}");
// }




// Task 5.
// *. Напишите программу вычисления модуля числа.
// 	2 -> 2
// 	-3 -> 3
// 	-7 -> 7

// Console.WriteLine("Enter the number:");
// int num = Convert.ToInt32(Console.ReadLine()), x;
// if (num < 0)
// {
//     x = -num;
// }
// else
// {
//     x = num;
// }
// Console.WriteLine($"The absolute value of a number {num}: {x}");




// Task 6.
// **. Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

// Console.WriteLine("Enter the number:");
// double num = Convert.ToDouble(Console.ReadLine()), x;
// x = 1 / num;
// Console.WriteLine($"Reciprocal of a number {num}: {x}");