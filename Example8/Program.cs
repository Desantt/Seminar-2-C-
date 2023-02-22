// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да
int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int value1 = Prompt("Введите число");
int divider1 = Prompt("Введите число 1");
int divider2 = Prompt("Введите число 2");
if (value1 % divider1 == 0 && value1 % divider2 == 0)
{
    System.Console.WriteLine($"Число {value1} кратно одновременно {divider1} и {divider2}");
}
else
{
    System.Console.WriteLine($"Число {value1} не кратно");
}