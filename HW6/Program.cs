// Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
Random rnd = new Random(); 
int value = rnd.Next(99, 999);
int A = 0;
int B = 0;
Console.WriteLine($"Случайное трехзначное число: {value}");
A = value/100;
B = value%10;
Console.WriteLine($"Трехзначное число без второй цифры: {A}{B}");