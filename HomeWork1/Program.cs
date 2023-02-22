//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
bool Validate(int num)
{
    if (num > 99) return true;
    {
        return false;
    }

}
int ShowThreeDigitNumber(int number)
{
    while(number >999)
    {
        number = number /10;
    }
    return number % 10;
}

int userNumber = Prompt("\nВведите 3х значное число и больше");
if (Validate(userNumber)) System.Console.WriteLine($"\nТретья цифра числа {userNumber} > {ShowThreeDigitNumber(userNumber)}");
else System.Console.WriteLine("\nТретьей цифры нет");