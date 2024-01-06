// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int [] array = new int [4];

FillArray(array);
PrintArray(array);
NewArray(array);
PrintArray(array);

void FillArray(int[] collection, int index = 0)
{
    if(index < collection.Length)
    {
        collection[index] = new Random().Next(1, 15);
        FillArray(collection, index + 1);
    }
}

void PrintArray(int[] coll, int position = 0)
{
    
    if(position < coll.Length)
    {
        Console.Write(coll[position] + " ");
        PrintArray(coll, position + 1);
    }
}

void NewArray(int[] arr, int i = 0)
{
    int temp = 0;
    if(i < arr.Length/2)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = temp;
        NewArray(arr, i + 1);

    }
}