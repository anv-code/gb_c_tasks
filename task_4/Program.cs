﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число:  ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:  ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine("Число " + numberA + " самое большое из введённых");
}
else if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine("Число " + numberB + " самое большое из введённых");
}
else
{
    Console.WriteLine("Число " + numberC + " самое большое из введённых");
}