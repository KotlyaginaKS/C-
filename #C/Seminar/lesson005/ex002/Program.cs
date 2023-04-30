// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = { -4, -8, 8, 2 };
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

int[] ReplacementArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]*=-1;   
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("{");
    Console.Write(String.Join(", ", array));
    System.Console.Write("}");
}
System.Console.WriteLine("Исходный");
PrintArray(array);
ReplacementArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Изначальный");
PrintArray(array);