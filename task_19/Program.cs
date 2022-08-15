// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

CheckPalindrome(number);

void CheckPalindrome(int num)
{ 
  if (Reverse(num) == num) Console.WriteLine(num + " -> да");
  else Console.WriteLine(num + " -> нет");
 
  int Reverse(int num)
  {
    int acc = 0;
    while (num > 0)
    {
      acc = acc * 10 + num % 10;
      num /= 10;
    }
    return acc;
  }
}

