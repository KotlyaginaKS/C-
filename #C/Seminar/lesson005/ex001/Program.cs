// Задайте массив из 12 элементов заполненными числами в промежутке [9, -9]. Найдите сумму отрицательных и положительных элементов массива.

int[] GetRandomArray(int lenght=12, int minValue = -9, int maxValue = 9)
{
     int[] array = new int[lenght];

     var rnd = new Random();
     for (int i = 0; i < lenght; i++)
     {
        array[i] = rnd.Next(minValue, maxValue+1);
     } 
     return array;

}

//  Другой вариант написание этогоже 

void FillRandomArray(int[] array, int minValue = -9, int maxValue = 9) 
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue+1);
    }
}

//Один из варинтов

/*int SumPositiveNumber(int array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i]>0 ? array[i] : 0;
    }
    return sum;
}


int SumNegativNumber(int array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i] < 0 ? array[i] : 0;
    }
    return sum;
}
int[] mass1 = GetRandomArray();
*/

int FilterSum(int[] array, bool positive = true)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (positive)
        sum += array[i] > 0 ? array[i] : 0;
        else 
        sum += array[i] < 0 ? array[i] : 0;   
    }
    return sum;
}

int [] mass1 = GetRandomArray();

Console.WriteLine(string.Join(" ", mass1));
Console.WriteLine(FilterSum(mass1));
Console.WriteLine(FilterSum(mass1, positive : false));