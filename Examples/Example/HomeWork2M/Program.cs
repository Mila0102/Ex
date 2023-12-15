// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет 
// количество чётных чисел в массиве.

int[] numbers = new int [10];
FillArray(numbers);
// PrintArray(numbers);
int count = FindNumber(numbers);

Console.WriteLine($"{count}");

void FillArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while(i < length)
    {
        collection[i] = new Random().Next(1, 101);
        i++;
    }

}

// void PrintArray(int [] array)
// {
//     int size = array.Length;
//     int index = 0;
//     while(index < size)
//     {
//         Console.Write(array[index] + " ");
//         index++;
//     }
// }

int FindNumber(int[] list)
{
    int count = 0;
for (int i = 0; i < list.Length; i++)       
{
    if(list[i] % 2 == 0)
    {
        count = count + 1;
    }
   
}
   return count;
}

