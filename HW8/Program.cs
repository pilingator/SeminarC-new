// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите порядковый номер дня недели => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);
if (N > 7) Console.WriteLine("В неделе 7 дней");
else
if (N >0 && N < 6) Console.WriteLine("Выбранный день недели не является выходным");
else 
if (N > 5 && N < 8) Console.WriteLine("Выбрынный день недели ВЫХОДНОЙ!!!");