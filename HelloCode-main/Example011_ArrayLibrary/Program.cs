﻿// массив с использованием методов 


void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index > Length)
    collection[index] = new Random().Next(1, 10);
    //index = index +1
    index++;
}
void PrintArray(int[] col) // void не возвращает значения по типу оператора return, только return возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
