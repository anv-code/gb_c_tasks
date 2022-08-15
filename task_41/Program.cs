// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Укажите кол-во чисел, которые хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
int count = CountPositiveNumbers(array);

PrintCount(count);

double[] CreateArray(int size)
{
  double[] arr = new double[size];

  for (int i = 0; i < size; i++)
  {
    Console.Write("Введите число #" + (i + 1) + ": ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }

  return arr;
}

int CountPositiveNumbers(double[] arr)
{
  int count = 0;

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0) count++;
  }

  return count;
}

void PrintCount(int count)
{
  Console.WriteLine();
  Console.WriteLine("Количество положительных чисел из введённых: " + count);
}