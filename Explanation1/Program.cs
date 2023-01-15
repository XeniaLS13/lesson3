//Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i=0; //(значение переменной count, чтобы показывать на экране определённое количество сообщений msg, которые будут передаваться в наш метод)
    while (i < count)
    {
        Console.WriteLine(msg); 
        i++;
    }
}
Method21("Текст", 4); // через запятую указываем, сколько раз конкретно мы хотим увидеть это сообщение
Method21(count: 4, msg: "новый текст"); // Если используем именованные аргументы, не обязательно их использовать по порядку.

//Вид 3
// Если метод что-то возвращает, мы в обязательном порядке должны указать тип данных, значения которых мы ожидаем.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4

string Method4(int count, string ctext)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

// Цикл for

string Method4(int count, string ctext)
{
    string result = String.Empty;

    for (int i =0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

// Таблица умножения (цикл внутри цикла)
for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i * j}");
    }
    Console.WriteLine();
}