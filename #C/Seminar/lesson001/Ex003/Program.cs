// На вход принимает число, на выходе выдает его квадрат
Console.Write("Введите число, которое необходимо возвести в квадрат: ");
string input = Console.ReadLine()!;
int num = int.Parse(input);
int square = num * num;

Console.WriteLine($"Квадрат числа {num} равен {square}.");