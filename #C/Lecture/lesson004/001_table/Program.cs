// Двумерные массивы
//string[,] table = new string [2, 5];
 
 // String.Empty
 // Нумерация элементов идет от 0

 // table [1,2] = "hi";
 //for (rows = 0; rows < 2; rows++)
 //{
 //   for (int columns = 0; i < 5; columns++)
 //   {
 //       Console.WriteLine($"-{table[rows, columns]}");
 //   }
 //}



void PrintArray(int[,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j =0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
         matr [i, j] = new Random().Next(1,10);
        }
    }
}

int [,] matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);