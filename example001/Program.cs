// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
  return new int[rows, columns];
}

void Fill2DArray(int[,] array)
{
    Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = rnd.Next(1, 10);
}

void Print2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j]}\t");
    Console.WriteLine();
  }
}

void BoubleSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if(array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;                    
                }
            }
        }
    }
}

int sizeRow = InputNum("Введите количество строк: ");
int sizeCol = InputNum("Введите количество столбцов: ");

int[,] array = Create2DArray(sizeRow, sizeCol);
Fill2DArray(array);
Print2DArray(array);
System.Console.WriteLine("\n\n");
BoubleSort(array);
Print2DArray(array);

