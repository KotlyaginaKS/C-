// Программа, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти по X Y

string intervals(int q)
{
    string intervals = "Ошибка";

    if (q==1) intervals = "x in (0; +inf); y in (0; + inf)";
    else if (q==2) intervals = "x in (-inf; 0); y in (0; + inf)";
    else if (q==3) intervals = "x in (-inf; 0); y in (-inf; 0)";
    else if (q==4) intervals = "x in (0; +inf); y in (-inf; 0)";

    return intervals;

}

Console.WriteLine("Введите номер плоскости: ");
int q = Convert.ToInt32(Console.ReadLine()!);

System.Console.WriteLine(intervals(q));