/*  Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/



int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] FillArray(int numLine, int numColumns)
{
    int[,] matrix = new int[numLine, numColumns];
    int element = 1;
    int j = 0;
    int i = 0;
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    while (sum <= row * column)
    {
        matrix[i, j] = element;
        if (i < row){
            
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
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
/*
int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)         
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)   
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)     
            {
                int sum = 0;
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    sum = sum + matrix1[i, k] * matrix2[k, j];
                }
                matrix[i, j] = sum;
            }
        }
    }
    else System.Console.WriteLine("Невозможно выполнить умножение");
    return matrix;
}
*/
int[,] array = FillArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array);






