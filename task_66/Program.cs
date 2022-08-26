// Задача 66:
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Задайте число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int sum = SumNaturalNumbers(numM, numN);

Console.WriteLine($"M = {numM}; N = {numN} -> {sum}");

int SumNaturalNumbers(int numM, int numN)
{
  if (numM == numN) return numM;
  if (numM < numN)
  {
    return numM + SumNaturalNumbers(numM + 1, numN);
  }
  else
  {
    return numN + SumNaturalNumbers(numN + 1, numM);
  }
}
