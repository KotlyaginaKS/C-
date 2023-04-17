// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double DistanseXY(double ax, double bx, double zx, double ay, double by, double zy)
{
double distanse = Math.Pow(ax-ay, 2) + Math.Pow(bx-by, 2) + Math.Pow(zx-zy, 2);
distanse = Math.Sqrt(distanse);
return distanse;
}

System.Console.WriteLine ("Введите первое значение координаты по оси Х ");
double ax = double.Parse(Console.ReadLine()!);
System.Console.WriteLine ("Введите второе значение координаты по оси Y ");
double bx = double.Parse(Console.ReadLine()!);
System.Console.WriteLine ("Введите первое значение координаты по оси Z ");
double zx = double.Parse(Console.ReadLine()!);
System.Console.WriteLine ("Введите первое значение координаты по оси X ");
double ay = double.Parse(Console.ReadLine()!);
System.Console.WriteLine ("Введите второе значение координаты по оси Y ");
double by = double.Parse(Console.ReadLine()!);
System.Console.WriteLine ("Введите первое значение координаты по оси Z ");
double zy = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Расстояние между точками равно: " + DistanseXY(ax, bx, zx, ay, by, zy));