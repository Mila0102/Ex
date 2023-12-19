//int[,] matrix = new int[5,5] МАТРИЦЫ


// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти 
// элементы на их квадраты.

int[,] array = FillArray(3, 5, 1, 10);

int[,] FillArray(int columns, int rows, int minValue, int maxValue)
{
   int[,] array = new int [rows, columns];
   Random rand = new Random();
   for (int i = 0; i < rows; i++)
   {

    for (int l = 0; l < columns; l++)
    {
        array[i, l] = rand.Next(minValue, maxValue + 1);
    }
   }
   return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)//кол-во строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}
PrintArray(array);
FindIndex(array);
PrintArray(array);
void FindIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)//кол-во строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j %2 ==0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }

        }
        
    }
}

