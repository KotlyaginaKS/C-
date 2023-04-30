// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, -3] -> нет
//-3; массив [6, 7, 19, 345, -3] -> да


void PrintArray(int[] array)
{
    System.Console.Write("{");
    Console.Write(String.Join(", ", array));
    System.Console.Write("}");
}

int[] FillArray(int size)
{
    int[] mass = new int[size];
    for (int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(1,10);
    }
    return mass;
}

int FindNumberToArray(int [] array, int find)
{
    int size = array.Length;
for (int i = 0; i < size; i++)
{
    if (array[i] == find)
    {
        return i;
    }
}
return -1;
}

int[] mass = FillArray(7);
PrintArray(mass);
System.Console.WriteLine();
int result = FindNumberToArray (mass, 5);
System.Console.WriteLine(result);