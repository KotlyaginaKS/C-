// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num <= 5 )
{
    Console.WriteLine("Будни");
}

else if (num >=6 &&  num <= 7)
{
    Console.WriteLine("Выходной");
}

else
{
    Console.WriteLine("Число не соответствет дням недели");
}



