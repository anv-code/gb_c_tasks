// Задача 54:
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("Программа упорядочивает по убыванию элементы каждой строки двумерного массива: ");
int[,] matrixResult = GetMatrix(4, 3);

PrintMatrix(matrixResult);
Console.WriteLine("Получившийся массив: ");
SortMatrix(matrixResult);
PrintMatrix(matrixResult);

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

void SortMatrix(int[,] matrix)
{
  int temp;
  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
      for (int n = j + 1; n < matrix.GetLength(1); n++)
      {
        if (matrix[i, j] < matrix[i, n])
        {
          temp = matrix[i, j];
          matrix[i, j] = matrix[i, n];
          matrix[i, n] = temp;
        }
      }
    }
  }
}