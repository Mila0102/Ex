// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, состоящий из 
// средних арифметических значений по строкам 
// двумерного массива.

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

int [,] arr = FillArray(5, 5, 0, 10);
int[] arr_01 = new int [arr.GetLength(0)];
PrintArray(arr); //кол-во строк
for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
       sum +=arr[i, j];

    }
    arr_01[i] = sum/arr.GetLength(1);
}
Console.WriteLine($"[{String.Join(", " , arr_01)}]");
