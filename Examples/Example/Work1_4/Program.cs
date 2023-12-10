//Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

string numberString = number.ToString();
char[] charArray = numberString.ToCharArray();

for (int i = 0; i < charArray.Length; i++)
{
   Console.Write($"{charArray[i]},\t");
}




