// Задача 2: Задайте двумерный массив. Напишите 
// программу, которая поменяет местами 
// первую и последнюю строку массива.

int[,] array = FillArray(3, 5, 2, 15);

PrintArray(array);
ChangingOfRow(array);
PrintArray(array);

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    Random rand = new Random();
    int [,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            array[i, l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //строки
    {
        for (int l = 0; l < array.GetLength(1); l++) //столбцы
        {
            Console.Write(array[i, l] + " ");
        }
        Console.WriteLine();
    }
}

void ChangingOfRow(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] emptyRow = new int[columns];
    for (int i = 0; i < rows / 2; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            emptyRow[j] = array[i, j];
            array[i, j] = array[rows - i - 1, j];
            array[rows - i - 1, j] = emptyRow[j];
        }
    }
}

