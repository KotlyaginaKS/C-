//  Программа на вход принимает два числа и проверяет, является ли первое число квадратом второго
Console.WriteLine("Введите два числа: ");
int num1, num2;
num1 = int.Parse(Console.ReadLine()!);
num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2 * numе2)
{
    Console.WriteLine($"Да. {num1} является квадратом {num2}.");
}
else 
{
    Console.WriteLine($"Нет. {num1} не является квадратом {num2}.");
}
