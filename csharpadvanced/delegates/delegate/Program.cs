static void LogTextToScreen(string text){
   Console.WriteLine($"{DateTime.Now}: {text}");
}

static void LogToFile(string text) {
   using var sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt"), true);
   sw.WriteLine($"{DateTime.Now}: {text}");
}

LogDel logTofile, logToConsole;
logTofile = new LogDel(LogToFile);
logToConsole = new LogDel(LogTextToScreen);

LogDel multiLogDel = logTofile + logToConsole;

Console.WriteLine("Please enter your name");
var name = Console.ReadLine();
multiLogDel(name);

delegate void LogDel(string text);



