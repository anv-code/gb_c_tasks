// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int randomNum = new Random().Next(100, 1000);

int SecondNumber(int number)
{
    return (number / 10) % 10;
}

Console.WriteLine(randomNum + " -> " + SecondNumber(randomNum)); 