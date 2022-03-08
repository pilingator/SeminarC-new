// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N
Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);

int A = 1;
while (A <= N)
{
    Console.WriteLine(Math.Pow(A, 2));
    A++;
}
