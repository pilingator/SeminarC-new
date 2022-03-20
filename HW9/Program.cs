// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.Write("Введите пятизначное число => ");
string N = Console.ReadLine();
int Length = N.Length;
if (Length > 5 || Length <= 4) Console.WriteLine($"Вы ввели не пятизначное число");
else 
if (N[0] == N[4] && N[1] == N[3]) 
Console.WriteLine($"Число {N} является палиндромом");
else 
Console.WriteLine($"Число {N} не является палиндромом");
