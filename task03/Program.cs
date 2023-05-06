// напиши программу которая принимает на вход число n 
//и выдает таблицу кубов чисел от 1 до n
System.Console.WriteLine("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for( int ind = 1; ind < N; ind++)
{
    System.Console.Write($" {Math.Pow(ind,3)}"); 
}