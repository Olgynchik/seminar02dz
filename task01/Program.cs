// напишите программу, которая принимает на вход пятизначное число
// и проверяет является ли оно палиндромом (зеркальным)
//что бы проверить палиндромное ли число можно преобразовать его в строку

System.Console.Write("Введите пятизначное число: ");
string? str = Console.ReadLine();
if(str.Length == 5)
{
    if(str[0]==str[4] && str[1]== str [3])
    {
        System.Console.WriteLine("yes");
    }
    else 
    {
        System.Console.WriteLine("no");
    }
}
else
{
    System.Console.WriteLine("Введите пятизначное число!");
}





