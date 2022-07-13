// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int randomNum = new Random().Next(10, 1000);
int coupleNum = randomNum / 100;

int ThirdNum(int number)
{
    return number % 10;
}

if (coupleNum == 0) Console.WriteLine($"{randomNum} -> Третьей цифры нет");
else Console.WriteLine($"{randomNum} -> {ThirdNum(randomNum)}");




