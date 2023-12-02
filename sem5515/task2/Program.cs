//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 


System.Console.WriteLine("Enter number: ");
string str1 = Console.ReadLine();
System.Console.WriteLine("Enter number2: ");
string str2 = Console.ReadLine();
int num = Convert.ToInt32(str1);
int num2 = Convert.ToInt32(str2);
if (num2 * num2 == num)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

