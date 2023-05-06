// напиши программу которая принимает на вход кооринаты двух точек 
// и находит расстояние между ними в 3 д пространстве

// System.Console.WriteLine("Введите Х точки А");
// int coordsA = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите Y точки А");
// int coordsA = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите Х точки B");
// int coordsB = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите Y точки B");
// int coordsB = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите Х точки Z");
// int coordsZ = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите Y точки Z");
// int coordsZ = Convert.ToInt32(Console.ReadLine());

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] coordsA = new int[3];
coordsA[0]= ReadInt("Введите координату Х точки А");
coordsA[1]= ReadInt("Введите координату Y точки А");
coordsA[2]= ReadInt("Введите координату Z точки А");

int[] coordsB = new int[3];
coordsB[0]= ReadInt("Введите координату Х точки B");
coordsB[1]= ReadInt("Введите координату Y точки B");
coordsB[2]= ReadInt("Введите координату Z точки B");

double distant = Math.Sqrt(Math.Pow(coordsA[0]-coordsB[0],2) + Math.Pow(coordsA[1]-coordsB[1],2) + Math.Pow(coordsA[2]-coordsB[2],2));
System.Console.WriteLine(Math.Round(distant,3));