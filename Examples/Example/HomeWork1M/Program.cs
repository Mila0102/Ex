//Задача 1: Задайте одномерный массив из 10 целых 
//чисел от 1 до 100. Найдите количество элементов 
//массива, значения которых лежат в отрезке [20,90].

int [] array = new int [10];
FillArray(array);
PrintArray(array);
int count = FindNumber(array);

Console.WriteLine($"{count}");

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 101);
        //index = index + 1;
        index ++;
    }
}

 void PrintArray(int [] col)
// //void метод ничего не возвращает
 {
     int count = col.Length;
     int position = 0;
     while (position < count)
     {
         Console.Write(col[position] + " ");
         position++;
     }

 }

int FindNumber(int[] list)
{
    int count = 0;
for (int i = 0; i < list.Length; i++)       
{
    if (list[i] > 19 && list[i] < 91)
    {
        count = count + 1;
    }
   
}
   
   return count;
}




