
Console.WriteLine($"Hello, Word!");
ShowGreeting();


static void ShowGreeting()
{
    try
    {
        string userName = Environment.UserName;
        Console.WriteLine($"Hello, {userName}!");
    }
    catch
    {
        Console.WriteLine("Hello, User!");
    }
}