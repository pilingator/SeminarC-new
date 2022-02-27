// Напишите программу, которая 
//принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите трехзначное число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);
Console.WriteLine($"Последняя цифра введенного числа {N%10}");