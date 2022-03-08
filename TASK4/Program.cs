// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые 
//числа в промежутке от -N до N.

Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);

int A = 0 - N;
Console.WriteLine(A);
while (A < N)
{
    A++;
    Console.WriteLine(A);
}