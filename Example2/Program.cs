int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int a =Prompt("Введите первое число");
int b =Prompt("Введите второе число");
int c =Prompt("Введите третье число");

int max = a;

if(b > max)
{
    max=b;
}
if(c > max)
{
    max=c;
}
System.Console.WriteLine($"Максимальное число {max}");