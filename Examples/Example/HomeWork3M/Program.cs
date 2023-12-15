// Задача 3: Задайте массив из вещественных чисел 
// с ненулевой дробной частью. Найдите разницу между 
// максимальным и минимальным элементов массива.

double[] numbers = new double[5];
FillArray(numbers);
// PrintArray(numbers);
double max = MaxNumber(numbers);
Console.WriteLine($"{max}");
double min = MinNumber(numbers);
Console.WriteLine($"{min}");
double DiffNumber = max - min;
Console.WriteLine($"{DiffNumber}");

void FillArray(double[] collection)
{
    int length = collection.Length;
    int i = 0;
    while(i < length)
    {
        collection[i] = new Random().NextDouble();
        i++;
    }
}

//  void PrintArray(double [] array)
//  {
//      int size = array.Length;
//      int index = 0;
//      while(index < size)
//      {
//          Console.Write(array[index] + " ");
//          index++;
//      }
//  }

double MaxNumber(double[] col)
{
    int i = 1;
    double max = col[0];
    while(i < col.Length)
    {
        if(max < col[i])
        {
            max = col[i];
        }
        i++;
      
    }
   return max;
}


double MinNumber(double[] coll)
{
    int i = 1;
    double min = coll[0];
    while(i < coll.Length)
    {
        if(min > coll[i])
        {
            min = coll[i];
        }
        i++;
      
    }
   return min;
}

