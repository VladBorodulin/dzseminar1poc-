﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int a;
Console.Write("Введите число : ");
a = int.Parse(Console.ReadLine());
 
if (a % 2 == 0)
 
{
    Console.Write("Введенное число четное");
    Console.Read();
}
else
{
    Console.Write("Введенное число нечетное");
    Console.Read();
}