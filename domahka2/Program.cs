﻿//   2 3 7 -> 7
//   44 5 78 -> 78
//   22 3 9 -> 22

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a >= b) && (a >= c))
{
    Console.WriteLine("Число " + a + " максимальное");
}
else 
if ((b >= a) && (b >= c))
{
    Console.WriteLine("Число " + b + " максимальное");
}
else 
if ((c >= a) && (c >= b))
{
    Console.WriteLine("Число " + c + " максимальное");
}