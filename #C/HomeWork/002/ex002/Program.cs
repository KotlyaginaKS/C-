﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int a;
a = int.Parse(Console.ReadLine()!);


if (a<100 && a > -100)
{
    Console.WriteLine("У данного числа отсутствует третья цифра");
}

else
{
     if (a>100 && a <1000)
     {
        {
        a = a % 10;
        }
        Console.WriteLine($"Третья цифра заданного числа: {a}");

     }

     if (a < -100 && a > - 1000)
     {
        {
        a = a % 10;
        a = a* -1;
        }
        Console.WriteLine($"Третья цифра заданного числа: {a}");

     }

     if (a < -1000)
    {
        {{
        while (a < -1000)
        a = a / 10;
        }
        a = a* -1;

        a = a % 10; 
        }
        Console.WriteLine($"Третья цифра заданного числа: {a}");
    }
       
    

      if (a > 1000)
      {
        {{
        while (a > 1000)
        a = a / 10;
        }
    
        a = a % 10;
        }
        Console.WriteLine($"Третья цифра заданного числа: {a}");
      }}
     
