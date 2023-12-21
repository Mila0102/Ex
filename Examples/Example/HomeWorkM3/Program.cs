// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

int[,] array = FillArray(3, 4, 1, 10);

PrintArray(array);
FindRow(array);

int[,] FillArray (int rows, int columns, int minValue, int maxValue)
{
    Random rand = new Random();
    int[,] array = new int[rows, columns];

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            Console.Write(array[i, l] + " ");
        }
        Console.WriteLine();
    }
}

void FindRow(int[,] array)
{
    int minRow = int.MaxValue;
    int minRowIndex = 0;
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int l = 0; l < array.GetLength(1); l++)
        {
            
            sum = sum + array[i, l];
        }
        if(minRow > sum)
        {
            minRow = sum;
            minRowIndex = i;
        }
        
    }
    
Console.WriteLine($"{minRowIndex}");

}