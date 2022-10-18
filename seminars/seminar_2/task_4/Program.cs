// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


int EnterNumber(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = EnterNumber("Enter a number ");

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Yes!");
}
else
    Console.WriteLine("No!");