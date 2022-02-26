//Дни недели
Console.Write("Введите число => ");
string inputNumber = Console.Readline();
int number = int.Parse(inputNumber);

If (number == 1) Console.WriteLine("Понедельник"); else
If (number == 2) Console.WriteLine("Вторник"); else
If (number == 3) Console.WriteLine("Среда"); else
If (number == 4) Console.WriteLine("Четверг"); else
If (number == 5) Console.WriteLine("Пятница"); else
If (number == 6) Console.WriteLine("Суббота"); else
If (number == 7) Console.WriteLine("Вскресенье"); else
{
    Console.WriteLine("В неделе 7 дней!");
}