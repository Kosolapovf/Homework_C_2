﻿/* ЗАДАЧА №1 
    Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
/* ========================================================= */

/* Console.Clear();
int numbers = new Random().Next(100, 999);
int a = numbers / 10 % 10;
Console.Write($"{number} -> {a}"); */

/* ========================================================= */

/* ЗАДАЧА №2 
    Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
/* ========================================================= */

/* Console.Clear();
Console.Write("введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
while (numbers > 1000)
{
    numbers = numbers / 10;
}
if (numbers >= 100 && numbers <= 999)
    Console.WriteLine(numbers = numbers % 10);
else if (numbers <= 99)
    Console.WriteLine("третьей цифры нет"); */

/* ========================================================= */

/* ЗАДАЧА №3
    Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
=========================================================*/

/* Console.Clear();
int numbers = new Random().Next(1, 8);
Console.WriteLine(numbers);
if (numbers == 6 || numbers == 7 )
    Console.WriteLine("yes");
else
    Console.WriteLine("no"); */

/* ========================================================= */