﻿// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{

static void ShowNumbers(int m, int n)
{
    Console.WriteLine(m);
    if(m < n) 
    {
    m++;
    ShowNumbers(m, n);
    }
    
}

static void Main(string[] args)
{
    
    Console.WriteLine("Введите число M ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N ");
    int n = Convert.ToInt32(Console.ReadLine());
    ShowNumbers(m, n);
}

}


