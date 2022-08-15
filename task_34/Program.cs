// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Укажите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArr(size);
int count = CountHonestNumber(array);

PrintArrayAndCount(array, count);

int[] CreateArr(int size)
{
  int[] arr = new int[size];
  Random random = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = random.Next(100, 1000);
  }

  return arr;
}

int CountHonestNumber(int[] arr)
{
  int count = 0;

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0) count++;
  }

  return count;
}

void PrintArrayAndCount(int[] arr, int count)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i == 0) Console.Write("[");
    if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
    else Console.Write(arr[i] + "]");
  }
  
  Console.Write(" -> " + count);
  Console.WriteLine();
}




