
Console.WriteLine($"Hello, Word!");
ShowGreeting();


static void ShowGreeting()
{
    try
    {
        string userName = Environment.UserName;
        Console.WriteLine($"Hi, {userName}!");
    }
    catch
    {
        Console.WriteLine("Hi, User!");
    }
}