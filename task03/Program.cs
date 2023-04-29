// : Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <=  5)
{
    System.Console.WriteLine("Рабочий день");
}
else if (num == 6 || num == 7)
{
    System.Console.WriteLine("Выходной");
}
else
{
    System.Console.WriteLine("Нет такой недели");
}