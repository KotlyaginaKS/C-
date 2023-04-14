// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int GetRandonDigit (int minDigit = 100, int maxDigit = 999)
{
    int num = new Random().Next(minDigit, maxDigit + 1);
    return num;
}

int DeletSecondDigit(int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}

int num = GetRandonDigit();
Console.WriteLine(num);
Console.WriteLine(DeletSecondDigit(num));
