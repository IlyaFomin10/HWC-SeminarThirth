// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double GetDistanceTwoPoint(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x1-x2, 2) +Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
    return distance;
}

Console.WriteLine("Введите Х1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Х2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = GetDistanceTwoPoint(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");