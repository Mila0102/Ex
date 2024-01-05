// Задача 2: Напишите программу вычисления функции Аккермана 
// c помощью рекурсии. Даны два неотрицательных числа m и n.
using System;

class Program
{
  static void Main(string[] args)
   {
    int m = 2;
    int n = 1;
    int result = FuncAck(m, n);
    Console.WriteLine($"{result}");
   }

  static int FuncAck(int m, int n)
   {
    if(m == 0)
    {
        return n + 1;
    }
    else if((m > 0) && (n == 0))
    {
        return FuncAck(m-1, 1);
    }
    else if((m > 0) && (n > 0))
    {
        return FuncAck(m - 1, FuncAck(m, n - 1));
    }
    else 
    {
        return -1;
    }
   }

}