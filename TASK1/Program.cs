//Сравнение квадрата числа а с числм b
Console.Write("Введите число А=> ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

Console.Write("Введите число В=> ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

int value = numberA * numberA;
if (numberB == value) Console.WriteLine("Да");
else
{
    Console.WriteLine("нет");
}