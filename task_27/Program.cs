// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число, сумму цифр которого хотите получить: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDig(number));

int SumDig(int num)
{
  int sum = 0;
  
  for (int i = 0; 0 < num; i++)
  {
    int dig = num % 10;
    sum += dig;
    num /= 10;
  }
  
  return sum;
}