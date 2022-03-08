// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 2D пространстве.
int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;   
}

int x1 = Prompt("Введите х первой точки => ");
int y1 = Prompt("Введите y первой точки => ");
int x2 = Prompt("Введите х второй точки => ");
int y2 = Prompt("Введите y второй точки => ");
int x3 = x1 - x2;
int y3 = y1 - y2;

double d = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2)); // math.sqrt - извлечение корня кв. 
                                                        // Math.Pow(x, 2) - возводит х в степень 2

Console.WriteLine($"Длина отрезака равна {d}");