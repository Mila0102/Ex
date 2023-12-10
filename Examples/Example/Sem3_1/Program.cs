//Напишите программу, которая определяет, присутствует ли 
//заданное число в массиве. Программа должна выдать ответ: Да/Нет.

Console.WriteLine("Введите число ");
int [] array = new int [10];
FillArray(array);
PrintArray(array);

int number = Convert.ToInt32(Console.ReadLine());

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


bool FindNumber(int num, int[] list)
{
for (int i = 0; i < list.Length; i++)       //перебор элементов в массиве
{
    if (num == list[i])
    {
        return true;
    }
   
}
    return false;
}


if (FindNumber(number, array))
{
    Console.WriteLine("Да ");
}
else
{
Console.WriteLine("Нет");
}


void PrintArray(int [] col)
//void метод ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }

}

