// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
Console.WriteLine("Введите первое число => ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);

Console.WriteLine("Введите второе число число => ");
string numberB = Console.ReadLine();
int B = int.Parse(numberB);

if (A > B) Console.WriteLine($"Число {A} больше числа {B}");
else 
if (A < B) Console.WriteLine($"Число {B} больше числа {A}");
else 
Console.WriteLine($"Число {A} и {B} равны");
