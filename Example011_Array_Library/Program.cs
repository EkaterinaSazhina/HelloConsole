﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
      if(collection[index] == find)
      {
        position = index;
      }
      index++;
      break;
    }
    return position;
}

int[] array = new int[10];// создай новый массив  в котором будет 10 элементов

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
 
 int pos = IndexOf(array, 4);
 System.Console.WriteLine(pos);