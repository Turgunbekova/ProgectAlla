﻿//*Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 228


Console.Write($"Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
 if (max<b) max = b;
 if (max<c) max=c;
Console.Write($"max= ");
Console.WriteLine(max);




