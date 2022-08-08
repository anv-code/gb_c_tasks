// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.WriteLine("Полученный массив: ");

int[] arr = new int[8];

Console.Write("[");

for (int i = 0; i < arr.Length; i++)
{
  int randomNum = new Random().Next(0, 100);
  
  if (i != arr.Length - 1) Console.Write((arr[i] = randomNum) + ", ");
  else Console.Write(arr[i] = randomNum);
}

Console.Write("]");
Console.WriteLine();


