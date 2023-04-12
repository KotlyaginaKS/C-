// Массив. Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find


//             0   1   2  4   5   6   7  8
int[] array = {21, 5, 67, 5, 76, 53, 1, 43};

int n = array.Length;
int find = 5;
int index = 0;

while (index < n)
{
    if(array[index] == find)
        {
        Console.WriteLine(index);
        // break Если мы хотим найти только первое значение, а их несколько в массиве
        break;
        }
       
              index++;

}

