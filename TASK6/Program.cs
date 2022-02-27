// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Random rnd = new Random();
int value = rnd.Next(10, 99);
Console.WriteLine($"Случайне число из отрезка 10-99 = {value}");
int A = value%10; 
int B = value/10;
Console.WriteLine(A);
Console.WriteLine(B);
if (A>B) Console.WriteLine($"Максимальное число: {A}");
else 
if (A<B) Console.WriteLine($"Максимальное число: {B}");
else 
Console.WriteLine($"Числа {A} и {B} равны");
