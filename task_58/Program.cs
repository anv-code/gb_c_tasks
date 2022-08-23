// Задача 58:
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Укажите кол-во строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = GetMatrix(rows, columns);
int[,] secondMatrix = GetMatrix(rows, columns);
int[,] multiMatrix = MultiMatrix(firstMatrix, secondMatrix);

Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);
Console.WriteLine("Результирующая матрица:");
PrintMatrix(multiMatrix);

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

int[,] MultiMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
  int[,] multiMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
  
  for (int i = 0; i < firstMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
      multiMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
    }
  }
  
  return multiMatrix;
}
