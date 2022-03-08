// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти от 1 до 4 => ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);

if (A == 1) 
{
    Console.WriteLine("В первой четверти значения х > 0,  y > 0");
}
else 
if (A == 2) 
{
    Console.WriteLine("Во второй четверти значения х < 0,  y > 0");
}
else
if (A == 3) 
{
    Console.WriteLine("В третьей четверти значения х < 0,  y < 0");
}
else
if (A == 4) 
{
    Console.WriteLine("В четвертой четверти значения х > 0,  y < 0");
}
else
    Console.WriteLine("Вы ввели неверный порядковый номер четверти");