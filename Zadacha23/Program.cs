﻿// Задача 23

// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число N: ");
string text_N = Console.ReadLine();
double N = Convert.ToInt32(text_N);
double x = 1;
double y = 1;
while (x <= N)
{
    y = Math.Pow(x, 3);
    Console.WriteLine(y);
    x++;
}