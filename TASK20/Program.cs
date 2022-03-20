// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);
int i = 1;
while(N / 10 != 0)
{
    N = N / 10;
    i++;
}
Console.WriteLine($"Количество цифр в числе {inputNumber} равно {i} ");