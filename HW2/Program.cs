// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число => ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);

Console.WriteLine("Введите второе число число => ");
string numberB = Console.ReadLine();
int B = int.Parse(numberB);

Console.WriteLine("Введите третье число число => ");
string numberC = Console.ReadLine();
int C = int.Parse(numberC);


if (A > B && A > C) Console.WriteLine($"Число {A} максимальное");
else 
if (B > C && B > A) Console.WriteLine($"Число {B} максимальное");
else 
if (C > A && C > B) Console.WriteLine($"Число {C} максимальное");
else 
Console.WriteLine($"Число {A}, {B}, {C} равны");
