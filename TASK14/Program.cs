// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);
int sum = 0;
for(int A = 0; A <= N; A++)
{
    sum = sum + A;
}
Console.WriteLine(sum);
