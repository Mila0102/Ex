// Напишите программу, которая будет принимать на 
// вход число и возвращать сумму его цифр.

int number = GetNumber();


int GetNumber()
{
    Console.Write("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int sum = FindSum(number);

int FindSum(int number)
{
    if(number == 0) 
    {
        return 0;
    }

   return number%10 + FindSum(number/10);
    
}

Console.Write(sum);