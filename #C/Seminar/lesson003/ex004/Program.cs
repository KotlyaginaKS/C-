// Программа, которая принимает на вход координаты двух точек и находит рассстояние между ними в 2Д пространстве

double DistanseXY(double ax, double bx, double ay, double by)
{
double distanse = Math.Pow(ax-ay, 2) + Math.Pow(bx-by, 2);
distanse = Math.Sqrt(distanse);
return distanse;
}

System.Console.WriteLine ("Введите первое значение координаты по оси Х ");
double ax = double.Parse(Console.ReadLine()!);
System.Console.WriteLine ("Введите второе значение координаты по оси Y ");
double bx = double.Parse(Console.ReadLine()!);
System.Console.WriteLine ("Введите первое значение координаты по оси X ");
double ay = double.Parse(Console.ReadLine()!);
System.Console.WriteLine ("Введите второе значение координаты по оси Y ");
double by = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Расстояние между точками равно: " + DistanseXY(ax, bx, ay, by));