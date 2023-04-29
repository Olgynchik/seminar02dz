// Задача 13: Напишите программу,
// которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if( num < 100)
{
    System.Console.WriteLine("Третий цифры нет" );
}
else
{
    while(num > 999)
    {
        num = num /10;
    }
    System.Console.WriteLine($"{num % 10}");
}