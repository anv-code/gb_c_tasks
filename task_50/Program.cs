// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.Write("Укажите позицию элемента в строке массива: ");
int ElRowPos = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите позицию элемента в столбце массива: ");
int ElColPos = Convert.ToInt32(Console.ReadLine());
int[,] matrixResult = GetMatrix(3, 4);

PrintMatrix(matrixResult);
PrintNumber(matrixResult, ElRowPos, ElColPos);

int[,] GetMatrix(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  Random random = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = random.Next(1, 100);
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

  Console.WriteLine();
}

void PrintNumber(int[,] matrix, int ElRowPos, int ElColPos)
{
  if (ElRowPos <= matrix.GetLength(0) && ElColPos <= matrix.GetLength(1))
  {
    Console.Write($"{ElRowPos}, {ElColPos} -> {matrix[ElRowPos - 1, ElColPos - 1]}");
  }
  else Console.Write($"{ElRowPos}, {ElColPos} -> такого числа в массиве нет");
  
  Console.WriteLine();
}