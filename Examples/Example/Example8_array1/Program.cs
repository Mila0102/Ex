//с использованием методов

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index ++;
    }
}

void PrintArray(int [] col)
//void метод ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)   
//возвращение позиции отличной от void
{
    int count = collection.Length;
    int index = 0;
    int position = -1; 
    //если не встречается ни одного не элемента
    //то по умолчанию возвращается -1
    //(если элемента нет)
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; 
//создай новый массив, в котором будет 10 элементов

FillArray(array); //метод заполнения массива
array[4] = 4;//исскуственно поставили на 4 место 
//число 4
array[6] = 4;

PrintArray(array); //метод вывода массива
Console.WriteLine();

int pos = IndexOf(array, 4);
//искомое число 4
Console.WriteLine(pos);