// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива. 
// Указание Конструктор строки вида string(char []) 
// не использовать. 
// Пример [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


char[] arr = {'a', 'b', 'c', 'd'};
string st = "";
for (int i = 0; i < arr.Length; i++)
{
    st += arr[i];
}
Console.WriteLine(st);