
Console.WriteLine("Greeting Application Started");
Console.WriteLine($"Hello, Word!");
ShowGreeting();
ShowCurrentTime(); 

static void ShowGreeting()
{
    try
    {
        string userName = Environment.UserName;
        Console.WriteLine($"Hello and welcome, {userName}!");
    }
    catch
    {
        Console.WriteLine("Hello, User!");
    }
    
    ShowAdditionalGreeting();
}


static void ShowAdditionalGreeting()
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

static void ShowCurrentTime()
{
    Console.WriteLine($"Current time: {DateTime.Now:HH:mm:ss}");
}