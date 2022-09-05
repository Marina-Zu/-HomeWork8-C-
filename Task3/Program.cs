/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива по формуле
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = new Random().Next(1, 5);
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

System.Console.WriteLine("Первая матрица");
int[,] array1 = FillArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array1);
System.Console.WriteLine("Вторая матрица");
int[,] array2 = FillArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array2);
System.Console.WriteLine("Произведение мартиц:");
int[,] array = MatrixProduct(array1, array2);
PrintArray(array);




