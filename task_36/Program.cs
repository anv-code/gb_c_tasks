// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Укажите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArr(size);
int count = SumOddPositionNumber(array);

PrintArrayAndCount(array, count);

int[] CreateArr(int size)
{
  int[] arr = new int[size];
  Random random = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = random.Next(-100, 100);
  }

  return arr;
}

int SumOddPositionNumber(int[] arr)
{
  int sum = 0;

  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 != 0) sum += arr[i];
  }

  return sum;
}

void PrintArrayAndCount(int[] arr, int sum)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i == 0) Console.Write("[");
    if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
    else Console.Write(arr[i] + "]");
  }
  
  Console.Write(" -> " + sum);
  Console.WriteLine();
}