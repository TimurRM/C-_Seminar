// 1-st group of methods

 void Method1()
 {
    Console.WriteLine("Author ...");
 }
Method1();
Console.WriteLine();

// 2-nd group of methods

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Message Text");
Console.WriteLine();

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
     Console.WriteLine(msg);    
     i ++;
    }
}
Method21(msg: "Message Text", count: 4);
Console.WriteLine();

// 3-d group of methods

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
Console.WriteLine();

// 4-th group of methods

string Method4(int count, string text)
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

string res = Method4(count: 10, text: "Text qwerty ");
Console.WriteLine(res);
Console.WriteLine();

// cycle for

string CycleFor(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text; 
    }
    return result;
}

string resfor = CycleFor(count: 10, text: " - Text Z -");
Console.WriteLine(resfor);

Console.WriteLine();

// cycle for in cycle

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }   
    Console.WriteLine();
}