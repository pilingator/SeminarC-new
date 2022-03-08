// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.

Console.Write("Введите первое число => ");
string inputA = Console.ReadLine();
double A = double.Parse(inputA);

Console.Write("Введите второе число => ");
string inputB = Console.ReadLine();
double B = double.Parse(inputB);

if (B % A == 0) Console.WriteLine("Второе число является кратным");
else 
Console.WriteLine($"Остаток от деления {B%A}");