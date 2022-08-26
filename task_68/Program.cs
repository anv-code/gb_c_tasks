// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Задайте число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {numM}; n = {numN} -> A(m,n) = {Akerman(numM, numN)}");

int Akerman(int numM, int numN)
{
  if (numM == 0) return numN + 1;
  else if (numM > 0 && numN == 0) return Akerman(numM - 1, 1);
  else return Akerman(numM - 1, Akerman(numM, numN - 1));
}
