// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

int[,] Multiply(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(0); j++)
        {
            int res = 0;
            for (int k = 0; k < array1.GetLength(0); k++)
            {
                res += array1[i, k] * array2[k, j];
            }
            result[i,j] = res;
        }
    }
    return result;
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
      array[i, j] = rnd.Next(1, 5);
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

int sizeRow = InputNum("Введите количество строк: ");
int sizeCol = InputNum("Введите количество столбцов: ");
int[,] array = Create2DArray(sizeRow, sizeCol);
Fill2DArray(array);

sizeRow = InputNum("Введите количество строк: ");
sizeCol = InputNum("Введите количество столбцов: ");
int[,] array2 = Create2DArray(sizeRow, sizeCol);
Fill2DArray(array2); 

Print2DArray(array);

System.Console.WriteLine("\n\n");

Print2DArray(array2);
System.Console.WriteLine("\n\n");
Print2DArray(Multiply(array, array2));

