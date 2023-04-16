// Задача 21

// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите число x1: ");
string text_x1 = Console.ReadLine();
int x1 = Convert.ToInt32(text_x1);

Console.Write("Введите число y1: ");
string text_y1 = Console.ReadLine();
int y1 = Convert.ToInt32(text_y1);

Console.Write("Введите число z1: ");
string text_z1 = Console.ReadLine();
int z1 = Convert.ToInt32(text_z1);

Console.Write("Введите число x2: ");
string text_x2 = Console.ReadLine();
int x2 = Convert.ToInt32(text_x2);

Console.Write("Введите число y2: ");
string text_y2 = Console.ReadLine();
int y2 = Convert.ToInt32(text_y2);

Console.Write("Введите число z2: ");
string text_z2 = Console.ReadLine();
int z2 = Convert.ToInt32(text_z2);

double x = Math.Pow((x2 - x1), 2);
double y = Math.Pow((y2 - y1), 2);
double z = Math.Pow((z2 - z1), 2);
double AB = Math.Sqrt((x + y + z));
Console.WriteLine(" ");
Console.WriteLine($"Расстояние между точками А и В: {AB:f2}");