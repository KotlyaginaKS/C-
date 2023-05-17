// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//  Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool FigureCanExist(int[] sides)
{
    for(int i = 0; i < sides.Length; i++)
    {
        int sumOtherSides = 0;
        for (int j = 0; j < sides.Length; j++)
        {
            sumOtherSides += (j == i) ? 0 : sides [j];
        }
        if (sumOtherSides < sides [i]) return false;
    }
    return true;
}
System.Console.Write("Введите количество сторон:  ");
string num = Console.ReadLine()!;
int N = Int32.Parse(num);
int[] figure = new int[N];

for (int i = 0; i< N; i++)
{
    System.Console.Write($"Введите длинну стороны {i+1}:   ");
    num = Console.ReadLine()!;
    figure[i] = Int32.Parse(num);
}

System.Console.WriteLine($"Нарисовать такую фигуру возможно: {FigureCanExist(figure)}");