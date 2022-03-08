// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет 
Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int Length = inputNumber.Length;

if (Length > 2) Console.WriteLine($"Третья цифра заданного числа {inputNumber[2]}");
else 
Console.WriteLine("Третьей цифры нет");