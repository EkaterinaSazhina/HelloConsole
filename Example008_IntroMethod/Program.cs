int a1 = 55;
int a2 = 43;
int a3 = 54;
int b1 = 46;
int b2 = 696;
int b3 = 456;
int c1 = 53445;
int c2 = 50595;
int c3 = 2;
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
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

System.Console.Write(max);