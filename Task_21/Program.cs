﻿// //Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


//double answer = Math.Sqrt(100);
// double sqr = Math.Pow(100, 3);
//Console.WriteLine(sqr);

/* sqrt((x2 - x1)^2 + (y2-y1)^2) */

Console.WriteLine("Введите координаты  x1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты y1");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты x2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты y2");
int y2 = int.Parse(Console.ReadLine()!);

double answer = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
//double sqr1 = Math.Pow((x1-x2), 2);    вариант 2 
//double sqr2 = Math.Pow((y1-y2), 2);    вариант 2 , больше кода иногда лучше 

Console.WriteLine(Math.Round(answer, 3));   //округление с помощью Math.Round  округление  до второго символа
// Console.WriteLine(Math.Round(Math.Sqrt(sqr1 + sqr2), 3));     2 вариант 