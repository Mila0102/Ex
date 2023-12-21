// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива. 
// Указание Конструктор строки вида string(char []) 
// не использовать. 
// Пример [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”
using System.Text;

char[] arr = {'a', 'b', 'c', 'd'};
string st = "";

StringBuilder strB = new StringBuilder();
for (int i = 0; i < arr.Length; i++)
{
    // st += arr[i];
 strB.Append(arr[i]);
}
Console.WriteLine(strB.ToString());