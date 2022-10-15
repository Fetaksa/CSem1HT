// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое больше, а какое меньше.

Console.WriteLine("Привет! Эта программа может сравнить два целых числа");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Первое число больше второго");
}

else if (num1 < num2)
{
    Console.WriteLine("Первое число меньше второго");
}

else
{
    Console.WriteLine("Оба числа равны");
}