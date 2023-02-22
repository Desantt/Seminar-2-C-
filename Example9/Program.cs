// напишите программу, которая выводит случайное число (10. 9999) и показывает наибольшую цифру числа
// 7812
// 1213
// 845
int number = new Random().Next(10, 9999);
int digit1=number / 10; 
int digit2=number %10;
int max = digit1;
if(digit2>max)
{
    max=digit2;
}
System.Console.WriteLine($"Наибольшая цифра числа {number} = {max}");