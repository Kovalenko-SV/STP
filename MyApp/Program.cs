
Console.WriteLine($"Hello, Word!");
ShowGreeting();


static void ShowGreeting()
{
    try
    {
        string userName = Environment.UserName;
        Console.WriteLine($"Welcome, {userName}!");
    }
    catch
    {
        Console.WriteLine("Welcome, User!");
    }
}