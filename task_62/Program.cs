// Задача 62.
// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.WriteLine("Программа спирально заполняет матрицу 4 на 4: ");
int[,] matrix = GetSpiralMatrix(4, 4);

PrintMatrix(matrix);

int[,] GetSpiralMatrix(int row, int col)
{
  int[,] matrix = new int[row, col];
  int rows = matrix.GetLength(0) - 1;
  int columns = matrix.GetLength(1) - 1; 
  int num = 1;
  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = i; j < columns; j++)
    {
      matrix[i, j] = num++;
    }

    for (int n = i; n < rows; n++)
    {
      matrix[n, rows] = num++;
    }

    for (int x = columns; x > i; x--)
    {
      matrix[rows, x] = num++;
    }

    for (int y = rows; y > i; y--)
    {
      matrix[y, i] = num++;
    }

    rows--;
    columns--;
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
      if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j].ToString("00") + ", ");
      else Console.Write(matrix[i, j].ToString("00") + "]");
    }
    Console.WriteLine();
  }
}