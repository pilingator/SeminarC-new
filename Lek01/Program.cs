// Лекция void
//Вид 1 ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Автор Прасолов И.С.");
}
//Method1();

// Вид 2 ничего не возвращают, но могут принимать аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // инкремент, если уменьшается на единицу декремент
    }
}
//Method21(msg: "Текст", count: 4); можно менять местами значения
//Method21(count: 4, msg: "Новый текст");

// Вид 3 Что-то возвращает, но ничего не принимает 

int Method3()
{
    return DateTime.Now.Year; 
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4 Что-то принимают и что-то возвращают 
//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//
 //   while (i < count)
//    {
//        result = result + text;
//        i++; 
//    }
//    return result;
//}

//string res = Method4(10, "Привет");
//Console.WriteLine(res);


// Вид 4 Вариант через цикл for 
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Привет");
Console.WriteLine(res);