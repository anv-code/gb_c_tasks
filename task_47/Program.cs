// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Укажите кол-во строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] matrixResult = GetMatrix(rows, columns);

PrintMatrix(matrixResult);

double[,] GetMatrix(int rows, int columns)
{
  double[,] matrix = new double[rows, columns];
  Random random = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = Math.Round(random.NextDouble() * 10, 1);
    }
  }

  return matrix;
}

void PrintMatrix(double[,] matrix)
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