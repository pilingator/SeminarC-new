﻿// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами 
//в случайном порядке. [1,0,1,1,0,1,0,0]

void FindArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}
void PrintArray(int[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ",");

    }
    Console.WriteLine(collect[7] + "]");
}
int[] arr = new int[8];

FindArray(arr);
PrintArray(arr);


