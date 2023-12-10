//Задача 3: Напишите программу, которая принимает на вход 
//целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = GetNumber();

int num1 = number / 10;
int num2 = number % 10;
if (num1 > num2)
{
    Console.Write($"{num1}");
}
else
{
    Console.Write($"{num2}");
}

int GetNumber()
{
    Random rand = new Random();
    int num = rand.Next(10, 100);

    return num;
}