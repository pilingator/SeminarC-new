﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
int Prompt(string message){
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
    
int x = Prompt("Введите х=> "); 
int y = Prompt("Введите y=> "); 

if (x == 0 || y == 0)
{
    Console.WriteLine("Одна из кординат точки равна нулю");
    return;
}

if (x > 0 && y > 0)
{
    Console.WriteLine($"Точка {x}, {y} находится в первой четверти");
}
else 
if (x > 0 && y < 0)
{
    Console.WriteLine($"Точка {x}, {y} находится в четвертой четверти");
}
else
if (x < 0 && y < 0)
{
    Console.WriteLine($"Точка {x}, {y} находится в третьей четверти");
}
else 
{
    Console.WriteLine($"Точка {x}, {y} находится в второй четверти");
}
