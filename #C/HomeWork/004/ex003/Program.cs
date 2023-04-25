// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Ввод числа с экрана

int Promt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

// Метод для получения случайных значений массива
int[] GnerateArray (int Length, int minValue, int maxValue)
{
    int[] array = new int [Length]; //объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
System.Console.Write($"{array[array.Length - 1]}");
System.Console.WriteLine("]"); 
}

int lenght = Promt("Длинна массива: ");
int min = Promt("Минимальное значение массива: ");
int max = Promt("Максимальное значение  ");
int[] array = GnerateArray(lenght, min, max);
PrintArray(array);