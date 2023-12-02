//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

System.Console.WriteLine("Введите число ");
string str1 = Console.ReadLine();
int num = Convert.ToInt32(str1);
int numStart = num * -1;
while (numStart <= num)
{
    Console.WriteLine(numStart);
    ++numStart;
}
