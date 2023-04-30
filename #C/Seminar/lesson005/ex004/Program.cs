// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int [] GetRandomArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

void PrintArray (int[] array)
{
    System.Console.Write("{");
    Console.Write(String.Join(", ", array));
    System.Console.Write("}");
}

int[] ProductPairsNumber(int[] arr)
{
    int[] arr2 = new int[(arr.Length+1)/2];
    for (int i = 0; i < arr.Length /2; i++)
    {
        // arr2[i] = arr[i]*arr[arr.Lenght-1-i];
        arr2[i] = arr[i]*arr[^(i+1)];
    }
    if (arr.Length % 2 != 0)
    {
         // arr2[arr2.Lenght-1] = arr[arr.Lenght / 2];
         arr2[^1] = arr [arr.Length/2];
    }
    return arr2;
}

int [] mass1 =GetRandomArray(5,1,8,);
PrintArray(mass1);
System.Console.WriteLine();
int[] mass2 = ProductPairsNumber(mass1);
PrintArray(mass2);