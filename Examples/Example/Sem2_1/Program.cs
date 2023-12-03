//случайное число из отрезка 10 до 99 и показ нибольшее

int number = GetNumber();

int num1 = number / 10; //78/10=7
int num2 = number % 10;//78%10 =8

if (num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}


int GetNumber()
{
    Random rand = new Random();
    int num = rand.Next(10, 100);

    return num;
}
