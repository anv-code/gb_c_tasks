// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;

CrossPoint(b1, k1, b2, k2);

void CrossPoint(double b1, double k1, double b2, double k2)
{
  x = (b2 - b1) / (k1 - k2);
  y = k1 * x + b1;
}

Console.WriteLine();
Console.WriteLine("b1 = " + b1 + ", k1 = " + k1 + ", b2 = " + b2 + ", k2 = " + k2 + " -> (" + Math.Round(x, 1) + "; " + Math.Round(y, 1) + ")");