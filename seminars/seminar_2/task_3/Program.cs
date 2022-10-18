// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


int EnterNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num1 = EnterNumber("Enter a number 1 ");
int num2 = EnterNumber("Enter a number 2 ");

if (num2 % num1 == 0)
{
    Console.WriteLine($"{num2} times {num1}.");
}
else
{
    Console.WriteLine($"Remainder after dividing {num2} by {num1}: {num2 % num1}.");
}
