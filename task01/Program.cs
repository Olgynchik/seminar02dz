﻿
Console.WriteLine("Введите пятизначное число: ");
string? num = Console.ReadLine();
if (num[0] == num[4] || num[1] == num[3])
{
    Console.WriteLine($"Yes");
}

else 
{
    Console.WriteLine($"No");
}