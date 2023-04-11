// Находим максимум из 9 чисел 


int a1 = 13;
int b1 = 16;
int c1 = 1;

int a2 = 122;
int b2 = 126;
int c2 = 51;


int a3 = 72222;
int b3 = 76;
int c3 = 9;


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max (Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


Console.WriteLine(max);