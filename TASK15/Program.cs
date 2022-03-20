// Программа генерирует случайное число и выводит кличество цифр в числе
//string number = Promt("Введите число => "); 
//int len = number.Length; 
string number = Randomize();
int lenT = number.Length;
Console.WriteLine($"Количество цифр в числе {number} равно {lenT}");

string Randomize()  
{
Random rnd = new Random();
int digit = rnd.Next();
string newDigit = digit.ToString();
return newDigit;
}

string Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    return strValue;
}




