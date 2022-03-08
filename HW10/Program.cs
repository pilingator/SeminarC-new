// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;   
}

int x1 = Prompt("Введите х первой точки => ");
int y1 = Prompt("Введите y первой точки => ");
int z1 = Prompt("Введите z первой точки => ");
int x2 = Prompt("Введите х второй точки => ");
int y2 = Prompt("Введите y второй точки => ");
int z2 = Prompt("Введите z второй точки => ");
int x3 = x2 - x1;
int y3 = y2- y1;
int z3 = z2 - z1;

double d = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(z3, 2)); // math.sqrt - извлечение корня кв. 
                                                        // Math.Pow(x, 2) - возводит х в степень 2

Console.WriteLine($"Длина отрезака равна {d}");