// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);
int proisv = 1;
for(int i = 1; i <= N; i++)
{
    proisv = proisv * i;
}
Console.WriteLine($"Произведением чисел от 1 до {inputNumber} является число {proisv}");
