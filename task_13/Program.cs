// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void ThirdDig(int number)
{
    string numberStr = Convert.ToString(number);

    if (numberStr.Length > 2) Console.WriteLine($"{number} -> {numberStr[2]}");
    else Console.WriteLine($"{number} -> Третьей цифры нет");
}

ThirdDig(num);

