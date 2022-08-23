// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[,,] matrix3D = Get3DMatrix(2, 2, 2);
Print3DMatrix(matrix3D);

int[,,] Get3DMatrix(int row, int col, int col2)
{
  int num = 10;
  int[,,] matrix3D = new int[row, col, col2];
  
  for (int i = 0; i < matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
      for (int n = 0; n < matrix3D.GetLength(2); n++)
      {
        matrix3D[i, j, n] = num;
        num++;
      }
    }
  }
  
  return matrix3D;
}

void Print3DMatrix(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int n = 0; n < array.GetLength(2); n++)
      {
        Console.Write($"{array[i, j, n]}({i},{j},{n}) ");
      }
      Console.WriteLine();
    }
  }
}

