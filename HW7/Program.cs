// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
Console.Write("Введите трехзначное число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);
if (N < 100) Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра заданного числа => {N%10}");
