
Console.WriteLine($"Hello, Word!");
ShowGreeting();
ShowCurrentTime(); 

static void ShowGreeting()
{
    try
    {
        string userName = Environment.UserName;
        Console.WriteLine($"Hi, {userName}!");
        Console.WriteLine("Welcome to our application!"); 
    }
    catch
    {
        Console.WriteLine("Hi, User!");
        Console.WriteLine("Welcome to our application!");
    }
}


static void ShowCurrentTime()
{
    Console.WriteLine($"Current time: {DateTime.Now:HH:mm:ss}");
}