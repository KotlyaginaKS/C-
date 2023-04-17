// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - является палиндромом.");
  }
  
  else Console.WriteLine($"Ваше число: {number} - НЕ является палиндромом.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Число не является пятизначным, ошибка, перезапустите программу");