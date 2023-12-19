// Задача 1: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, 
// что такого элемента нет.

Console.WriteLine("Введите строку");
int indexRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец");
int indexCol = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(3, 5, 1, 10);

PrintArray(array);
FindNumber(array);

int[,] FillArray(int columns, int rows, int minValue, int maxValue)
{
    Random rand = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            array [i, l] = rand.Next(minValue, maxValue +1); 
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            Console.Write(array[i, l] + " ");
        }
        Console.WriteLine();
    }
}

int FindNumber(int[,] array)
{
    int b = 0;
    if (indexRow < array.GetLength(0) && indexCol < array.GetLength(1))
    {
        b = array[indexRow, indexCol];
        Console.Write($"{b}");
        return b;
    }
    else
    {
        Console.WriteLine("Данного элемента в массиве нет");
     return -1;
    }
   

}