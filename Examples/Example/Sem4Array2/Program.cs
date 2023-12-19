//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); 
//(1;1) и т.д.



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

int[,] array = FillArray(5, 5, 0, 10);
PrintArray(array);


int SummNumbers(int[,] list)
{
    int summ = 0;
    for (int i = 0; i < list.GetLength(0); i++)//кол-во строк
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            if(i == j)
            {
            summ = summ + list[i,j];
           
            }
        }

        Console.WriteLine();
    }
    return summ;
}

int sum = SummNumbers(array);
Console.WriteLine(sum);