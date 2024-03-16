// Solution 1
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

//  Solution 2
string projectName = "ACME";
string englishLocation = "data.txt";
string projectLocation = $@"c:\Exercise\{projectName}";
string russianLocation = $@"ru-RU\data.txt";
string englishMessage = $"View English output:\n\t\t{projectLocation}\\{englishLocation}\n";
string russianMessage = $"\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434\n\t\t{projectLocation}{russianLocation}\n";
Console.WriteLine($"{englishMessage}");
Console.WriteLine($"{russianMessage}");

// Solution 3
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
  c:\Exercise\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage}:
  c:\Exercise\ACME\ru-RU\data.txt");