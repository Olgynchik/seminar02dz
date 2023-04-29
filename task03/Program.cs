// : Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 7)
{
     if(num <= 5)
   {
    System.Console.WriteLine("будни");
   }
    System.Console.WriteLine("Выходной");
}
else if (num > 7)
{
    System.Console.WriteLine("error");
}