﻿// Напишите программу, которая на входе принимает число (N),
// а на выходе показывает все четные числа от 1 до N.

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= N; i++)
{if (i % 2 == 0)
{
    Console.WriteLine(i);
} 
}
