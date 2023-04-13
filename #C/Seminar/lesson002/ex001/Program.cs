// Программа, которая выводит случайное число из отрезка от 10 до 99 и показывает наибольшую цифру числа.


/*void MyFunction(int arg1, int arg2)
{
    Console.WriteLine($"arg1 = {arg1} arg2 = {arg2}");
}

MyFunction(6, 10);
*/

/*
void Hello(string name = "ksu")
{
    Console.WriteLine($"  Привет  {name}");
}

Hello();
*/

int GetRandonInt(int minValue = 10, int maxValue = 99)
{
    //int result = new Random().Next(10, 100);
    //return result;
    return new Random().Next(minValue,maxValue+1);
}
//int GetRandonInt(10, 99);

int GetMaxDigitTwo(int number)
{
    int digit1 = number % 10;
    int digit2 = number / 10;

    if (digit1 > digit2)
    {
        return digit1;
    }
    else
    {
        return digit2;
    }
}
/*
int max = digit1;
if (digit2 > max)
    max = digit2;
return max;
*/
int number = GetRandonInt();
int maxDigit = GetMaxDigitTwo(number);
Console.WriteLine(maxDigit);
