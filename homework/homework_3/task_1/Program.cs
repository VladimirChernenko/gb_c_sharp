int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

bool ValidateNumber(int number)
{
    if (number > 9999 && number < 100000)
    {
        return true;
    }
    return false;
}

string Palindrome(int number)
{
    int number1 = 0;
    int number2 = number;
    for (int i = 4; i > -1; i--)
    {
        number1 += number2 % 10 * Convert.ToInt32(Math.Pow(10, i));
        number2 /= 10;
    }
    if (number == number1)
    {
        return "Yes";
    }
    return $"No";

}

int num = Prompt("Enter a number from 10000 to 99999 inclusive: ");

if (ValidateNumber(num))
{
    Console.WriteLine(Palindrome(num));
}
else
{
    Console.WriteLine("Input Error.");
}