// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
//  Массив размером 2 x 2 x 2 
//  66(0,0,0) 25(0,1,0) 
//  34(1,0,0) 41(1,1,0) 
//  27(0,0,1) 90(0,1,1) 
//  26(1,0,1) 55(1,1,1) 
 
 
int InputNum(string message) 
{ 
    Console.WriteLine(message); 
    return int.Parse(Console.ReadLine()!); 
} 
 
int[,,] CreateArray(int size1, int size2, int size3) 
{ 
    return new int[size1, size2, size3]; 
} 
 
void FillArray(int[,,] arr) 
{ 
    Random rnd = new Random(); 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
            for (int k = 0; k < arr.GetLength(2); k++) 
            { 
                arr[i, j, k] = rnd.Next(10, 100); 
            } 
        } 
 
    } 
 
} 
 
 
 
void PrintArray(int[,,] arr) 
{ 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
            for (int k = 0; k < arr.GetLength(2); k++) 
            { 
                Console.Write(arr[i, j, k] + " "); 
            } 
        } 
 
    } 
    Console.WriteLine(); 
} 
 
void PrintResualt(int[,,] arr) 
{ 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(2); j++) 
        { 
            for (int k = 0; k < arr.GetLength(1); k++) 
            { 
                Console.Write($"{arr[j, k, i]}({j}, {k}, {i})"); 
            } 
            Console.WriteLine(); 
        } 
 
    } 
} 
 
int num = InputNum("Сайз1"); 
int num2 = InputNum("Сайз2"); 
int num3 = InputNum("Сайз3"); 
 
int[,,] Array = CreateArray(num, num2, num3); 
 
FillArray(Array); 
 
PrintArray(Array); 
 
PrintResualt(Array);
