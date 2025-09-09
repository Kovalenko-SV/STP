Console.WriteLine("Application Started");
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
}

static void ShowCurrentTime()
{
    Console.WriteLine($"Current time: {DateTime.Now:HH:mm:ss}");
}

static void ShowSystemInfo()
{
    Console.WriteLine($"OS: {Environment.OSVersion}");
    Console.WriteLine($"Machine: {Environment.MachineName}");
}