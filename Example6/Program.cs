// Напишите программу которая выводит случайное число из отрезка (10, 99) и показывает наибольшее из них 
// 78
// 12
// 85

int number = new Random().Next(10, 10000);
System.Console.WriteLine(number);

int max = 0;

while (number > 0)
{
    if (max < number % 10)
    {
        max = number % 10;
    }
   number /= 10;
}

System.Console.WriteLine($"Наибольшая цифра числа {max}");