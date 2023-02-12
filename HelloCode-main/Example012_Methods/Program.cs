// вид 1 методов (ничего не возвращает)

void Method1()
{
    Console.WriteLine("Автор ...");
}

// Method1();


// Вид 2 методов (ничего не возвращает но принимает)

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", 4);
// Method21(count: 4, msg: "новый текст");

// Вид 3 (метод который возвращает)

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 ( что то принимают, что то возвращют)
string method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
        while (i < count)
        {
        result = result + c;
         i++;
        }
        return result;
}
string res = method4(10, "asdf");
Console.WriteLine(res);