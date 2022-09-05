//  Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
/*
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] FillArray(int numRow, int numColumns)
{
    int[,] matrix = new int[numRow, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}  ");     // Вывод значений очередной строки 
        }
        Console.WriteLine();    // Переход на следующую строку
    }
}

int[,] DecreaseOfRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int k = 0;
        while (k<array.GetLength(1) - 1)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j-1] < array[i, j])
                {
                    int temp = array[i, j-1];
                    array[i, j-1] = array[i, j];
                    array[i, j] = temp;
                }
            }
            k++;
        }
    }
    return array;
}

int[,] array = FillArray(3, 4);
PrintArray(array);
System.Console.WriteLine();
int[,] newarray = DecreaseOfRow(array);
PrintArray(newarray);