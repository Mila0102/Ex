//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

Console.WriteLine("Введите число ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);
if (num >99&& num<1000)
{
    int num2 = num%10;
    Console.WriteLine(num2);
}
else 
{
    Console.WriteLine("Некорректное число");
}