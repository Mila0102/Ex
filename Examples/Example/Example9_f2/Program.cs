//Циклы
//string Method4(int count, string text) 
//{
 // string result = String.Empty;   
  //for(int i = 0; i < count; i++)
  //{
  //  result = result + text;
 // }
  //return result;
//}

//string res = Method4(10, "asdf"); 
//Console.WriteLine(res);


//Задача таблица умножения

//for (int i = 2; i <= 10; i++)
//{
  //for (int j = 2; j <= 10; j++)
  //{
    //Console.WriteLine($"{i} * {j} = {i * j}");
  //}
  //Console.WriteLine(); //Вывод на новую строку
//}

//Дан текст. В тексте нужно все пробелы заменить 
//черточками, маленькие буквы "К" заменить
//большими "К", а большие "С" заменить маленькими
//"с"


//string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
           // + "ежели бы вас послали вместо нашего милого Винцегероде, "
          //  + "Вы бы взяли приступом согласие прусского короля. "
            //+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3]  // r

//string Replace(string text, char oldValue, char newValue)
//{
    //string result = String.Empty;

    //int lenght = text.Length;
    //for (int i =0; i < lenght;i ++)
    //{
       // if(text[i] == oldValue) result = result + $"{newValue}";
       // else result = result + $"{text[i]}";
    //}

    //return result;
//}
//string newText = Replace(text, ' ', '|');

//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText);

//Упорядочивание массива

//6 8 3 2 1 4 5 7

int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
   for (int i = 0; i < array.Length - 1 ; i++) 
   {
       int minPosition = i;
  
       for (int j = i + 1; j < array.Length ; j++) 
       //ищем минимальное значение
       {
        if(array[j] < array[minPosition]) minPosition = j;
       }

       int temporary = array[i];
       array[i] = array[minPosition];
       array[minPosition] = temporary;
   }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);