﻿
        // напишите программу , которая на вход принимает 3 числа , а на выходе выдаёт какое самое большее
        System.Console.WriteLine("Введите три числа ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int max =a;
        if ( a > b && a>c ) max = a;
        if ( b> a && b>c ) max = b;
        if ( c > a && c>b ) max = c;
        System.Console.WriteLine($"max = {max}");