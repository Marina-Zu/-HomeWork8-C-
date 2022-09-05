// Задайте прямоугольный двумерный массив. 
/*Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива по формуле
{
    int[,] matrix = new int[numLine, numColumns];   // Создание нового массива
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = new Random().Next(-10, 10);      // Формула для заполнения массива
        }
    }
    return matrix;      // Возвращаем результат
}

void PrintArray2(int[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");     // Вывод значений очередной строки 
        }
        Console.WriteLine();    // Переход на следующую строку
    }
}

void PrintArray1(int[] a)
{
    int count = a.Length;
    int i = 0;
    System.Console.WriteLine("Сумма элементов в строках:");
    while (i < count)
    {
        Console.WriteLine($"{i + 1} -> {a[i]}\t");
        i++;
    }
}

int[] RowSum(int[,] array)
{
    int[] answer = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            answer[i] = sum;
        }
    }
    return answer;
}

int RowMinSum(int[] array) // массив в качестве параметра
{
    int rowMin = 0;
    int numMin = array[0];      // Используем параметр - массив
    for (int i = 0; i < array.Length; i++) // Объявляем  тут счетчик.
    {
        if (numMin > array[i])
        {
            numMin = array[i];
            rowMin = i;
        }
    }
    return rowMin;
}



int[,] array = FillArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray2(array);
System.Console.WriteLine();
int[] newarray = RowSum(array);
PrintArray1(newarray);
System.Console.WriteLine($"Строка с минимальной суммой элементов -> {RowMinSum(newarray) + 1}");

