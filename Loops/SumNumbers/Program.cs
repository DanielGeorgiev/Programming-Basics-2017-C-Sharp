﻿using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            sum += numbers;
        }
        Console.WriteLine(sum);
    }
}

