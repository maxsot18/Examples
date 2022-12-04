// type1
void Method1()
{
    Console.WriteLine("Author ...");

}
Method1();
// Type 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Message");

// Type 2.1
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Message", 4);

// Type 3

int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
Console.WriteLine(Year);

// Type 4
// string Method4(int count, string c)
//{
//    int i = 0;
//    string result = String.Empty;
//
//       while(i < count)
//       {
//        result = result + "text";
//        i++;
//       }
//       return result;
//
//}
//string res = Method4(10, "wewqwqwe");
//Console.Write(res + "");





string Method41(int count, string text)
{
    string result = String.Empty;
    for (int b = 0; b < count; b++)
    {
        result = result + text;
    }
    return result;

}
string res1 = Method41(10, "wewqwqwe");
Console.Write(res1 + "");