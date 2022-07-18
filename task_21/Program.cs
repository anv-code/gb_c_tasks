// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите кроординату X точки А: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кроординату Y точки А: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кроординату Z точки А: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кроординату X точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кроординату Y точки B: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кроординату Z точки B: ");
int bz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDistance(ax, ay, az, bx, by, bz));

double GetDistance(int axN, int ayN, int azN, int bxN, int byN, int bzN)
{
   return Math.Round(Math.Sqrt(Math.Pow(bxN - axN, 2) + Math.Pow(byN - ayN, 2) + Math.Pow(bzN - azN, 2)), 2);
}