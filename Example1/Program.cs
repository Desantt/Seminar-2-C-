int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int value1 = Prompt("Введите первое число");
int value2 = Prompt("Введите второе число");

int max = 0;
int min = 0;
if (value1 > value2)
{
    max = value1;
    min = value2;
}
else
{
    max = value2;
    min = value1;
}
System.Console.WriteLine($"Минимальное число {min}, максимальное число {max}");
