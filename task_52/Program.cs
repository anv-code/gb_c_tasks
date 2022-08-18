// Задача 52.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Укажите кол-во строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrixResult = GetMatrix(rows, columns);
double[] averageColArr = GetAverageColumn(matrixResult);

PrintMatrix(matrixResult);
PrintAverageArr(averageColArr);

int[,] GetMatrix(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  Random random = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = random.Next(1, 10);
    }
  }

  return matrix;
}

void PrintMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (j == 0) Console.Write("[");
      if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ", ");
      else Console.Write(array[i, j] + "]");
    }

    Console.WriteLine();
  }

  Console.WriteLine();
}

double[] GetAverageColumn(int[,] matrix)
{
  double[] averageColumnArr = new double[matrix.GetLength(1)];
  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      averageColumnArr[j] += matrix[i, j];
      if (i == matrix.GetLength(0) - 1) averageColumnArr[j] /= matrix.GetLength(0);
    }
  }
  
  return averageColumnArr;
}

void PrintAverageArr(double[] arr)
{
  Console.Write("Среднее арифметическое каждого столбца: ");
  
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write(Math.Round(arr[i], 1) + ", ");
    else Console.Write(Math.Round(arr[i], 1) + ".");
  }
  
  Console.WriteLine();
}