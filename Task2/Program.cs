﻿/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

456 -> 46
782 -> 72  */

int r = new Random().Next(100, 1000);
Console.WriteLine($"Ваше число: {r}");
Console.WriteLine("Без средней цифры: " + r/100 + "" + r%10);