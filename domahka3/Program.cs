﻿//  4 -> да
// -3 -> нет
//  7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.WriteLine(number + " чётное число");
}
else
{
    Console.WriteLine(number + " нечётное число");
}