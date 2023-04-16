﻿// Задача 19

// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно 
// палиндромом. (палиндром - число читается слева 
// направо и справа налево одинаково)

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] ==number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - да");
    }
    else
    {
        Console.WriteLine($"{number} - нет");
    }
}
else
{
    Console.WriteLine($"Ошибка: {number} - не пятизначное число");
}