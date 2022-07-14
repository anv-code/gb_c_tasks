// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру от 1 до 7 обозачающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void Weekend(int number)
{
    if (number == 6 || number == 7) Console.WriteLine(number + " -> да");
    else if (number > 7 || number < 1) Console.WriteLine("Указанное число находится вне диапазона");
    else Console.WriteLine(number + " -> нет");  
}

Weekend(num);


