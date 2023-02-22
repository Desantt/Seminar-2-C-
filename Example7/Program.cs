// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1,
//  то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int value1 = Prompt("Введите первое число");
int value2 = Prompt("Введите второе число");
int number = value1% value2;
if (number == 0)
{
    System.Console.WriteLine($"{value2} является кратным числу {value1}");
}
else
{
    System.Console.WriteLine($"{value2} не кратно числу {value2}, остаток от деления = {number} ");
}