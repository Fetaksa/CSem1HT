// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным.

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Это четное число");
}

else
{
    Console.WriteLine("Это НЕчетное число");
}