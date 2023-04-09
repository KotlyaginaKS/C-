// Сумма случайных чисел
int numA = new Random() .Next(1, 10); // 1 2 3 ....9
Console.WriteLine(numA);
int numB = new Random() .Next(1, 10);
Console.WriteLine(numB);
int result = numA + numB;
Console.WriteLine(result);
