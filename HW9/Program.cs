// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.Write("Введите пятизначное число => ");
string inputNumber = Console.ReadLine();
int Length = inputNumber.Length;

if (inputNumber[0] == inputNumber[4] || inputNumber[1] == inputNumber[3]) 
Console.WriteLine($"Число {inputNumber} является палиндромом");
else 
Console.WriteLine($"Число {inputNumber} не является палиндромом");
