// Семинар 8. Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int RandomNumberBetween(Random rnd)
{
    return rnd.Next(0, 10);
}

void GoodPrint(int[,] matrix, int rowsNumber, int columnsNumber)
{
    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            Console.Write(matrix[rowIndex, columnIndex]);

            if (columnIndex != columnsNumber - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}


int GetIntFromConsole(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

void FillArray(int[,] matrix, Random rnd)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            matrix[rowIndex, columnIndex] = RandomNumberBetween(rnd);
        }
    }
}

int GetMinSum(int[,] matrix, int rowIndex, int columnsNumber)
{
    int sum = 0;
    for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
    {
        sum = sum + matrix[rowIndex, columnIndex];
    }

    return sum;
}

void PrintMinSumRowNumber(int[,] matrix, int rowsNumber, int columnsNumber)
{
    int minSumRowIndex = 0;
    int minSum = GetMinSum(matrix, minSumRowIndex, columnsNumber);

    for (int rowIndex = 1; rowIndex < rowsNumber; rowIndex++)
    {
        int iteratedRowSum = GetMinSum(matrix, rowIndex, columnsNumber);

        if (iteratedRowSum < minSum)
        {
            minSumRowIndex = rowIndex;
            minSum = iteratedRowSum;
        }
    }

    Console.WriteLine($"Строка {minSumRowIndex + 1}");
}

int rowsNumber = GetIntFromConsole("Введите количество строк: ");
int columnsNumber = GetIntFromConsole("Введите количество столбцов: ");
int[,] matrix = new int[rowsNumber, columnsNumber];
FillArray(matrix, new Random());
GoodPrint(matrix, rowsNumber, columnsNumber);

Console.WriteLine(new string('-', columnsNumber * 3));

PrintMinSumRowNumber(matrix, rowsNumber, columnsNumber);