﻿//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num==6 || num==7)
{
    System.Console.WriteLine("является выходным");
}
else
{
    System.Console.WriteLine("НЕявляется выходным");
}
  