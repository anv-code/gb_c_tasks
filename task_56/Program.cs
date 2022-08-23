// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: ");
int[,] matrixResult = GetMatrix(4, 4);
int rowNumber = FindMinSumRow(matrixResult);

PrintMatrix(matrixResult);
Console.WriteLine(rowNumber + " строка c наименьшей суммой элементов");

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

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j == 0) Console.Write("[");
      if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + ", ");
      else Console.Write(matrix[i, j] + "]");
    }
    Console.WriteLine();
  }
}

int FindMinSumRow(int[,] matrix)
{
  int sum = 0;
  int row = 0;
  int min = Int32.MaxValue;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum += matrix[i, j];
    }

    if (min > sum)
    {
      row = i;
      min = sum;
    }
    
    sum = 0;
  }

  return row + 1;
}