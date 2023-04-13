//  Программа, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа 

int GetRandonDigit (int minDigit = 100, int maxDigit = 999)
{
    int num = new Random().Next(minDigit, maxDigit + 1);
    return num;
}

int DeletSecondDigit(int num)
{
    int num1 = num % 10;
    int num2 = num / 100;
    num = num1+ num2 * 10;
    return num;
}

int num = GetRandonDigit();
Console.WriteLine(num);
Console.WriteLine(DeletSecondDigit(num));