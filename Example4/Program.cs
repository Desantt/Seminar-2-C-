int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int Value1 = Prompt("Введите число");
int count = 2;
while (count <= Value1)
{
    System.Console.WriteLine(count);

    count += 2;
}