// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру
// 456
// 782
// 918

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
bool Validate(int num)
{
    if (num >=100 && num <1000)
    {
        return true;
    }
    System.Console.WriteLine("Это число не трёхзначное");
    return false;

}
int number = Prompt("Введите трехзначное число");

if (Validate(number))
{
    int lastDigit = number % 10;
    System.Console.WriteLine($"Последния цифра числа {number} равна {lastDigit}");
}
