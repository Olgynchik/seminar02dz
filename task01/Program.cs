﻿// напишите программу которая на вход принимает 
//трехзначное число, а на выход показывает второе
System.Console.WriteLine("Введите  число от 100 до 999 ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 999)
{
    System.Console.WriteLine(num / 10 % 10);
}
else
{
    System.Console.WriteLine("Введите трех значное число");
}