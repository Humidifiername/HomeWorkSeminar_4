// Задача 25
// Написать цикл, который принимает на вход два числа (A и B) и возводит числсо A в натуральную степень числа B

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int power = A;
for (int i = 1; i < B; i++)
{
    power = power * A;
}
Console.WriteLine(power);