// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
Console.Write("Укажите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArr(size);
double diff = DiffMaxMin(array);

PrintArrayAndDiff(array, diff);

double[] CreateArr(int size)
{
  double[] arr = new double[size];
  Random random = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = Math.Round(random.NextDouble() * 100, 1);
  }

  return arr;
}

double DiffMaxMin(double[] arr)
{
  double min = arr[0];
  double max = arr[0];

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
  }

  double diff = Math.Round(max - min, 1);
  return diff;
}

void PrintArrayAndDiff(double[] arr, double diff)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i == 0) Console.Write("[");
    if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
    else Console.Write(arr[i] + "]");
  }
  
  Console.Write(" -> " + diff);
  Console.WriteLine();
}