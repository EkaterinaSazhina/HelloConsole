int[] array = { 11, 12, 31, 14, 51, 16, 71, 18 };
int n = array.Length;
int find = 31;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
        index++;
}
