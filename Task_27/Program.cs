// Задача 27 Написать программу которая принимает на вход число и выдает сумму цифр в числе

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;
while (num > 0)
{
    int num1 = num % 10;
    num = num / 10;
    sum = sum + num1;
}
Console.WriteLine(sum);