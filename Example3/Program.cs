int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int Value = Prompt("Введите число");
if (Value % 2 == 0)
{
    System.Console.WriteLine($"Число {Value} четное число");
}
else
{
    System.Console.WriteLine($"Число {Value} нечетное число");
}