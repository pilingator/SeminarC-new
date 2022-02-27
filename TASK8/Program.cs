// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите первое число => ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);

if (A%7 == 0 && A%23 == 0) Console.WriteLine($"число {A} кратно одновременно 7 и 23");
else 
Console.WriteLine($"число {A} не кратно одновременно 7 и 23");