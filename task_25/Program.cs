// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число которое будет возводиться в степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число-степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numberA + ", " + numberB + " -> " + MethodPow(numberA, numberB));

int MethodPow(int numA, int numB)
{
  int result = numA;
  
  for (int i = 1; i < numB; i++)
  {
    result *= numA;
  }

  return result;
}